using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinBro.Core.Util;

namespace WinBro.Core.Settings
{
    public class CoreSettings
    {
        #region API
        public bool RunOnWindowsStartup
        {
            get
            {
                return _IsRunOnWindowsStartup();
            }
            set
            {
                if (value)
                {
                    _SetRunOnWindowsStartup();
                }
                else
                {
                    _RemoveRunOnWindowsStartup();
                }
            }
        }

        public string AppName { get; private set; }
        public string ExecutablePath { get { return System.Windows.Forms.Application.ExecutablePath.ToString(); } }

        #endregion
        #region Background

        private bool _IsRunOnWindowsStartup()
        {

            try
            {
                return WinRegistry.Instance.CheckAutoRun(AppName).RunOnStartup;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void _SetRunOnWindowsStartup()
        {
            try
            {
                WinRegistry.Instance.SetAutoRun(AppName, ExecutablePath, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void _RemoveRunOnWindowsStartup()
        {
            try
            {
                WinRegistry.Instance.RemoveAutoRun(AppName, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
        #region Singleton Implementation
        public static readonly CoreSettings Instance = new CoreSettings();
        private CoreSettings()
        {
            AppName = "WinBro";
        }
        #endregion
    }
}
