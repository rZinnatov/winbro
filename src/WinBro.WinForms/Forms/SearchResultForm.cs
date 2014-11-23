using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBro.FileSearcher.Search;
using WinBro.WinForms.Core;

namespace WinBro.WinForms.Forms
{
    public partial class SearchResultForm : Form
    {
        const int lbResult_margin = 2;
        const int form_padding = lbResult_margin * 2;

        ToolTip tt = new ToolTip();

        SearchResult _result;
        IHideToTrayForm _appHost;

        public SearchResultForm(SearchResult result, IHideToTrayForm appHost)
        {
            InitializeComponent();

            _result = result;
            _appHost = appHost;

            lbResult.DataSource = _result.Directories;
            if (lbResult.Items.Count > 0)
            {
                lbResult.SelectedIndex = 0;
                _ShowToolTip();
            }
        }

        private void lbResult_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    if (lbResult.SelectedItem == null)
                    {
                        return;
                    }

                    var searchEntry = (lbResult.SelectedItem as SearchEntry);
                    if (searchEntry == null)
                    {
                        return;
                    }

                    System.Diagnostics.Process.Start(searchEntry.Path);
                    _appHost.HideToTray();
                    break;
            }
        }

        private void SearchResultForm_Shown(object sender, EventArgs e)
        {
            WinForms.Core.Settings.Instance.ChildFormShown = true;

            this.Height = lbResult.ItemHeight * lbResult.Items.Count;

            lbResult.Left = lbResult.Top = lbResult_margin;
            lbResult.Height = this.Height;
            
            this.Width = lbResult.Width + form_padding;

            this.Top = WinForms.Core.Settings.Instance.SearchResultFormAnchor.Y;
            this.Left = WinForms.Core.Settings.Instance.SearchResultFormAnchor.X;
        }

        private void SearchResultForm_Deactivate(object sender, EventArgs e)
        {
            WinForms.Core.Settings.Instance.ChildFormShown = false;
            this.Close();
        }

        private void lbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ShowToolTip();
        }

        private void _ShowToolTip()
        {
            if (lbResult.SelectedItem == null)
            {
                return;
            }

            tt.IsBalloon = false;
            tt.InitialDelay = 0;
            tt.AutomaticDelay = 0;
            tt.Show((lbResult.SelectedItem as SearchEntry).Path, lbResult);
        }
    }
}
