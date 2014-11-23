using FileSearcher.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcher.Forms
{
    public partial class SettingsForm : Form
    {
        private ToolTip ttRootPath;

        public SettingsForm()
        {
            InitializeComponent();

            ttRootPath = new ToolTip();
            ttRootPath.IsBalloon = true;
            ttRootPath.InitialDelay = 0;
            ttRootPath.AutomaticDelay = 0;
            ttRootPath.SetToolTip(tbRootPath, "use Ctrl+V");

            cbAutoRun.Checked = Config.Instance.AutoRun.RunOnStartup;
        }

        #region Form

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            Config.Instance.System.ChildFormShown = true;

            tbRootPath.Text = Config.Instance.System.RootPath;

            Config.StartChangeSession();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Instance.System.ChildFormShown = false;
            Config.CancelChangeSession();
        }

        #endregion

        #region Manage Buttons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Config.CancelChangeSession();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Util.AutoRunRegistryKey autoRunRegKey = new Util.AutoRunRegistryKey();
            if (cbAutoRun.Checked)
            {
                autoRunRegKey.RunOnStartup = true;
            }

            try
            {
                Config.ApplyChangeSession(autoRunRegKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Config.Instance.Save();
            this.Close();
        }

        #endregion

        #region Root Path

        private void tbRootPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Config.Instance.System.RootPath = tbRootPath.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

                tbRootPath.Text = String.Empty;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show(String.Format(
                    "directory {0} does not exist",
                    tbRootPath.Text));

                tbRootPath.Text = String.Empty;
            }
        }

        private void tbRootPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
            {
                tbRootPath.Text = Clipboard.GetText();
            }
        }

        private void btnChooseRoot_Click(object sender, EventArgs e)
        {
            if (fbdRoot.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbRootPath.Text = fbdRoot.SelectedPath;
            }
        }

        #endregion
    }
}
