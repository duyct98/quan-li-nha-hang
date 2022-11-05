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
    public partial class ORDER : Form
    {
        public ORDER()
        {
            InitializeComponent();
        }
        public static int donhangID { get; set; }
        List<itemDonHang> listdonhang = new List<itemDonHang>();
        CUAHANG f1 = new CUAHANG();
        private void ORDER_Load(object sender, EventArgs e)
        {
            int hangid = 0 ;
            for (int i = 0; i < Convert.ToInt32(f1.Laydatasql("select Count(HangID) from tbl_hang where DonHangID= " + donhangID + ""));i++)
            {   

                listdonhang.Add(new itemDonHang());
                int test;
                while (true)
                {
                    test = Convert.ToInt32(f1.Laydatasql("select hangid from tbl_hang where DonHangID= " + donhangID + " AND hangid = "+ hangid + ""));

                    if (test != 0)
                    {
                        listdonhang[i].getdatafood(donhangID, hangid);
                        flowLayoutPanel1.Controls.Add(listdonhang[i]);
                        hangid++;
                        break;
                    }
                    hangid++;

                }
                
            }
        }
    }
}
