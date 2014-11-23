using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.Core.Settings
{
    public class SettingsManager
    {
        #region API
        public void SaveSettings()
        {
            Properties.Settings.Default.RootPath = FileSearcherSettings.Instance.RootPath;
            Properties.Settings.Default.Save();
        }
        public void LoadSettings()
        {
            FileSearcherSettings.Instance.RootPath = Properties.Settings.Default.RootPath;
        } 
        #endregion
        #region Singleton Implementation
        public static readonly SettingsManager Instance = new SettingsManager();
        private SettingsManager()
        {
        }
        #endregion
    }
}
