using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.Core.Settings
{
    public class FileSearcherSettings
    {
        #region API
        public bool UseCash { get; set; }
        public string RootPath
        {
            get
            {
                return _rootPath;
            }
            set
            {
                if (_rootPath == null)
                {
                    throw new ArgumentNullException("RootPath");
                }

                if (value == String.Empty)
                {
                    _rootPath = String.Empty;
                    return;
                }


                if (!System.IO.Path.IsPathRooted(value))
                {
                    throw new ArgumentException(String.Format(
                        "Root path must be an absolute rooted path, but \"{0}\" was supplied: ",
                        value)
                    );
                }

                if (!System.IO.Directory.Exists(value))
                {
                    throw new System.IO.DirectoryNotFoundException(String.Format(
                        "directory {0} does not exist",
                        value)
                    );
                }

                UseCash = false;
                _rootPath = value;
            }
        }
        public int MaxPathLength { get; private set; }

        public FileSearcherSettings Clone()
        {
            return new FileSearcherSettings();
        }
        public void Init(FileSearcherSettings settings)
        {
            UseCash = settings.UseCash;
            RootPath = settings.RootPath;
        }
        #endregion
        #region Singleton Implementation
        public static readonly FileSearcherSettings Instance = new FileSearcherSettings();
        private string _rootPath;
        private FileSearcherSettings()
        {
            _rootPath = String.Empty;
            MaxPathLength = (int)typeof(System.IO.Path)
                .GetField(
                    "MaxPath",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.NonPublic)
                .GetValue(null);
        }
        #endregion
    }
}
