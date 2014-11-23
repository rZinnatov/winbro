using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileSearcher.Settings
{
    [XmlRoot("Config")]
    public class SerializeConfig
    {
        [XmlElement]
        public string RootPath { get; set; }
    }
}
