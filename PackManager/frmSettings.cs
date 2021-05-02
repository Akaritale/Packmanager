using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackManager
{
    public partial class frmSettings : Form
    {
        Properties.Settings Settings;

        public frmSettings()
        {
            InitializeComponent();

            this.Settings = Properties.Settings.Default;
          
            this.txtPackDirectory.Text = Settings.PackDirectory;
            this.txtClientDirectory.Text = Settings.ClientDirectory;
            this.checkCythonize.Checked = Settings.AutoCythonize;
            this.checkAutoMove.Checked = Settings.AutoMove;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.PackDirectory = txtPackDirectory.Text;
            Settings.ClientDirectory = txtClientDirectory.Text;
            Settings.AutoCythonize = checkCythonize.Checked;
            Settings.AutoMove = checkAutoMove.Checked;

            Settings.Save();

            this.Close();
        }

        private void txtPackDirectory_DoubleClick(object sender, EventArgs e)
        {
            var dialogResult = packfolderBrowseDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                txtPackDirectory.Text = packfolderBrowseDialog.SelectedPath;
            }
        }

        private void txtClientDirectory_DoubleClick(object sender, EventArgs e)
        {
            var dialogResult = clientBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtClientDirectory.Text = clientBrowserDialog.SelectedPath;
            }
        }
    }
}
