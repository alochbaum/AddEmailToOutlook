namespace AddEmailToOutlook
{
    partial class MainForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbSourceDir = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbDetailedLogging = new System.Windows.Forms.CheckBox();
            this.btnImportMail = new System.Windows.Forms.Button();
            this.btnExportUnread = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(565, 227);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tbSourceDir
            // 
            this.tbSourceDir.Location = new System.Drawing.Point(6, 19);
            this.tbSourceDir.Name = "tbSourceDir";
            this.tbSourceDir.Size = new System.Drawing.Size(487, 20);
            this.tbSourceDir.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnSelect);
            this.GroupBox1.Controls.Add(this.tbSourceDir);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(565, 51);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Source Directory";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(499, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(53, 30);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbDetailedLogging
            // 
            this.cbDetailedLogging.AutoSize = true;
            this.cbDetailedLogging.Checked = true;
            this.cbDetailedLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDetailedLogging.Location = new System.Drawing.Point(458, 78);
            this.cbDetailedLogging.Name = "cbDetailedLogging";
            this.cbDetailedLogging.Size = new System.Drawing.Size(106, 17);
            this.cbDetailedLogging.TabIndex = 3;
            this.cbDetailedLogging.Text = "Detailed Logging";
            this.cbDetailedLogging.UseVisualStyleBackColor = true;
            // 
            // btnImportMail
            // 
            this.btnImportMail.Location = new System.Drawing.Point(18, 69);
            this.btnImportMail.Name = "btnImportMail";
            this.btnImportMail.Size = new System.Drawing.Size(75, 23);
            this.btnImportMail.TabIndex = 4;
            this.btnImportMail.Text = "Inport Mail";
            this.btnImportMail.UseVisualStyleBackColor = true;
            this.btnImportMail.Click += new System.EventHandler(this.btnImportMail_Click);
            // 
            // btnExportUnread
            // 
            this.btnExportUnread.Location = new System.Drawing.Point(100, 68);
            this.btnExportUnread.Name = "btnExportUnread";
            this.btnExportUnread.Size = new System.Drawing.Size(150, 23);
            this.btnExportUnread.TabIndex = 5;
            this.btnExportUnread.Text = "Export Unread In Inbox";
            this.btnExportUnread.UseVisualStyleBackColor = true;
            this.btnExportUnread.Click += new System.EventHandler(this.btnExportUnread_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 340);
            this.Controls.Add(this.btnExportUnread);
            this.Controls.Add(this.btnImportMail);
            this.Controls.Add(this.cbDetailedLogging);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.Text = "Add Email To Outlook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbSourceDir;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox cbDetailedLogging;
        private System.Windows.Forms.Button btnImportMail;
        private System.Windows.Forms.Button btnExportUnread;
    }
}

