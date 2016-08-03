using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void btnExitParam_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOkParam_Click(object sender, EventArgs e)
        {
            Victoryna.WriteParam();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.mp3", chbxFolders.Checked ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musicList);
                Victoryna.list.Clear();
                Victoryna.list.AddRange(musicList);
            }
        }

        private void fParam_Load(object sender, EventArgs e)
        {

        }
    }
}
