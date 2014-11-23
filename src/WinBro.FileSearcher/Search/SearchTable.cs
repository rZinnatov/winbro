using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.FileSearcher.Search
{
    public class SearchTable
    {
        #region API
        public static readonly SearchTable Instance = new SearchTable();

        /// <summary>
        /// Gets currently processing query.
        /// </summary>
        public string Query { get; private set; }
        /// <summary>
        /// Perform searching directories and files by part of its name.
        /// </summary>
        /// <param name="query">Part of the name of directory or file</param>
        /// <returns></returns>
        public SearchResult Search(string query)
        {
            Query = query.ToLower();

            var cashedResult = _CheckCacheForResult();
            if (cashedResult.IsSucceeded)
            {
                return cashedResult;
            }

            var searchResult = _Search();
            if (searchResult.IsSucceeded)
            {
                _PutSearchResultToCache(searchResult);
            }

            return searchResult;
        }
        #endregion

        #region Background
        private Dictionary<string, SearchResult> _cache;

        private SearchResult _Search()
        {
            if (String.IsNullOrEmpty(WinBro.Core.Settings.FileSearcherSettings.Instance.RootPath))
            {
                return new SearchResult("Please, set root path");
            }
            if (String.IsNullOrEmpty(Query))
            {
                return new SearchResult("Please, enter part of file/directory name");
            }
            
            List<SearchEntry> resultDirs = new List<SearchEntry>();
            List<SearchEntry> resultFiles = new List<SearchEntry>();

            List<string> currentLevelDirs = new List<string> { WinBro.Core.Settings.FileSearcherSettings.Instance.RootPath };
            while (true)
            {
                resultDirs.AddRange(
                    _SearchCurrentLevel(ref currentLevelDirs)
                );

                if (!currentLevelDirs.Any())
                {
                    break;
                }
            }

            //var files = Directory.GetFiles(cur_dir)
            //    .Where(f => f.Contains(Query))
            //    .Select<string, SearchEntry>(f => new SearchEntry(true, Path.GetFileName(f), f));

            return new SearchResult(resultFiles, resultDirs);
        }
        private IEnumerable<SearchEntry> _SearchCurrentLevel(ref List<string> currentLevelDirs)
        {
            var resultDirs = new List<SearchEntry>();

            var nextLevelDirs = new List<string>();
            foreach (var dir in currentLevelDirs)
            {
                var subDirs = Directory.GetDirectories(dir).Where(d => d.Length < WinBro.Core.Settings.FileSearcherSettings.Instance.MaxPathLength);
                if (!subDirs.Any())
                {
                    continue;
                }

                nextLevelDirs.AddRange(subDirs);

                resultDirs.AddRange(subDirs
                    .Where(d => Path.GetFileName(d).ToLower().Contains(Query))
                    .Select<string, SearchEntry>(d => new SearchEntry(false, Path.GetFileName(d), d))
                );
            }

            currentLevelDirs = new List<string>(nextLevelDirs);
            return resultDirs;
        }
        private SearchResult _CheckCacheForResult()
        {
            if (WinBro.Core.Settings.FileSearcherSettings.Instance.UseCash)
            {
                if (_cache.Keys.Contains(Query))
                {
                    return Instance._cache.SingleOrDefault(c => c.Key == Query).Value;
                }
            }
            else
            {
                _cache.Clear();
                WinBro.Core.Settings.FileSearcherSettings.Instance.UseCash = true;
            }

            return SearchResult.Fail;
        }
        private void _PutSearchResultToCache(SearchResult searchResult)
        {
            Instance._cache[Query] = searchResult;
        }
        #endregion

        #region Factory Methods

        protected SearchTable()
        {
            _cache = new Dictionary<string, SearchResult>();
        }

        #endregion
    }
}
