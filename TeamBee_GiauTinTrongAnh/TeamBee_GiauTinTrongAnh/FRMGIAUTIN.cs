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

namespace TeamBee_GiauTinTrongAnh
{
    public partial class FRMGIAUTIN : Form
    {

        private string inPath1;       //duong dan toi file anh can giau

        private string inPath2="";       // duong dan toi file anh can giai nen
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
                if (inPath1 == "")
                    MessageBox.Show("Bạn chưa chọn ảnh để giấu tin...");
                

                else if (TXTTHONGTIN.Text == "")
                    MessageBox.Show("Bạn chưa thông điệp để giấu tin...");
                else if (TXTMATKHAU.Text == "")
                    MessageBox.Show("Bạn chưa nhập mật khẩu...");
                else
                {
                    // tao ra 1 file chua thong diep an
                    CreateStegoFile(inPath1, TXTTHONGTIN.Text, TXTMATKHAU.Text, outPath);
                    // dua anh nay len pictureBox
                    Bitmap bitmap = new Bitmap(outPath);
                    FitPicture(bitmap, ANHSAU, groupBox2);
                    ANHSAU.Image = bitmap;
                    MessageBox.Show("Giấu Tin Thành Công...");
                }
            }
            else
            {
                outPath = "";
                MessageBox.Show("Bạn chưa chọn nơi để lưu ảnh...");
            }
           
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

        public static void FitPicture(Image image, PictureBox frame, GroupBox box)
        {
            box.Width = image.Width < 512 ? image.Width : 512;
            frame.Width = image.Width < 512 ? image.Width : 512;
            box.Height = image.Height < 512 ? image.Height : 512;
            frame.Height = image.Height < 512 ? image.Height : 512;
        }

        private void FRMGIAUTIN_Load(object sender, EventArgs e)
        {

        }
        public void CreateStegoFile(string inPath1, string message, string password, string inPath2)
        {
           
           
            
                // Mo file dau vao
                FileStream inStream = new FileStream(inPath1, FileMode.Open, FileAccess.Read);

                // kiem tra xem co phai anh bitmap 24 bits khong
                char b = (char)inStream.ReadByte();
                char m = (char)inStream.ReadByte();
                if (!(b == 'B' && m == 'M'))
                    throw new Exception("Khong phai la anh bitmap");
                // kiem tra xem co phai la anh 24 bit hay k
                inStream.Seek(28, 0);    // dua con tro ve vi tri byte thu 28
                byte[] temp = new byte[2];
                inStream.Read(temp, 0, 2);    // so bit/1pixel duoc luu bang 2 byte
                Int16 nBit = BitConverter.ToInt16(temp, 0);       // chuyen mang byte temp[] ve so nguyen 16 bit
                if (nBit != 24)
                    throw new Exception("Day khong phai la anh 24 bit");
                // Doc 54 byte phan header roi dua vao trong outStream
                int offset = 54;
                inStream.Seek(0, 0);
                byte[] header = new byte[offset];
                inStream.Read(header, 0, offset);

                //viet 54 byte nay vao trong file stego ( file dau ra)
                FileStream outStream = new FileStream(inPath2, FileMode.Create, FileAccess.Write);
                outStream.Write(header, 0, offset);

                // ma hoa thong diep va mat khau thanh 1 thong diep duy nhat
                UnicodeEncoding unicode = new UnicodeEncoding();
                byte[] newMessageByte = AddMessLengthToAhead(unicode.GetBytes(message));// them 4 byte do dai cua message vao dau cua thong diep
                                                                                        // thuc hien tron
                newMessageByte = CryptoHelper.Encrypt(newMessageByte, password);

                // thuc hien giau thong diep nay vao trong anh
                inStream.Seek(offset, 0);    // dua con tro ve noi bat dau cua Data o vi tri thu 54 (offset=54)
                LSBHelper.Encode(inStream, newMessageByte, outStream);      //thay tung bit cua thong diep vao LSB cua inStream va ghi ra outStream

                inStream.Close(); // dong file anh dau vao
                outStream.Close();
            
        }
        private byte[] AddMessLengthToAhead(byte[] message)
        {
            int messLen = message.Length;   // do dai cua thong diep
            byte[] byteLen = BitConverter.GetBytes(messLen);    // dua do dai cua thong diep thanh mang cac byte
            // thuc ra do dai cua mang byteLen la 4 (du de bieu dien 1 so nguyen 32bit)
            byte[] newMess = new byte[messLen + byteLen.Length];    // thong diep moi sau khi da them do dai vao dau (la mang cac byte)
            // dua do dai thong diep ve dau
            for (int i = 0; i < byteLen.Length; i++)
                newMess[i] = byteLen[i];
            for (int i = 0; i < messLen; i++)
                newMess[i + byteLen.Length] = message[i];
            return newMess;
        }
    }
}
