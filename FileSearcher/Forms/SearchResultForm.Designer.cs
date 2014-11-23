namespace FileSearcher.Forms
{
    partial class SearchResultForm
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
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbResult.DisplayMember = "Name";
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.FormattingEnabled = true;
            this.lbResult.IntegralHeight = false;
            this.lbResult.ItemHeight = 24;
            this.lbResult.Location = new System.Drawing.Point(12, 12);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(160, 52);
            this.lbResult.TabIndex = 0;
            this.lbResult.ValueMember = "Name";
            this.lbResult.SelectedIndexChanged += new System.EventHandler(this.lbResult_SelectedIndexChanged);
            this.lbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbResult_KeyDown);
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.lbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchResultForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SearchResultForm";
            this.Deactivate += new System.EventHandler(this.SearchResultForm_Deactivate);
            this.Shown += new System.EventHandler(this.SearchResultForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbResult;
    }
}