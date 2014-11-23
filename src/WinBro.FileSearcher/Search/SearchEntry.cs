using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.FileSearcher.Search
{
    public class SearchEntry
    {
        public bool IsFile { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public SearchEntry() :
            this(false, String.Empty, String.Empty)
        {
        }
        public SearchEntry(bool isFile, string name, string path)
        {
            IsFile = isFile;
            Name = name;
            Path = path;
        }
    }
}
