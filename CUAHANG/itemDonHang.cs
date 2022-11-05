using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUAHANG
{
    public partial class itemDonHang : UserControl
    {
        public itemDonHang()
        {
            InitializeComponent();
        }
        CUAHANG f1 = new CUAHANG();
        public void getdatafood(int donhangid, int hangid)
        {
            giafood = f1.Laydatasql("select dongia from view_Hoadon1 where hangid = '" + hangid + "' and donhangid = "+ donhangid+ "");
            tenfood = f1.Laydatasql("select tenhang from view_Hoadon1 where hangid = '" + hangid + "' and donhangid = " + donhangid + "");
            soluong = f1.Laydatasql("select soluong from view_Hoadon1 where hangid = '" + hangid + "' and donhangid = " + donhangid + "");
        }
        public string giafood, tenfood, soluong;
        private void itemDonHang_Load(object sender, EventArgs e)
        {
            txtGiaFood.Text = giafood;
            txtSoLuong.Text = soluong;
            txtTenFood.Text = tenfood;
        }
    }
}
