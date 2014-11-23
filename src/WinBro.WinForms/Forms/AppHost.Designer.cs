namespace WinBro.WinForms.Forms
{
    partial class AppHost
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.flpManageButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cmTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.fswRoot = new System.IO.FileSystemWatcher();
            this.tlpMain.SuspendLayout();
            this.flpManageButtons.SuspendLayout();
            this.cmTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.rtbSearch, 0, 0);
            this.tlpMain.Controls.Add(this.flpManageButtons, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(955, 60);
            this.tlpMain.TabIndex = 0;
            // 
            // rtbSearch
            // 
            this.rtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSearch.Location = new System.Drawing.Point(3, 3);
            this.rtbSearch.Multiline = false;
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(921, 54);
            this.rtbSearch.TabIndex = 0;
            this.rtbSearch.Text = "";
            this.rtbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbSearch_KeyDown);
            // 
            // flpManageButtons
            // 
            this.flpManageButtons.Controls.Add(this.btnHide);
            this.flpManageButtons.Controls.Add(this.btnSettings);
            this.flpManageButtons.Location = new System.Drawing.Point(930, 3);
            this.flpManageButtons.Name = "flpManageButtons";
            this.flpManageButtons.Size = new System.Drawing.Size(22, 54);
            this.flpManageButtons.TabIndex = 1;
            // 
            // btnHide
            // 
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(3, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(22, 22);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "_";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(3, 31);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(22, 22);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "O";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cmTray
            // 
            this.cmTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiOpen,
            this.cmiSettings,
            this.toolStripSeparator1,
            this.cmiAbout,
            this.cmiExit});
            this.cmTray.Name = "cmTray";
            this.cmTray.Size = new System.Drawing.Size(117, 98);
            // 
            // cmiOpen
            // 
            this.cmiOpen.Name = "cmiOpen";
            this.cmiOpen.ShortcutKeyDisplayString = "";
            this.cmiOpen.ShowShortcutKeys = false;
            this.cmiOpen.Size = new System.Drawing.Size(116, 22);
            this.cmiOpen.Text = "Open";
            this.cmiOpen.ToolTipText = "Ctrl+Alt+Space";
            this.cmiOpen.Click += new System.EventHandler(this.cmiOpen_Click);
            // 
            // cmiSettings
            // 
            this.cmiSettings.Name = "cmiSettings";
            this.cmiSettings.Size = new System.Drawing.Size(116, 22);
            this.cmiSettings.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // cmiAbout
            // 
            this.cmiAbout.Name = "cmiAbout";
            this.cmiAbout.Size = new System.Drawing.Size(116, 22);
            this.cmiAbout.Text = "About";
            // 
            // cmiExit
            // 
            this.cmiExit.Name = "cmiExit";
            this.cmiExit.Size = new System.Drawing.Size(116, 22);
            this.cmiExit.Text = "Exit";
            this.cmiExit.Click += new System.EventHandler(this.cmiExit_Click);
            // 
            // niTray
            // 
            this.niTray.ContextMenuStrip = this.cmTray;
            this.niTray.Text = "File Searcher";
            this.niTray.Visible = true;
            this.niTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTray_MouseDoubleClick);
            // 
            // fswRoot
            // 
            this.fswRoot.EnableRaisingEvents = true;
            this.fswRoot.IncludeSubdirectories = true;
            this.fswRoot.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)));
            this.fswRoot.SynchronizingObject = this;
            this.fswRoot.Changed += new System.IO.FileSystemEventHandler(this.fswRoot_Changed);
            // 
            // AppHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnHide;
            this.ClientSize = new System.Drawing.Size(955, 60);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppHost";
            this.Deactivate += new System.EventHandler(this.AppHost_Deactivate);
            this.Shown += new System.EventHandler(this.AppHost_Shown);
            this.tlpMain.ResumeLayout(false);
            this.flpManageButtons.ResumeLayout(false);
            this.cmTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fswRoot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.Windows.Forms.ContextMenuStrip cmTray;
        private System.Windows.Forms.ToolStripMenuItem cmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmiExit;
        private System.Windows.Forms.ToolStripMenuItem cmiAbout;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.ToolStripMenuItem cmiSettings;
        private System.Windows.Forms.FlowLayoutPanel flpManageButtons;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnSettings;
        private System.IO.FileSystemWatcher fswRoot;
    }
}