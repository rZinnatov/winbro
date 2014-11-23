using Microsoft.Win32;

namespace WinBro.Core.Util
{
    /// <summary>
    /// Allows to manage Windows registry
    /// </summary>
    class WinRegistry
    {
        #region API

        static public WinRegistry Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Set registry key to automatically run application
        /// on Windows startup.
        /// </summary>
        /// <param name="appName">application name</param>
        /// <param name="executablePath">path to exe-file</param>
        /// <param name="currentUser">If set to true sets registry key for current user. Otherwise, for local machine</param>
        public void SetAutoRun(string appName, string executablePath, bool currentUser)
        {
            RegistryKey rootKey = currentUser ? Registry.CurrentUser : Registry.LocalMachine;

            RegistryKey regKey = rootKey.OpenSubKey(AUTORUN_PATH, true);
            regKey.SetValue(appName, executablePath);
        }
        /// <summary>
        /// Removes application from autorun.
        /// </summary>
        /// <param name="appName">application name</param>
        /// <param name="currentUser">If set to true sets registry key for current user. Otherwise, for local machine</param>
        public void RemoveAutoRun(string appName, bool currentUser)
        {
            RegistryKey rootKey = currentUser ? Registry.CurrentUser : Registry.LocalMachine;

            RegistryKey regKey = rootKey.OpenSubKey(AUTORUN_PATH, true);
            regKey.DeleteValue(appName, false);
        }
        /// <summary>
        /// Never returns null
        /// </summary>
        /// <param name="appName">application name</param>
        /// <returns>an instance of AutoRunRegistryKey class</returns>
        public AutoRunRegistryKey CheckAutoRun(string appName)
        {
            if (Registry.CurrentUser.OpenSubKey(AUTORUN_PATH, true).GetValue(appName) != null)
            {
                return new AutoRunRegistryKey(true);
            }

            return new AutoRunRegistryKey();
        }

        #endregion

        #region Background

        private static WinRegistry _instance = new WinRegistry();
        private const string AUTORUN_PATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        #endregion

        #region Factory Methods

        #endregion
    }
}
