using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_KHACH_CHUAN
{

    
    public partial class ListHoaDon : UserControl
    {
        public ListHoaDon()
        {
            InitializeComponent();
        }

        public int donHangID { get; set; }
        Form1 f1 = new Form1();
       
        private void button1_Click(object sender, EventArgs e)
        {
            thongTinDonHang.DonHangId = donHangID;
            thongTinDonHang ThongTinDonHang = new thongTinDonHang();
            ThongTinDonHang.Show();
        }
        
       
        private void ListHoaDon_Load(object sender, EventArgs e)
        {
            txtHoaDonID.Text = donHangID.ToString();
            txtGiaFood.Text = (Convert.ToInt32(f1.Laydatasql("select sum(DonGia*SoLuong) as 'tongbill' from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID where dh.donhangid = " + donHangID + ""))).ToString("0,000") + " VND" ;

        }
    }
}
