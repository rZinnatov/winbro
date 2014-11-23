using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBro.WinForms.Core;

namespace WinBro.WinForms.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            cbAutoRun.Checked = WinBro.Core.Settings.CoreSettings.Instance.RunOnWindowsStartup;
        }

        #region Events
        #region Form
        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            Settings.Instance.ChildFormShown = true;

            tbRootPath.Text = WinBro.Core.Settings.FileSearcherSettings.Instance.RootPath;
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Instance.ChildFormShown = false;
        }
        #endregion
        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                WinBro.Core.Settings.CoreSettings.Instance.RunOnWindowsStartup = cbAutoRun.Checked;
                WinBro.Core.Settings.FileSearcherSettings.Instance.RootPath = tbRootPath.Text;

                WinBro.Core.Settings.SettingsManager.Instance.SaveSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnChooseRoot_Click(object sender, EventArgs e)
        {
            if (fbdRoot.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbRootPath.Text = fbdRoot.SelectedPath;
            }
        }
        #endregion 
        #endregion
    }
}
