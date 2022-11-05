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
    public partial class thongTinDonHang : Form
    {
        public thongTinDonHang()
        {
            InitializeComponent();
        }
        public static int DonHangId { get; set; }
        public int hangid { get; set; }
        Form1 f1 = new Form1();
        List<ItemDatHang> listItemDatHang = new List<ItemDatHang>();
        private void thongTinDonHang_Load(object sender, EventArgs e)
        {
            txtDonHangID.Text = DonHangId.ToString();
            txtTongBiil.Text = (f1.Laydatasql("select sum(DonGia*SoLuong) as 'tongbill' from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID where dh.donhangid = " + DonHangId + "")).ToString();
            hangid = 0;
            for (int i = 0;i< Convert.ToInt32(f1.Laydatasql("select COUNT(hb.hangid)from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID  where dh.DonHangID = " + DonHangId+"")) ; i++)
            {
                
                while (true)
                {
                    int test = Convert.ToInt32(f1.Laydatasql("select hb.hangid from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID  where dh.DonHangID = " + DonHangId + " and h.hangid = " + hangid + ""));

                    if (test != 0)
                    {
                        listItemDatHang.Add(new ItemDatHang());
                        listItemDatHang[i].getdata(hangid, DonHangId);
                        panelDonHang.Controls.Add(listItemDatHang[i]);
                        hangid++;
                        break;
                    }
                    hangid++;
                }
                

            }
            

            

           
        }
        public static event EventHandler BtnHoanThanhDonHang_Click;
        private void btnHoanThanhDonHang_Click(object sender, EventArgs e)
        {
            f1.sqlcode("delete from tbl_hang where DonHangID = "+DonHangId+ " delete from tbl_DonHang where DonHangID = "+DonHangId+"");
            f1.refreshHoaDon();
            this.Close();
            if (BtnHoanThanhDonHang_Click != null)
                BtnHoanThanhDonHang_Click.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
