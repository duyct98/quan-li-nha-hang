using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APP_KHACH_CHUAN
{
    public partial class itemFood : UserControl
    {

        public int idFood = 0;
        public string tenFood = null;
        public Double giaFood=0;
        public static int getCount;
        public static int dem = 1;
        Form1 f1 = new Form1();
        public itemFood()
        {

            InitializeComponent();
        }
        public static List<itemFood> listfood = new List<itemFood>();
        public static List<itemFood> listThucUong = new List<itemFood>();
        public static List<itemFood> listRuouBia = new List<itemFood>();
        public static List<itemFood> listAnVat = new List<itemFood>();
        public static List<itemFood> listAnChinh = new List<itemFood>();

        public event EventHandler BtnThem_Click;
        public event EventHandler BtnHuy_Click;
        
        public static Image Pic = null;


        public static Image anh(Image data)
        {
            Pic = data;
            return data;
        }




        

        public int count { get; set; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            getCount = count;
            if (BtnThem_Click!=null)
                BtnThem_Click.Invoke(this, e);
            
            
        }
       
        
        private void sqlcode(string data) // select * fromm ....
        {
            SqlConnection conn = new SqlConnection(f1.strcon);
            conn.Open();
            SqlCommand updateCmd = new SqlCommand(data, conn);
            updateCmd.CommandType = CommandType.Text;
            updateCmd.ExecuteNonQuery();
            conn.Close();
        }
      
        public void setTenFood(string data)
        {
            txtTenFood.Text = data;
        }
        public string getTenFood()
        {
            return txtTenFood.Text;
        }
        public void setIDFood(int data)
        {
            idFood = data;
        }
        public int getIDFood()
        {
            return idFood;
        }
        public void SetGiaFood(string data)
        {
            txtGiaFood.Text = data;
        }
        public double getGiaFood()
        {
            return Convert.ToDouble(txtGiaFood.Text);
        }
       
        public void dataFood()
        {
            while (true)
            {

                
                    


                    idFood = Convert.ToInt32(f1.Laydatasql("select HangID from tbl_hangban where HangID='" + dem + "' and cuahangid= '"+ f1.getIDShop() + "'" ));
                    txtTenFood.Text = f1.Laydatasql("select TenHang from tbl_hangban where hangid='" + dem + "'and cuahangid= '" + f1.getIDShop() + " '");
                    tenFood = txtTenFood.Text;
                    giaFood = Convert.ToDouble(f1.Laydatasql("select DonGia from tbl_hangban where hangid='" + dem + "'and cuahangid= '"+ f1.getIDShop() + "'"));
                    txtGiaFood.Text = Convert.ToInt32(giaFood).ToString("0,000") + " VND";
               
               

                dem++;





                if (tenFood != ""&& tenFood != null)
                {
                    string ss = "SELECT anh from tbl_hangban where HangID = '" + idFood + "'and cuahangid= '"+ f1.getIDShop() + " '";

                    SqlConnection conn = new SqlConnection(f1.strcon);
                    conn.Open();
                    SqlCommand command = new SqlCommand(ss, conn);

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);

                        MemoryStream ms = new MemoryStream(img);

                        picturebox1.BackgroundImage = Image.FromStream(ms);

                    }

                    break;
                }
                



            }
            
        }
        public void getDataFood(string data) // 
        {
            
            
            while (true)
                {
                dem++;
                idFood = Convert.ToInt32(f1.Laydatasql("select hangid from tbl_hangban where loai='" + data + "' and hangid=" + dem + ""));
                if (idFood != 0)
                    {
                        tenFood = f1.Laydatasql("select tenhang from tbl_hangban where loai='"+data+"' and hangid="+idFood+"");
                        giaFood = Convert.ToDouble(f1.Laydatasql("select dongia from tbl_hangban where loai='"+data+ "'and hangid=" + idFood+""));
                        txtGiaFood.Text = giaFood.ToString("0,000");
                        txtTenFood.Text = tenFood;
                        string ss = "SELECT anh from tbl_hangban where HangID = " + idFood + "and loai='"+data+"'";

                        SqlConnection conn = new SqlConnection(f1.strcon);
                        conn.Open();
                        SqlCommand command = new SqlCommand(ss, conn);

                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);

                        MemoryStream ms = new MemoryStream(img);

                        picturebox1.BackgroundImage = Image.FromStream(ms);

                    }
                    
                    break;
                        
                        
                    }
                
                
                
                }
            
            
        }

        public void getDataFoodTheoID(int hangID,int donhangid) // 
        {


            while (true)
            {
                dem++;
                
                {
                    tenFood = f1.Laydatasql("select tenhang from view_Hoadon2 where hangid=" + hangID + " and donhangid = "+donhangid+"");
                    giaFood = Convert.ToDouble(f1.Laydatasql("select dongia from view_Hoadon2  where hangid=" + hangID + " and donhangid =" + donhangid + ""));
                    txtGiaFood.Text = giaFood.ToString();
                    txtTenFood.Text = tenFood;
                    string ss = "SELECT anh from view_Hoadon2 where hangid=" + hangID + " and donhangid= " + donhangid + "";

                    SqlConnection conn = new SqlConnection(f1.strcon);
                    conn.Open();
                    SqlCommand command = new SqlCommand(ss, conn);

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);

                        MemoryStream ms = new MemoryStream(img);

                        picturebox1.BackgroundImage = Image.FromStream(ms);

                    }

                    break;


                }



            }


        }


        public void doiMauItemFood(int data1, int data2, int data3)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(data1)))), ((int)(((byte)(data2)))), ((int)(((byte)(data3)))));

        }


        public void Button2_Click_2(object sender, EventArgs e)
        {
            
            btnSua.Show();
           
        }
        public void Button2_Click_2_luu(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            btnSua.Show();

        }
        

        public void itemFood_Load(object sender, EventArgs e)
        {
            btnSua.Hide();
            btnHuy.Show();
            btnThem.Show();
            btnThemAnh.Hide();
            btnCancel.Hide();
            txtDoiGia.Hide();
            txtDoiTen.Hide();
            txtGiaFood.Show();
            txtTenFood.Show();
            btnSave.Hide();
            txtDoiTen.Text = txtTenFood.Text;
            txtDoiGia.Text = giaFood.ToString(); ;

            Form1.Button2_Click_2 += Button2_Click_2;
            Form1.Button2_Click_2_luu += Button2_Click_2_luu;
            
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            getCount = count;
            if (BtnHuy_Click != null)
                BtnHuy_Click.Invoke(this, e);

        }
        public void insertDonHang()
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnHuy.Hide();
            btnThem.Hide();
            btnThemAnh.Show();
            btnCancel.Show();
            txtDoiGia.Show();
            txtDoiTen.Show();
            txtGiaFood.Hide();
            txtTenFood.Hide();
            btnSua.Hide();
            btnSave.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSua.Show();
            btnHuy.Show();
            btnThem.Show();
            btnThemAnh.Hide();
            btnCancel.Hide();
            txtDoiGia.Hide();
            txtDoiTen.Hide();
            txtGiaFood.Show();
            txtTenFood.Show();
            btnSave.Hide();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            f1.sqlcode("UPDATE tbl_hangban set tenhang = N'" + txtDoiTen.Text + "', dongia = N'" + txtDoiGia.Text + "',anh = " + ToVarbinary(imageToByteArray(picturebox1.BackgroundImage)) + " WHERE  hangid = '" + idFood + "'");
            btnSua.Show();
            btnHuy.Show();
            btnThem.Show();
            btnThemAnh.Hide();
            btnCancel.Hide();
            txtDoiGia.Hide();
            txtDoiTen.Hide();
            txtGiaFood.Show();
            txtTenFood.Show();
            btnSave.Hide();
            giaFood = Convert.ToDouble(txtDoiGia.Text);
            txtGiaFood.Text = giaFood.ToString();
            tenFood = txtDoiTen.Text;
            txtTenFood.Text=tenFood.ToString();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                picturebox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtDoiGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
