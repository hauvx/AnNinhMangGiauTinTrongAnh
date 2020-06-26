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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void BTNGIAUTIN_Click(object sender, EventArgs e)
        {
            FRMGIAUTIN fRMGIAUTIN = new FRMGIAUTIN();
            fRMGIAUTIN.Show();
            this.Hide();
        }

        private void BTNGIAIMA_Click(object sender, EventArgs e)
        {
            FRMGIAIMA fRMGIAIMA = new FRMGIAIMA();
            fRMGIAIMA.Show();
            this.Hide();
        }
    }
}
