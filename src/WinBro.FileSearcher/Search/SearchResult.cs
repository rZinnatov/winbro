using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.FileSearcher.Search
{
    public class SearchResult
    {
        public static readonly SearchResult Fail = new SearchResult();

        public bool IsSucceeded { get; private set; }
        public string Message { get; private set; }
        public IEnumerable<SearchEntry> Files { get; private set; }
        public IEnumerable<SearchEntry> Directories { get; private set; }

        public SearchResult(string message) :
            this(false, message, new List<SearchEntry>(), new List<SearchEntry>())
        {
        }
        public SearchResult(IEnumerable<SearchEntry> files, IEnumerable<SearchEntry> directories) :
            this(true, String.Empty, files, directories)
        {
        }
        public SearchResult() :
            this(false, String.Empty, new List<SearchEntry>(), new List<SearchEntry>())
        {
        }
        public SearchResult(
            bool isSucceeded,
            string message,
            IEnumerable<SearchEntry> files,
            IEnumerable<SearchEntry> directories)
        {
            IsSucceeded = isSucceeded;
            Message = message;

            Files = files;
            Directories = directories;
        }
    }
}
