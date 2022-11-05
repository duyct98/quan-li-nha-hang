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

namespace CUAHANG
{
    public partial class MenuThemItemFOOD : Form
    {
        public MenuThemItemFOOD()
        {
            InitializeComponent();
        }
        CUAHANG f1 = new CUAHANG();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }

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
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTenFood.Text.Trim() != "" && IsNumber(txtGiaFood.Text) == true && comboBox1.Text.Trim() != "")
            {
                f1.sqlcode("INSERT INTO tbl_hangban(loai,TenHang,DonGia,Anh) values ('" + comboBox1.Text + "','" + txtTenFood.Text + "','" + txtGiaFood.Text + "'," + ToVarbinary(imageToByteArray(pictureBox1.BackgroundImage)) + ")");
                MessageBox.Show("OK , Thêm món thành công");
                Application.Exit();
            }
            else MessageBox.Show("Thông tin nhập chưa chính xác");


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MenuThemItemFOOD_Load(object sender, EventArgs e)
        {

        }
    }
}
