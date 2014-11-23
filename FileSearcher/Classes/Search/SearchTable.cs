using FileSearcher.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    class SearchTable
    {
        #region API

        public static SearchTable Instance
        {
            get
            {
                return _instance;
            }
        }

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
            if (cashedResult != null)
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

        #region Static

        private static SearchTable _instance = new SearchTable();

        #endregion

        #region Non-Static

        private SearchResult _Search()
        {
            if (String.IsNullOrEmpty(Config.Instance.System.RootPath))
            {
                return new SearchResult("Please, set root path");
            }
            if (String.IsNullOrEmpty(Query))
            {
                return new SearchResult("Please, enter part of file/directory name");
            }
            
            List<SearchEntry> resultDirs = new List<SearchEntry>();
            List<SearchEntry> resultFiles = new List<SearchEntry>();

            List<string> currentLevelDirs = new List<string> { Config.Instance.System.RootPath };
            while (true)
            {
                List<string> nextLevelDirs = new List<string>();
                _SearchCurrentLevel(resultDirs, currentLevelDirs, nextLevelDirs);

                if (!nextLevelDirs.Any())
                {
                    break;
                }
                currentLevelDirs = new List<string>(nextLevelDirs);
            }

            //var files = Directory.GetFiles(cur_dir)
            //    .Where(f => f.Contains(Query))
            //    .Select<string, SearchEntry>(f => new SearchEntry(true, Path.GetFileName(f), f));

            return new SearchResult(resultFiles, resultDirs);
        }
        private void _SearchCurrentLevel(List<SearchEntry> result_dirs, List<string> current_level_dirs, List<string> next_level_dirs)
        {
            foreach (var dir in current_level_dirs)
            {
                var sub_dirs = Directory.GetDirectories(dir).Where(d => d.Length < Config.Instance.System.MaxPathLength);
                if (!sub_dirs.Any())
                {
                    continue;
                }

                next_level_dirs.AddRange(sub_dirs);

                result_dirs.AddRange(sub_dirs
                    .Where(d => Path.GetFileName(d).ToLower().Contains(Query))
                    .Select<string, SearchEntry>(d => new SearchEntry(false, Path.GetFileName(d), d))
                );
            }
        }

        private SearchResult _CheckCacheForResult()
        {
            if (Config.Instance.System.UseCash)
            {
                if (Instance._cache.Keys.Contains(Query))
                {
                    return Instance._cache.SingleOrDefault(c => c.Key == Query).Value;
                }
            }
            else
            {
                Instance._cache.Clear();
                Config.Instance.System.UseCash = true;
            }

            return null;
        }
        private void _PutSearchResultToCache(SearchResult searchResult)
        {
            Instance._cache[Query] = searchResult;
        }

        private Dictionary<string, SearchResult> _cache;

        #endregion

        #endregion

        #region Factory Methods

        protected SearchTable()
        {
            _cache = new Dictionary<string, SearchResult>();
        }

        #endregion
    }
}
