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

namespace APP_KHACH_CHUAN
{
    public partial class MENUThemItem : Form
    {
        public MENUThemItem()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void MENUThemItem_Load(object sender, EventArgs e)
        {

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        string ToVarbinary(byte[] data)
        {
            var sb = new StringBuilder((data.Length * 2) + 2);
            sb.Append("0x");

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }

            return sb.ToString();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static event EventHandler Button2_Click;
        public void button2_Click(object sender, EventArgs e)
        {
            if (txtTenFood.Text.Trim() != "" && IsNumber(txtGiaFood.Text) == true && comboBox1.Text.Trim() != "")
            {
                f1.sqlcode("INSERT INTO tbl_hangban(loai,TenHang,DonGia,Anh) values (N'" + comboBox1.Text + "',N'" + txtTenFood.Text + "','" + txtGiaFood.Text + "'," + ToVarbinary(imageToByteArray(pictureBox1.BackgroundImage)) + ")");
                MessageBox.Show("OK , Thêm món thành công");
                this.Close();
            }
            else MessageBox.Show("Thông tin nhập chưa chính xác");

            if(Button2_Click != null)
                Button2_Click (this, e);
        }
        public void BtnBack_Click()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
