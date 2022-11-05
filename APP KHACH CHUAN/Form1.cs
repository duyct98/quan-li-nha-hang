using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_KHACH_CHUAN
{
    public partial class Form1 : Form
    {

        public static int cuaHangID { get; set; }
        public static int khachid { get; set; }

        public int getIDShop()
        {
            return cuaHangID;
        }

        public Form1()
        {
            InitializeComponent();

        }
        public string strcon = "Data Source=.;Initial Catalog=QL_APPFOODtest50;Integrated Security=True";
        public void sqlcode(string data) // select * fromm ....
        {
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand updateCmd = new SqlCommand(data, conn);
            updateCmd.CommandType = CommandType.Text;
            updateCmd.ExecuteNonQuery();
            conn.Close();
        }
        public string Laydatasql(string codesql)
        {
            string data = null;
            SqlConnection conn = new SqlConnection(strcon);
            if (conn == null)
            {
                conn = new SqlConnection(strcon);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = codesql;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                data = reader.GetValue(0).ToString();



            }

            conn.Close();
            reader.Close();
            return data;

        }


        public void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Hide();
            btnBack_Click(sender, e);
            refreshHoaDon();
            thongTinDonHang.BtnHoanThanhDonHang_Click += BtnHoanThanhDonHang_Click;
            LoadHoaDon();
            groupMenu.Show();
            GroupQUANLI.Hide();
            homePanel.Controls.Clear();
            groupMatKhauQuanLY.Hide();
            btnBack_Click(sender, e);
            MENUThemItem.Button2_Click += Button2_Click;

        }
        public void Button2_Click(object sender, EventArgs e)
        {

            itemFood.listThucUong.Clear();
            itemFood.listAnVat.Clear();
            itemFood.listAnChinh.Clear();
            itemFood.listRuouBia.Clear();
            btnBack_Click(sender, e);
        }

        private void listDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void itemFood1_BtnThem_Click(object sender, EventArgs e)
        {


        }

        public void setKhachId()
        {
            khachid = Convert.ToInt32(Laydatasql("select khachid from tbl_khach where khachid= '" + LOGIN.taikhoan + "'"));
        }
        List<ListHoaDon> listhoadon = new List<ListHoaDon>();
        public void refreshHoaDon()
        {
            listhoadon.Clear();
            panelHoaDon.Controls.Clear();
            int donhangid = 1000;
            for (int i = 0; i < Convert.ToInt32(Laydatasql("select Count(donhangid) from tbl_donhang ")); i++)
            {

                while (true)
                {

                    listhoadon.Add(new ListHoaDon());

                    int test = Convert.ToInt32(Laydatasql("select donhangid from tbl_donhang where donhangid = '" + donhangid + "'"));
                    if (test != 0)
                    {
                        listhoadon[i].donHangID = donhangid;
                        panelHoaDon.Controls.Add(listhoadon[i]);
                        donhangid++;
                        break;
                    }
                    donhangid++;


                }



            }
        }
        public void btnThanhToan_Click(object sender, EventArgs e)
        {

            int donhangid = Convert.ToInt32(Laydatasql("insert tbl_DonHang(NgayBan,KhachID) values ('" + dateTimePicker2.Value.ToString("MM-dd-yyyy HH:mm:ss") + "'," + khachid + ") SELECT @@IDENTITY asLastID"));

            for (int i = 0; i < itemFoodDonHang.listDatHang.Count; i++)
            {

                if (itemFoodDonHang.listDatHang[i].getSoLuong() > 0)
                {
                    int idfood = itemFoodDonHang.listDatHang[i].getIDFood();
                    int soluong = itemFoodDonHang.listDatHang[i].getSoLuong();

                    sqlcode("insert into tbl_hang(Donhangid,hangid,soluong) values (" + donhangid + ",'" + idfood + "','" + soluong + "')");

                }



            }
            for (int i = 0; i < itemFoodDonHang.listDatHang.Count; i++)
            {
                itemFoodDonHang.listDatHang[i].resetSolLuong();
            }

            panelDonHang.Controls.Clear();
            txtGia.Text = 0.ToString();
            MessageBox.Show("Đặt hàng thành công !!!!");
            refreshHoaDon();

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void itemFood_BtnThem_Click(object sender, EventArgs e)
        {


            itemFoodDonHang.listDatHang[itemFood.getCount].tangSoLuong();

            panelDonHang.Controls.Add(itemFoodDonHang.listDatHang[itemFood.getCount]);

            double gia = itemFoodDonHang.listDatHang[itemFood.getCount].getGiaFood();
            txtGia.Text = (gia + Convert.ToDouble(txtGia.Text)).ToString("0,000");





        }
        private void itemFood_BtnHuy_Click(object sender, EventArgs e)
        {


            if (itemFoodDonHang.listDatHang[itemFood.getCount].getSoLuong() == 1)
            {
                panelDonHang.Controls.Remove(itemFoodDonHang.listDatHang[itemFood.getCount]);
            }

            itemFoodDonHang.listDatHang[itemFood.getCount].giamSoLuong();

            double gia = itemFoodDonHang.listDatHang[itemFood.getCount].getGiaFood();

            if (Convert.ToDouble(txtGia.Text) > 0 && itemFoodDonHang.listDatHang[itemFood.getCount].getSoLuong() > 0)
            {
                txtGia.Text = (Convert.ToDouble(txtGia.Text) - gia).ToString();
            }



        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void groupMenu_Enter(object sender, EventArgs e)
        {

        }



        private void groupDangNhap_Enter(object sender, EventArgs e)
        {

        }




        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            homePanel.Controls.Clear();

            itemFood.listfood.Clear();
            itemFoodDonHang.listDatHang.Clear();

            itemFood.dem = 1;

            for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where cuahangid= '" + getIDShop() + "'")); i++)
            {
                itemFood.listfood.Add(new itemFood());
                itemFood.listfood[i].dataFood();

                itemFood.listfood[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                itemFood.listfood[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);

                itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                itemFoodDonHang.listDatHang[i].setIDFood(itemFood.listfood[i].getIDFood());
                itemFoodDonHang.listDatHang[i].setTenFood(itemFood.listfood[i].getTenFood());
                itemFoodDonHang.listDatHang[i].SetGiaFood(itemFood.listfood[i].getGiaFood());

                itemFood.listfood[i].count = i;
                itemFoodDonHang.listDatHang[i].count = i;


                homePanel.Controls.Add(itemFood.listfood[i]);

            }

            for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(CuaHangID) from tbl_CuaHang")); i++)
            {

                ShopFood.listShopFood[i].PictureBox1_Click -= PictureBox1_Click;



            }
        }
        public static event EventHandler BtnBack_Click;
        public void btnBack_Click(object sender, EventArgs e)
        {   

            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            homePanel.Controls.Clear();
            itemFood.dem = 0;

            if (itemFood.listThucUong.Count > 0)
            {
                for (int i = 0; i < itemFood.listThucUong.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listThucUong[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'nuocuong'")); i++)
                {


                    itemFood.listThucUong.Add(new itemFood());
                    itemFood.listThucUong[i].getDataFood("nuocuong");
                    itemFood.listThucUong[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listThucUong[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listThucUong[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listThucUong[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listThucUong[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listThucUong[i].getGiaFood());
                    itemFood.listThucUong[i].doiMauItemFood(192, 255, 192);
                    itemFood.listThucUong[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].count = i;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "nuocuong";
                    itemFoodDonHang.getCount++;

                }

            }
            if (BtnBack_Click != null) 
            BtnBack_Click.Invoke(this, e);


        }
        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        private void groupDatHangThanhCong_Enter(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));

            homePanel.Controls.Clear();
            itemFood.dem = 0;
            if (itemFood.listRuouBia.Count > 0)
            {
                for (int i = 0; i < itemFood.listRuouBia.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listRuouBia[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'ruoubia'")); i++)
                {


                    itemFood.listRuouBia.Add(new itemFood());
                    itemFood.listRuouBia[i].getDataFood("ruoubia");
                    itemFood.listRuouBia[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listRuouBia[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listRuouBia[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listRuouBia[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listRuouBia[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listRuouBia[i].getGiaFood());

                    itemFood.listRuouBia[i].doiMauItemFood(255, 255, 128);
                    itemFood.listRuouBia[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].count = i;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "ruoubia";
                    itemFoodDonHang.getCount++;

                }
            }
        }





        private void button2_Click_1(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            homePanel.Controls.Clear();
            itemFood.dem = 0;

            if (itemFood.listAnChinh.Count > 0)
            {
                for (int i = 0; i < itemFood.listAnChinh.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listAnChinh[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'monanchinh'")); i++)
                {


                    itemFood.listAnChinh.Add(new itemFood());
                    itemFood.listAnChinh[i].getDataFood("monanchinh");
                    itemFood.listAnChinh[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listAnChinh[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listAnChinh[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listAnChinh[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listAnChinh[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listAnChinh[i].getGiaFood());
                    itemFood.listAnChinh[i].doiMauItemFood(255, 128, 128);
                    itemFood.listAnChinh[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].count = i;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "monanchinh";
                    itemFoodDonHang.getCount++;

                }

            }

        }

        private void btnAnVat_Click(object sender, EventArgs e)
        {

            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            homePanel.Controls.Clear();
            itemFood.dem = 0;
            if (itemFood.listAnVat.Count > 0)
            {
                for (int i = 0; i < itemFood.listAnVat.Count; i++)
                {
                    homePanel.Controls.Add(itemFood.listAnVat[i]);
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(Laydatasql(@"select Count(HangID) from tbl_HangBan where loai= 'anvat'")); i++)
                {


                    itemFood.listAnVat.Add(new itemFood());
                    itemFood.listAnVat[i].getDataFood("anvat");
                    itemFood.listAnVat[i].BtnThem_Click += new System.EventHandler(itemFood_BtnThem_Click);
                    itemFood.listAnVat[i].BtnHuy_Click += new System.EventHandler(itemFood_BtnHuy_Click);
                    homePanel.Controls.Add(itemFood.listAnVat[i]);
                    itemFoodDonHang.listDatHang.Add(new itemFoodDonHang());
                    itemFood.listAnVat[i].doiMauItemFood(128, 255, 255);
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setIDFood(itemFood.listAnVat[i].getIDFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].setTenFood(itemFood.listAnVat[i].getTenFood());
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].SetGiaFood(itemFood.listAnVat[i].getGiaFood());
                    itemFood.listAnVat[i].count = itemFoodDonHang.getCount;
                    itemFoodDonHang.listDatHang[itemFoodDonHang.getCount].loai = "anvat";


                    itemFoodDonHang.getCount++;
                }

            }

        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            txtGia.Text = 0.ToString();
            for (int i = 0; i < itemFoodDonHang.listDatHang.Count; i++)
            {
                itemFoodDonHang.listDatHang[i].resetSolLuong();
            }
            panelDonHang.Controls.Clear();
        }

        private void btnDanhSachDonDatHang_Click(object sender, EventArgs e)
        {
            refreshHoaDon();
        }
        private void BtnHoanThanhDonHang_Click(object sender, EventArgs e)
        {
            refreshHoaDon();
        }

        private void panelHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataHoaDon.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtdonhangid.Text = row.Cells[0].Value.ToString();
                txtTongHoaDon.Text = Convert.ToInt32(row.Cells[1].Value).ToString("0,000") + " VND";
                txtNgayBan.Text = row.Cells[2].Value.ToString();

                LoadThongTinHoaDon();
                //Không cho phép sửa trường STT

            }
        }
        private void LoadHoaDon()
        {
            SqlConnection cnn = new SqlConnection(strcon);
            cnn.Open();
            string sql = "select dh.DonHangID,sum(DonGia*SoLuong) as 'tongbill',dh.NgayBan \r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid \r\ninner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\ngroup by dh.DonHangID,dh.NgayBan ";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataHoaDon.DataSource = dt;
        }
        private void LoadThongTinHoaDon()
        {
            DataThongTinHoaDon.Controls.Clear();
            SqlConnection cnn = new SqlConnection(strcon);
            cnn.Open();
            string sql = " select h.HangID,TenHang,SoLuong,DonGia from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid where h.DonHangID = '" + txtdonhangid.Text + "' group by  h.HangID,TenHang,SoLuong,DonGia";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            DataThongTinHoaDon.DataSource = dt;
        }
        public int i = 0;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = null;
            if (comboBox1.SelectedIndex == 0)
            {
                sql = "select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',dh.NgayBan\r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\ngroup by dh.DonHangID,dh.NgayBan \r\norder by 'tongbill' asc";  // lay het du lieu trong bang sinh vien

            }
            if (comboBox1.SelectedIndex == 1)
            {
                sql = "select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',dh.NgayBan\r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\ngroup by dh.DonHangID,dh.NgayBan \r\norder by 'tongbill' desc";  // lay het du lieu trong bang sinh vien

            }

            if (comboBox1.SelectedIndex == 2)
            {
                sql = "select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',NgayBan\r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\nwhere DAY(NgayBan)= DAY(GETDATE())\r\ngroup by dh.DonHangID,ngayban ";  // lay het du lieu trong bang sinh vien

            }
            if (comboBox1.SelectedIndex == 3)
            {
                sql = "select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',NgayBan\r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\nwhere MONTH(NgayBan)> MONTH(GETDATE())-1\r\ngroup by dh.DonHangID,ngayban";  // lay het du lieu trong bang sinh vien

            }
            if (comboBox1.SelectedIndex == 4)
            {
                sql = "select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',NgayBan\r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\nwhere MONTH(NgayBan)> MONTH(GETDATE())-3\r\ngroup by dh.DonHangID,ngayban";  // lay het du lieu trong bang sinh vien

            }
            SqlConnection cnn = new SqlConnection(strcon);
            cnn.Open();
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataHoaDon.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string sql = "select dh.DonHangID,sum(DonGia*SoLuong)as 'tongbill',dh.NgayBan\r\nfrom tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID \r\nwhere DAY(NgayBan) = " + dateTimePicker1.Value.Day + " and MONTH(NgayBan) = " + dateTimePicker1.Value.Month + "  and YEAR(NgayBan) = " + dateTimePicker1.Value.Year + "group by dh.DonHangID,dh.NgayBan \r\n";  // lay het du lieu trong bang sinh vien
            SqlConnection cnn = new SqlConnection(strcon);
            cnn.Open();
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataHoaDon.DataSource = dt;
        }

        private void GroupQUANLI_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemItem_Click(object sender, EventArgs e)
        {
            
            
                    MENUThemItem themitem = new MENUThemItem();
                    themitem.Show();
                    groupMatKhauQuanLY.Hide();
                
            
               
        }
        public static event EventHandler Button2_Click_2;
        public static event EventHandler Button2_Click_2_luu;
        private void button2_Click_2(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                btnChinhSuaFOOD.Text = "LƯU CHỈNH SỬA";
                groupMatKhauQuanLY.Hide();
                if (Button2_Click_2 != null)
                    Button2_Click_2.Invoke(this, e);
            }
            else
            {
                btnChinhSuaFOOD.Text = "CHỈNH SỬA Item bán";
                groupMatKhauQuanLY.Hide();
                if (Button2_Click_2_luu != null)
                    Button2_Click_2_luu.Invoke(this, e);
            }





        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LOGIN login = new LOGIN();
                login.Show();
                this.Close();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

       
        public bool check;
        private void button1_Click_1(object sender, EventArgs e)
        {

                
           /* groupMenu.Hide();
            dateTimePicker1_ValueChanged(sender, e);

            btnThemItem.Hide();
            btnChinhSuaFOOD.Hide();

            btnBack.Show();
            groupMatKhauQuanLY.Hide();
            txtPass.Text = null;*/

        }
        private void button1_Click(object sender, EventArgs e)
        {

           
            btnBack.Hide();
            dateTimePicker1_ValueChanged(sender, e);
            groupMenu.Hide();
            btnThemItem.Hide();
            btnChinhSuaFOOD.Hide();
            GroupQUANLI.Show();
            btnDanhChoQuanLy.Hide();
            btnBack.Show();
            groupMatKhauQuanLY.Hide();

        }

        private void btnHuyXacNhan_Click(object sender, EventArgs e)
        {
            groupMatKhauQuanLY.Hide();
            txtPass.Text = null;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            btnBack.Hide();
            groupMenu.Show();
            GroupQUANLI.Hide();
            btnChinhSuaFOOD.Show();
            btnDanhChoQuanLy.Show();
            btnThemItem.Show();
        }
    }
}
