using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBee_GiauTinTrongAnh
{
    public partial class FRMGIAIMA : Form
    {
        public FRMGIAIMA()
        {
            InitializeComponent();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }

        private void FRMGIAIMA_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
