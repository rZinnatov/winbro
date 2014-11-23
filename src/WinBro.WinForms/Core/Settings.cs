using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBro.WinForms.Core
{
    public class Settings
    {
        #region API
        public bool ChildFormShown { get; set; }
        public bool AppHostKeepShowing { get; set; }
        public System.Drawing.Point SearchResultFormAnchor { get; set; }
        #endregion
        #region Singleton Implementation
        public static readonly Settings Instance = new Settings();
        private Settings()
        {
        }
        #endregion
    }
}
