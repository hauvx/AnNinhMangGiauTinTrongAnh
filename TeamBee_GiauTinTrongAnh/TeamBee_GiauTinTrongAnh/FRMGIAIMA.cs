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
    public partial class FRMGIAIMA : Form
    {
        private string inPath2;       // duong dan toi file anh can giai nen
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

        private void BTNGIAIMA_Click(object sender, EventArgs e)
        {
            string password = TXTMATKHAU.Text;
            // kiem tra xem dau vao co hop le khong? neu khong tao ra cac exception
            if (inPath2 == "")
                MessageBox.Show("Bạn chưa chọn ảnh để giả mã");
            
            else if (password == "")
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            else {
                try
                {
                    // kiem tra xem file dau vao co phai la file Bitmap 24 bit khong?
                    FileStream inStream = new FileStream(inPath2, FileMode.Open, FileAccess.Read);
                    inStream.Seek(0, 0);    // dua con tro ve dau file
                    char b = (char)inStream.ReadByte();
                    char m = (char)inStream.ReadByte();
                    if (!(b == 'B' && m == 'M'))
                        throw new Exception("Day khong phai la file Bitmap");
                    // kiem tra xem co phai anh bitmap 24 bit khong
                    int offset = 28;
                    inStream.Seek(offset, 0);
                    byte[] temp = new byte[2];    // doc vao 2 byte
                    inStream.Read(temp, 0, 2);    // vi tri 28 va 29
                                                  // chuyen temp[] ve so nguyen 16 bit
                    Int16 numOfBit = BitConverter.ToInt16(temp, 0);
                    if (numOfBit != 24)
                        throw new Exception("Khong phai anh 24 bit");
                    // bat dau tham nhap vao phan data
                    offset = 54;
                    inStream.Seek(offset, 0);
                    byte[] bLen = new byte[4];  // 4 byte luu tru do dai thong diep
                    bLen = LSBHelper.Decode(inStream, 4);   // cho nay khong the dung method FileStream.Read duoc,do 4 byte nay thuc chat la 32 byte trong inStream
                                                            //decrypt 4 byte nay de duoc 4 byte thuc su ban dau (do ca 4 byte nay cung duoc ma hoa boi khoa Key[128])
                    bLen = CryptoHelper.Decrypt(bLen, password);
                    int length = BitConverter.ToInt32(bLen, 0); // chuyen tu mang byte thanh so nguyen 

                    // thuc hien doc ra mang thong diep an (van bi Encrypt)
                    inStream.Seek(offset + 4 * 8, 0);       // 32 byte dau tien de luu do dai cua thong diep
                    byte[] buffer = new byte[length];         // su dung mang nay de luu tru tam
                    try
                    {
                        buffer = LSBHelper.Decode(inStream, length);
                    }
                    catch { throw new Exception("Anh nay khong chua thong tin  hoac ban da nhap sai mat khau"); }   // trong qua trinh trich xuat ra thong diep giau ,neu gap 1 ngoai le nao do,coi nhu trich xuat khong thanh cong ( thong thuong ngoai le phat sinh se la khong du bo nho)
                    byte[] realHidenMessage = new byte[4 + buffer.Length];
                    realHidenMessage = ConcatTwoByteArray(bLen, buffer);   // them 4 byte vao dau de tien cho viec Decrypt
                    realHidenMessage = CryptoHelper.Decrypt(realHidenMessage, password);  // bay gio ta da duoc mang thong diep thuc su
                    byte[] hidenMessage = new byte[length]; // bay gio ta chi quan tam den phan thong diep
                    for (int i = 0; i < length; i++)
                        hidenMessage[i] = realHidenMessage[i + 4];
                    // chuyen ve dang string
                    UnicodeEncoding unicode = new UnicodeEncoding();
                    string result = unicode.GetString(hidenMessage);
                    TXTTHONGTIN.Text = result; // hien thi ket qua ra textbox

                    inStream.Close();  // dong file dau vao
                }
                catch
                {
                    MessageBox.Show("Giải Mã Thất Bại");
                }
            }
        }

        private void cHỌNẢNHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Chose an Image To Extract";
            openFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inPath2 = openFileDialog1.FileName;
                Bitmap bitmap = new Bitmap(inPath2);
                FRMGIAUTIN.FitPicture(bitmap, ANHGIAIMA, groupBox3);
                ANHGIAIMA.Image = bitmap;
            }
            else { inPath2 = ""; }
            // load anh len picture box 3
           
        }
        private byte[] ConcatTwoByteArray(byte[] arr1, byte[] arr2)
        {
            byte[] retArr = new byte[arr1.Length + arr2.Length];
            // lay mang thu nhat
            for (int i = 0; i < arr1.Length; i++)
                retArr[i] = arr1[i];
            // noi them mang thu 2
            for (int i = 0; i < arr2.Length; i++)
                retArr[i + arr1.Length] = arr2[i];
            return retArr;
        }
    }
}
