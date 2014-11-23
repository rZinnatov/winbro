using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher.Core
{
    class Config
    {
        #region API

        #region Static

        public static Config Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Method must be called when user opens settings form
        /// </summary>
        public static void StartChangeSession()
        {
            _reservedConfig = Instance._MakeSerializeConfig();
        }
        /// <summary>
        /// Method must be called if user has canceled his changes.
        /// </summary>
        public static void CancelChangeSession()
        {
            if (_reservedConfig == null)
            {
                return;
            }

            Instance.Restore(_reservedConfig);

            _reservedConfig = null;
        }
        /// <summary>
        /// Must be called when user saves his changes
        /// </summary>
        public static void ApplyChangeSession(FileSearcher.Util.AutoRunRegistryKey autoRunRegKey)
        {
            _reservedConfig = null;

            Instance.AutoRun.RunOnStartup = autoRunRegKey.RunOnStartup;
        }

        #endregion

        #region Non-Static

        public Settings.SystemSettings System { get { return Settings.SystemSettings.Instance; } }
        public Settings.AutoRunSettings AutoRun { get { return Settings.AutoRunSettings.Instance; } }

        public void Save()
        {
            Properties.Settings.Default.RootPath = Instance.System.RootPath;
            Properties.Settings.Default.Save();
        }
        public void Load()
        {
            Instance.System.Restore(new FileSearcher.Settings.SerializeConfig
            {
                RootPath = Properties.Settings.Default.RootPath
            });
        }

        private void Restore(Settings.SerializeConfig _restoreConfig)
        {
            Instance.System.Restore(_restoreConfig);
        }

        #endregion

        #endregion

        #region Background

        private static Config _instance = new Config();
        private static Settings.SerializeConfig _reservedConfig;

        private Settings.SerializeConfig _MakeSerializeConfig()
        {
            return new FileSearcher.Settings.SerializeConfig
            {
                RootPath = Instance.System.RootPath
            };
        }

        #endregion

        #region Factory Methods

        protected Config()
        {
        }

        #endregion
    }
}
