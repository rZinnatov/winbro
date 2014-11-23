namespace FileSearcher.Forms
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblAutoRun = new System.Windows.Forms.Label();
            this.flpAutoRun = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRootPath
            // 
            this.tbRootPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRootPath.Location = new System.Drawing.Point(63, 8);
            this.tbRootPath.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbRootPath.Name = "tbRootPath";
            this.tbRootPath.ReadOnly = true;
            this.tbRootPath.Size = new System.Drawing.Size(258, 20);
            this.tbRootPath.TabIndex = 0;
            this.tbRootPath.TextChanged += new System.EventHandler(this.tbRootPath_TextChanged);
            this.tbRootPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRootPath_KeyUp);
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
            this.btnChooseRoot.Location = new System.Drawing.Point(327, 3);
            this.btnChooseRoot.Name = "btnChooseRoot";
            this.btnChooseRoot.Size = new System.Drawing.Size(76, 31);
            this.btnChooseRoot.TabIndex = 2;
            this.btnChooseRoot.Text = "Choose root";
            this.btnChooseRoot.UseVisualStyleBackColor = true;
            this.btnChooseRoot.Click += new System.EventHandler(this.btnChooseRoot_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.btnChooseRoot, 2, 0);
            this.tlpMain.Controls.Add(this.lblRootPath, 0, 0);
            this.tlpMain.Controls.Add(this.tbRootPath, 1, 0);
            this.tlpMain.Controls.Add(this.lblAutoRun, 0, 1);
            this.tlpMain.Controls.Add(this.flpAutoRun, 2, 1);
            this.tlpMain.Controls.Add(this.cbAutoRun, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(406, 181);
            this.tlpMain.TabIndex = 3;
            // 
            // lblAutoRun
            // 
            this.lblAutoRun.AutoSize = true;
            this.lblAutoRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutoRun.Location = new System.Drawing.Point(3, 37);
            this.lblAutoRun.Name = "lblAutoRun";
            this.lblAutoRun.Size = new System.Drawing.Size(54, 23);
            this.lblAutoRun.TabIndex = 5;
            this.lblAutoRun.Text = "Autorun";
            this.lblAutoRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpAutoRun
            // 
            this.flpAutoRun.AutoSize = true;
            this.flpAutoRun.BackColor = System.Drawing.SystemColors.Control;
            this.flpAutoRun.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAutoRun.Location = new System.Drawing.Point(327, 40);
            this.flpAutoRun.Name = "flpAutoRun";
            this.flpAutoRun.Size = new System.Drawing.Size(0, 0);
            this.flpAutoRun.TabIndex = 4;
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Location = new System.Drawing.Point(63, 40);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(143, 17);
            this.cbAutoRun.TabIndex = 0;
            this.cbAutoRun.Text = "Run on Windows startup";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tlpMain, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 230);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 37);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(317, 3);
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
            this.btnSave.Location = new System.Drawing.Point(225, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(412, 230);
            this.Controls.Add(this.tableLayoutPanel2);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdRoot;
        private System.Windows.Forms.TextBox tbRootPath;
        private System.Windows.Forms.Label lblRootPath;
        private System.Windows.Forms.Button btnChooseRoot;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.FlowLayoutPanel flpAutoRun;
        private System.Windows.Forms.Label lblAutoRun;
    }
}