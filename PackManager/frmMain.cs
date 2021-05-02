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
using PackManager.Core;

namespace PackManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDirectoryList();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void packContextMenu_Click(object sender, EventArgs e)
        {
            packAction();
        }

        private void unpackContextMenu_Click(object sender, EventArgs e)
        {
            unpackAction();
        }

        private void PackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            packAction();
        }

        private void UnpackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unpackAction();
        }

        private void packAction()
        {
            var archive = listBox.SelectedItem.ToString();
            PackMaker.Pack(new PackMakerSettings { File = archive });
        }

        private void unpackAction()
        {
            var archive = listBox.SelectedItem.ToString();
            PackMaker.Unpack(new PackMakerSettings { File = archive });
        }
        
        private void LoadDirectoryList()
        {
            if (!listBox.Enabled)
                return;

            listBox.Enabled = false;
            listBox.Items.Clear();
            var path = Properties.Settings.Default.PackDirectory + "\\";
            var directories = Archives.ReadFromDirectory();
            foreach (string directory in directories)
            {
                var cleaned = directory.Replace(path, "");
                if (!cleaned.StartsWith('.'))
                    listBox.Items.Add(cleaned);
            }

            listBox.Enabled = true;
        }
    }
}
