using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            PackMaker.Pack(archive, new PackMakerSettings { Action = Core.Action.Pack });
        }

        private void unpackAction()
        {
            var archive = listBox.SelectedItem.ToString();
            PackMaker.Pack(archive, new PackMakerSettings { Action = Core.Action.Unpack });
        }
    }
}
