using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddEmailToOutlook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tbSourceDir.Text = AddEmailToOutlook.Properties.Settings.Default.strSourceDir;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                 tbSourceDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddEmailToOutlook.Properties.Settings.Default.strSourceDir = tbSourceDir.Text;
            AddEmailToOutlook.Properties.Settings.Default.Save();
        }

        private void btnImportMail_Click(object sender, EventArgs e)
        {

        }

        private void btnExportUnread_Click(object sender, EventArgs e)
        {
            
        }
    }
}
