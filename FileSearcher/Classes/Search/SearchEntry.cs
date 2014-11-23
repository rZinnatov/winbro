using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
    public class SearchEntry
    {
        public bool IsFile { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }

        public SearchEntry(bool isFile, string name, string path)
        {
            IsFile = isFile;
            Name = name;
            Path = path;
        }
    }
}
