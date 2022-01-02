using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsbSync
{
    public partial class DirectoryCreateName : Form
    {
        public DirectoryCreateName()
        {
            InitializeComponent();
        }

        public void SetFolderName(string name)
        {
            txtFoldername.Text = name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Tag = txtFoldername.Text;
            this.Close();
        }
    }
}
