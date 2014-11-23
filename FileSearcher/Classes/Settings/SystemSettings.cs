using System;
using System.IO;
using System.Reflection;

namespace FileSearcher.Settings
{
    /// <summary>
    /// Singleton
    /// </summary>
    class SystemSettings
    {
        #region API

        #region Static

        static public SystemSettings Instance { get { return _instance; } }

        #endregion

        #region Non-Static

        /// <summary>
        /// Gets or sets the value that indicates whether search
        /// mechanism can rely on its cash
        /// </summary>
        public bool UseCash { get; set; }
        public bool ChildFormShown { get; set; }
        public bool AppHostKeepShowing { get; set; }

        /// <summary>
        /// Maximum value of path to file system entry.
        /// If path exceeds the maximum value then PathTooLongException would be thrown.
        /// </summary>
        public int MaxPathLength
        {
            get { return _maxPathLength; }
        }

        /// <summary>
        /// Gets or sets point to SearchResultForm anchor.
        /// </summary>
        public System.Drawing.Point SearchResultFormAnchor
        {
            get
            {
                return _popupAnchor;
            }
            set
            {
                _popupAnchor = value;
            }
        }

        public string AppName { get; private set; }
        public string ExecutablePath { get { return System.Windows.Forms.Application.ExecutablePath.ToString(); } }
        /// <summary>
        /// Gets or sets path to search root. Path to root must be an absolute rooted path
        /// Throws ArgumentException if path is not rooted.
        /// Throws DirectoryNotFoundException if path points to non-existing folder.
        /// </summary>
        public string RootPath
        {
            get
            {
                return _rootPath;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _rootPath = String.Empty;
                    return;
                }

                if (_rootPath == value)
                {
                    return;
                }

                if (!Path.IsPathRooted(value))
                {
                    throw new ArgumentException("'Root path' must be an absolute rooted path, but " + value);
                }
                if (!Directory.Exists(value))
                {
                    throw new DirectoryNotFoundException();
                }

                UseCash = false;
                _rootPath = value;
            }
        }

        internal void Restore(SerializeConfig reservedConfig)
        {
            this.RootPath = reservedConfig.RootPath;
        }

        #endregion

        #endregion

        #region Background

        #region Static

        static private SystemSettings _instance = new SystemSettings();

        #endregion

        #region Non-Static

        private string _rootPath;
        private int _maxPathLength = (int)typeof(Path).GetField(
            "MaxPath",
            BindingFlags.Static | BindingFlags.GetField | BindingFlags.NonPublic
            ).GetValue(null);
        private System.Drawing.Point _popupAnchor;

        #endregion

        #endregion

        #region Factory Methods

        protected SystemSettings()
        {
            UseCash = true;

            AppName = "FileSearcher";

            _rootPath = String.Empty;
        }

        #endregion
    }
}
