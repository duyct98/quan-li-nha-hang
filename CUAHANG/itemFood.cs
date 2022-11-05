using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CUAHANG
{
    public partial class itemFood : UserControl
    {
        public static int dem = 0;
        public static List<itemFood> listThucUong = new List<itemFood>();
        public static List<itemFood> listRuouBia = new List<itemFood>();
        public static List<itemFood> listAnVat = new List<itemFood>();
        public static List<itemFood> listAnChinh = new List<itemFood>();
        public itemFood()
        {
            InitializeComponent();
        }
        public event EventHandler BtnSuaGia_Click;
        private void btnSuaGia_Click(object sender, EventArgs e)
        {
            txtGia.Enabled = true;


            
            



            if (BtnSuaGia_Click != null) 
            BtnSuaGia_Click.Invoke(this, e);
        }
        public event EventHandler BtnSuaAnh_Click;
        private void btnSuaAnh_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
            
            if (BtnSuaAnh_Click != null) 
            BtnSuaAnh_Click.Invoke(this, e);

        }
        public event EventHandler BtnSuaTen_Click;
        private void btnSuaTen_Click(object sender, EventArgs e)
        {
            if (BtnSuaTen_Click != null) 
            BtnSuaTen_Click.Invoke(this, e);
        }
        CUAHANG f1 = new CUAHANG();
        public int idFood{get;set;}
        public string tenFood { get; set; }
        public double giaFood { get; set; }

        public void getDataFood(string data)
        {
            while (true)
            {
                dem++;
                idFood = Convert.ToInt32(f1.Laydatasql("select hangid from tbl_hangban where loai='" + data + "' and hangid=" + dem + ""));
                if (idFood != 0)
                {
                    tenFood = f1.Laydatasql("select tenhang from tbl_hangban where loai='" + data + "' and hangid=" + idFood + "");
                    giaFood = Convert.ToDouble(f1.Laydatasql("select dongia from tbl_hangban where loai='" + data + "'and hangid=" + idFood + ""));
                    txtGia.Text = giaFood.ToString();
                    txtTenMon.Text = tenFood;
                    string ss = "SELECT anh from tbl_hangban where HangID = " + idFood + "and loai='" + data + "'";

                    SqlConnection conn = new SqlConnection(f1.strcon);
                    conn.Open();
                    SqlCommand command = new SqlCommand(ss, conn);

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);

                        MemoryStream ms = new MemoryStream(img);

                        pictureBox1.BackgroundImage = Image.FromStream(ms);

                    }

                    break;


                }



            }
        }

        private void btnSuaItemFood_Click(object sender, EventArgs e)
        {
            txtTenMon.Enabled = true;
            txtGia.Enabled = true;
            btnHuyThayDoi.Show();
            btnSave.Show();
            btnSuaAnh.Show();
            btnSuaItemFood.Hide();
        }

        private void itemFood_Load(object sender, EventArgs e)
        {
            btnSuaItemFood.Show();
            btnHuyThayDoi.Hide();
            btnSave.Hide();
            btnSuaAnh.Hide();
        }

        private void btnHuyThayDoi_Click(object sender, EventArgs e)
        {
            btnSuaItemFood.Show();
            btnHuyThayDoi.Hide();
            btnSave.Hide();
            btnSuaAnh.Hide();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            f1.sqlcode("UPDATE tbl_hangban set tenhang = N'" + txtTenMon.Text + "', dongia = N'" + txtGia.Text + "',anh = " + ToVarbinary(imageToByteArray(pictureBox1.BackgroundImage))+" WHERE  hangid = '" + idFood + "'");
            btnSuaItemFood.Show();
            btnHuyThayDoi.Hide();
            btnSave.Hide();
            btnSuaAnh.Hide();
            txtGia.Enabled = false;
            txtTenMon.Enabled = false;

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

        public event EventHandler BtnXoa_Click;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            f1.sqlcode("delete tbl_hangban where hangid = '"+idFood+"'");

            if (BtnXoa_Click != null)
            BtnXoa_Click.Invoke(this, e);
        }
    }
}
