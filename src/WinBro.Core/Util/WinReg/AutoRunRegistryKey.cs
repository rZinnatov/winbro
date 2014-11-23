using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.Core.Util
{
    class AutoRunRegistryKey
    {
        public bool RunOnStartup { get; set; }
        public bool ForCurrentUser { get; set; }

        /// <summary>
        /// Default constructor for AutoRunRegistryKey class
        /// </summary>
        public AutoRunRegistryKey()
        {
            RunOnStartup = false;
            ForCurrentUser = false;
        }
        /// <summary>
        /// AutoRunRegistryKey class constructor. Sets RunOnStartup to true.
        /// </summary>
        /// <param name="forCurrentUser">If set to true sets registry key for current user. Otherwise, for local machine</param>
        public AutoRunRegistryKey(bool forCurrentUser)
        {
            RunOnStartup = true;
            ForCurrentUser = forCurrentUser;
        }
    }
}
