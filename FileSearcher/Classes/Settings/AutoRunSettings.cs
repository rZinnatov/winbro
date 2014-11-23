using FileSearcher.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinRegistry = FileSearcher.Util.WinRegistry;

namespace FileSearcher.Settings
{
    /// <summary>
    /// Does not store any value. Every time checks Windows registry.
    /// </summary>
    class AutoRunSettings
    {
        #region API

        public static AutoRunSettings Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Gets value indicates whether application runs on Windows startup.
        /// </summary>
        public bool RunOnStartup
        {
            get
            {
                try
                {
                    return WinRegistry.Instance.CheckAutoRun(Config.Instance.System.AppName).RunOnStartup;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
            set
            {
                if (value)
                {
                    _SetRunOnStartup();
                }
                else
                {
                    _RemoveRunOnStartup();
                }
            }
        }

        #endregion

        #region Background

        private static AutoRunSettings _instance = new AutoRunSettings();

        private void _SetRunOnStartup()
        {
            try
            {
                WinRegistry.Instance.SetAutoRun(Config.Instance.System.AppName, Config.Instance.System.ExecutablePath, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void _RemoveRunOnStartup()
        {
            try
            {
                WinRegistry.Instance.RemoveAutoRun(Config.Instance.System.AppName, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
        
        #region Factory Methods

        protected AutoRunSettings()
        {
        }

        #endregion
    }
}
