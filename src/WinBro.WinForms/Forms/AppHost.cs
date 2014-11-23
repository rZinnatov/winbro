using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBro.Core.Util;
using WinBro.FileSearcher.Search;
using WinBro.WinForms.Core;

namespace WinBro.WinForms.Forms
{
    public partial class AppHost : Form, WinBro.WinForms.Core.IHideToTrayForm
    {
        #region API
        protected override void WndProc(ref Message msg)
        {
            base.WndProc(ref msg);

            if (_wndProcFuncs.Keys.Contains(msg.Msg))
            {
                _wndProcFuncs[msg.Msg](msg.WParam);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.E):
                    cmiExit.PerformClick();
                    break;
                case (Keys.Control | Keys.S):
                    btnSettings.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #region IHideToTrayForm Implementation

        public void ShowFromTray()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        public void HideToTray()
        {
            rtbSearch.Clear();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        #endregion
        #endregion
        #region Events
        #region Form
        private void AppHost_Shown(object sender, EventArgs e)
        {
            // <-- TODO: WARNING: Fucking magic
            WinForms.Core.Settings.Instance.SearchResultFormAnchor =
                rtbSearch.PointToScreen(new Point
                {
                    X = rtbSearch.Left - 3,
                    Y = rtbSearch.Bottom - 6
                }
            );
            // --/>
        }
        private void AppHost_Deactivate(object sender, EventArgs e)
        {
            if (WinForms.Core.Settings.Instance.ChildFormShown)
            {
                return;
            }

            if (WinForms.Core.Settings.Instance.AppHostKeepShowing)
            {
                return;
            }

            HideToTray();
        }
        #endregion
        #region Menu
        private void cmiExit_Click(object sender, EventArgs e)
        {
            niTray.Dispose();
            HotKey.UnregisterAll();

            Application.Exit();
        }
        private void cmiOpen_Click(object sender, EventArgs e)
        {
            ShowFromTray();
        }
        #endregion
        #region Button
        private void btnHide_Click(object sender, EventArgs e)
        {
            HideToTray();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            WinForms.Core.Settings.Instance.ChildFormShown = true;
            _settingsForm.ShowDialog();
        }
        #endregion
        #region TextBox
        private void rtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
            {
                return;
            }

            var result = SearchTable.Instance.Search(rtbSearch.Text);
            if (!result.IsSucceeded)
            {
                _ShowMessage(result.Message);
                return;
            }

            var resultForm = new SearchResultForm(result, (this as IHideToTrayForm));
            WinForms.Core.Settings.Instance.ChildFormShown = true;
            resultForm.Show();
        }
        #endregion
        #region NotifyIcon
        private void niTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowFromTray();
        }
        #endregion
        #region FileSystemWatcher
        private void fswRoot_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            WinBro.Core.Settings.FileSearcherSettings.Instance.UseCash = false;
        }
        #endregion
        #endregion
        #region Background
        private SettingsForm _settingsForm;

        private delegate void WndProcFunc(IntPtr hotkey_id);
        private Dictionary<int, WndProcFunc> _wndProcFuncs;

        private void _ProcessHotKey(IntPtr hotkey_id)
        {
            WinBro.Core.Util.HotKey.InvokeHandler(hotkey_id);
        }
        private void _ShowMessage(string message)
        {
            WinForms.Core.Settings.Instance.AppHostKeepShowing = true;

            MessageBox.Show(message);

            WinForms.Core.Settings.Instance.AppHostKeepShowing = false;
        }
        #endregion
        #region Factory Methods
        public AppHost()
        {
            InitializeComponent();

            WinBro.Core.Settings.SettingsManager.Instance.LoadSettings();
            _settingsForm = new SettingsForm();

            niTray.Icon = Properties.Resources.NotifyIcon;
            niTray.Text = WinBro.Core.Settings.CoreSettings.Instance.AppName;

            fswRoot.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName;
            fswRoot.Path = WinBro.Core.Settings.FileSearcherSettings.Instance.RootPath;

            _wndProcFuncs = new Dictionary<int, WndProcFunc>
            {
                { (int) WindowsMessages.WM_HOTKEY, _ProcessHotKey }
            };

            HotKey.Register(this, new Keys[] { Keys.Alt, Keys.Control }, Keys.Space, ShowFromTray);
        }
        #endregion
    }
}
