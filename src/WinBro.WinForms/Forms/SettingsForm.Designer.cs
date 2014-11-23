namespace WinBro.WinForms.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbdRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.tbRootPath = new System.Windows.Forms.TextBox();
            this.lblRootPath = new System.Windows.Forms.Label();
            this.btnChooseRoot = new System.Windows.Forms.Button();
            this.lblAutoRun = new System.Windows.Forms.Label();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flpManageButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpSystemSettings = new System.Windows.Forms.TabPage();
            this.tlpSystemSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tpFileSearchSettings = new System.Windows.Forms.TabPage();
            this.tlpFileSearchSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.flpManageButtons.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpSystemSettings.SuspendLayout();
            this.tlpSystemSettings.SuspendLayout();
            this.tpFileSearchSettings.SuspendLayout();
            this.tlpFileSearchSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRootPath
            // 
            this.tbRootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRootPath.Location = new System.Drawing.Point(63, 8);
            this.tbRootPath.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbRootPath.Name = "tbRootPath";
            this.tbRootPath.Size = new System.Drawing.Size(407, 20);
            this.tbRootPath.TabIndex = 0;
            // 
            // lblRootPath
            // 
            this.lblRootPath.AutoSize = true;
            this.lblRootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRootPath.Location = new System.Drawing.Point(3, 0);
            this.lblRootPath.Name = "lblRootPath";
            this.lblRootPath.Size = new System.Drawing.Size(54, 37);
            this.lblRootPath.TabIndex = 1;
            this.lblRootPath.Text = "Root path";
            this.lblRootPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChooseRoot
            // 
            this.btnChooseRoot.Location = new System.Drawing.Point(476, 3);
            this.btnChooseRoot.Name = "btnChooseRoot";
            this.btnChooseRoot.Size = new System.Drawing.Size(76, 31);
            this.btnChooseRoot.TabIndex = 2;
            this.btnChooseRoot.Text = "Choose root";
            this.btnChooseRoot.UseVisualStyleBackColor = true;
            this.btnChooseRoot.Click += new System.EventHandler(this.btnChooseRoot_Click);
            // 
            // lblAutoRun
            // 
            this.lblAutoRun.AutoSize = true;
            this.lblAutoRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutoRun.Location = new System.Drawing.Point(3, 0);
            this.lblAutoRun.Name = "lblAutoRun";
            this.lblAutoRun.Size = new System.Drawing.Size(44, 23);
            this.lblAutoRun.TabIndex = 5;
            this.lblAutoRun.Text = "Autorun";
            this.lblAutoRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Location = new System.Drawing.Point(53, 3);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(143, 17);
            this.cbAutoRun.TabIndex = 0;
            this.cbAutoRun.Text = "Run on Windows startup";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.flpManageButtons, 0, 1);
            this.tlpMain.Controls.Add(this.tcSettings, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(575, 375);
            this.tlpMain.TabIndex = 4;
            // 
            // flpManageButtons
            // 
            this.flpManageButtons.AutoSize = true;
            this.flpManageButtons.Controls.Add(this.btnCancel);
            this.flpManageButtons.Controls.Add(this.btnSave);
            this.flpManageButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpManageButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpManageButtons.Location = new System.Drawing.Point(3, 335);
            this.flpManageButtons.Name = "flpManageButtons";
            this.flpManageButtons.Size = new System.Drawing.Size(569, 37);
            this.flpManageButtons.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(480, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(388, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpSystemSettings);
            this.tcSettings.Controls.Add(this.tpFileSearchSettings);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(3, 3);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(569, 326);
            this.tcSettings.TabIndex = 5;
            // 
            // tpSystemSettings
            // 
            this.tpSystemSettings.Controls.Add(this.tlpSystemSettings);
            this.tpSystemSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSystemSettings.Name = "tpSystemSettings";
            this.tpSystemSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSystemSettings.Size = new System.Drawing.Size(561, 300);
            this.tpSystemSettings.TabIndex = 0;
            this.tpSystemSettings.Text = "System";
            this.tpSystemSettings.UseVisualStyleBackColor = true;
            // 
            // tlpSystemSettings
            // 
            this.tlpSystemSettings.ColumnCount = 3;
            this.tlpSystemSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSystemSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSystemSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSystemSettings.Controls.Add(this.lblAutoRun, 0, 0);
            this.tlpSystemSettings.Controls.Add(this.cbAutoRun, 1, 0);
            this.tlpSystemSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSystemSettings.Location = new System.Drawing.Point(3, 3);
            this.tlpSystemSettings.Name = "tlpSystemSettings";
            this.tlpSystemSettings.RowCount = 2;
            this.tlpSystemSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSystemSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSystemSettings.Size = new System.Drawing.Size(555, 294);
            this.tlpSystemSettings.TabIndex = 1;
            // 
            // tpFileSearchSettings
            // 
            this.tpFileSearchSettings.Controls.Add(this.tlpFileSearchSettings);
            this.tpFileSearchSettings.Location = new System.Drawing.Point(4, 22);
            this.tpFileSearchSettings.Name = "tpFileSearchSettings";
            this.tpFileSearchSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpFileSearchSettings.Size = new System.Drawing.Size(561, 300);
            this.tpFileSearchSettings.TabIndex = 1;
            this.tpFileSearchSettings.Text = "File search";
            this.tpFileSearchSettings.UseVisualStyleBackColor = true;
            // 
            // tlpFileSearchSettings
            // 
            this.tlpFileSearchSettings.ColumnCount = 3;
            this.tlpFileSearchSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFileSearchSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFileSearchSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFileSearchSettings.Controls.Add(this.lblRootPath, 0, 0);
            this.tlpFileSearchSettings.Controls.Add(this.tbRootPath, 1, 0);
            this.tlpFileSearchSettings.Controls.Add(this.btnChooseRoot, 2, 0);
            this.tlpFileSearchSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFileSearchSettings.Location = new System.Drawing.Point(3, 3);
            this.tlpFileSearchSettings.Name = "tlpFileSearchSettings";
            this.tlpFileSearchSettings.RowCount = 2;
            this.tlpFileSearchSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFileSearchSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFileSearchSettings.Size = new System.Drawing.Size(555, 294);
            this.tlpFileSearchSettings.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(575, 375);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(419, 210);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.flpManageButtons.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpSystemSettings.ResumeLayout(false);
            this.tlpSystemSettings.ResumeLayout(false);
            this.tlpSystemSettings.PerformLayout();
            this.tpFileSearchSettings.ResumeLayout(false);
            this.tlpFileSearchSettings.ResumeLayout(false);
            this.tlpFileSearchSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdRoot;
        private System.Windows.Forms.TextBox tbRootPath;
        private System.Windows.Forms.Label lblRootPath;
        private System.Windows.Forms.Button btnChooseRoot;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpManageButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.Label lblAutoRun;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpSystemSettings;
        private System.Windows.Forms.TableLayoutPanel tlpSystemSettings;
        private System.Windows.Forms.TabPage tpFileSearchSettings;
        private System.Windows.Forms.TableLayoutPanel tlpFileSearchSettings;
    }
}