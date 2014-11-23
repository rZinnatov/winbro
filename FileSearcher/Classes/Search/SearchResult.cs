using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    public class SearchResult
    {
        public bool IsSucceeded { get; private set; }
        public string Message { get; private set; }
        public IEnumerable<SearchEntry> Files { get; private set; }
        public IEnumerable<SearchEntry> Directories { get; private set; }

        public SearchResult(string message)
        {
            IsSucceeded = false;
            Message = message;

            Files = new List<SearchEntry>();
            Directories = new List<SearchEntry>();
        }
        public SearchResult(IEnumerable<SearchEntry> files, IEnumerable<SearchEntry> directories)
        {
            IsSucceeded = true;
            Message = String.Empty;

            Files = files;
            Directories = directories;
        }
        public SearchResult()
        {
            IsSucceeded = false;
            Message = String.Empty;

            Files = new List<SearchEntry>();
            Directories = new List<SearchEntry>();
        }
    }
}
