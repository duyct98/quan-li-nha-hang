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

namespace APP_KHACH_CHUAN
{
    public partial class ItemDatHang : UserControl
    {
        public ItemDatHang()
        {
            InitializeComponent();
        }
        public string tenfood { get; set; }
        public int soluong { get; set; }
        private void ItemDatHang_Load(object sender, EventArgs e)
        {
            txtTenFood.Text = tenfood;
            txtSoluong.Text = soluong.ToString();
        }
        Form1 f1 = new Form1();
        public void getdata(int hangid, int donhangid)
        {
            tenfood = f1.Laydatasql("select hb.tenhang from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID where h.hangid = " + hangid + " and dh.donhangid= " + donhangid + "");
            soluong = Convert.ToInt32(f1.Laydatasql("select h.soluong from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID where h.hangid = " + hangid + " and dh.donhangid= " + donhangid + ""));
            string ss = "select hb.anh from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID where h.hangid = " + hangid + " and dh.donhangid= " + donhangid + "";

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
        }
    }
}
