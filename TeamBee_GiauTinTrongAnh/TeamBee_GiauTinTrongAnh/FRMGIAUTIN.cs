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
    public partial class FRMGIAUTIN : Form
    {

        private string inPath1;       //duong dan toi file anh can giau

        private string inPath2;       // duong dan toi file anh can giai nen
        public FRMGIAUTIN()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FRMGIAUTIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }

        private void BTNGIAUTIN_Click(object sender, EventArgs e)
        {
            // mo hop thoai de chon noi luu file stegano
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Title = "Chọn Chỗ Lưu Ảnh";
            saveDialog1.Filter = "Bitmap (*.bmp)|*.bmp";

            string outPath;
            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                outPath = saveDialog1.FileName;
            }
            else
            {
                outPath = "";
            }
            // tao ra 1 file chua thong diep an
           // CreateStegoFile(inPath1, textBox1.Text, textBox2.Text, outPath);
            // dua anh nay len pictureBox
            Bitmap bitmap = new Bitmap(outPath);
            FitPicture(bitmap, ANHSAU, groupBox2);
            ANHSAU.Image = bitmap;
            saveDialog1.Dispose();
        }

        private void cHỌNẢNHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Chose an Bitmap Image To Hiding";
            openFileDialog1.Filter = "Bitmap Image(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inPath1 = openFileDialog1.FileName; // lay ra duong dan cua file vua mo
            }
            else
            {
                inPath1 = "";
            }
            Bitmap oldBitmap = new Bitmap(inPath1);
            FitPicture(oldBitmap, ANHTRUOC, groupBox1);
            ANHTRUOC.Image = oldBitmap;
        }

        private void FitPicture(Image image, PictureBox frame, GroupBox box)
        {
            box.Width = image.Width < 512 ? image.Width : 512;
            frame.Width = image.Width < 512 ? image.Width : 512;
            box.Height = image.Height < 512 ? image.Height : 512;
            frame.Height = image.Height < 512 ? image.Height : 512;
        }

        private void FRMGIAUTIN_Load(object sender, EventArgs e)
        {

        }
    }
}
