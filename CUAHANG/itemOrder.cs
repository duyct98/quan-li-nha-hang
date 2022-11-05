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
    public partial class itemOrder : UserControl
    {
        public itemOrder()
        {
            InitializeComponent();
        }

        CUAHANG f1 = new CUAHANG();
        private void itemOrder_Load(object sender, EventArgs e)
        {
            txtHoaDonID.Text = donHangID.ToString();
            txtGiaFood.Text = f1.Laydatasql("select tongbill from view_Bill1 where donhangid = "+donHangID+" ");
        }
      
        public int donHangID {get;set;}

        private void button1_Click(object sender, EventArgs e)
        {
            ORDER.donhangID = donHangID;

            ORDER oRDER = new ORDER();
            oRDER.ShowDialog();
        }
    }
}
