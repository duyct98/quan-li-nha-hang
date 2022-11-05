using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_KHACH_CHUAN
{
    public partial class ShopFood : UserControl
    {
        public ShopFood()
        {
            InitializeComponent();
        }
        public static List<ShopFood> listShopFood = new List<ShopFood>();
        private void txtDiaChiShop_Click(object sender, EventArgs e)
        {
            
        }
        public static int dem = 0;
        int idShop { get; set; }
        string tenShop { get; set; }
        string diaChiShop { get; set; }

        Form1 f1 = new Form1();
        public void getIDShop()
        { 
            while (true)
            {

                idShop = Convert.ToInt32(f1.Laydatasql("select cuahangid from tbl_CuaHang where cuahangid='" + dem + "'"));
                
                tenShop = f1.Laydatasql("select tencuahang from tbl_CuaHang where cuahangid='" + idShop + "'");
                txtTenShop.Text = tenShop;
                diaChiShop = f1.Laydatasql("select diachi from tbl_CuaHang where cuahangid='" + idShop + "'");
                txtDiaChiShop.Text = diaChiShop;
                dem++;
                if (idShop != 0)
                {
                    break;
                }
            }
            

        }

        private void ShopFood_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler PictureBox1_Click;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.cuaHangID = idShop;

           if (PictureBox1_Click!=null)
                PictureBox1_Click.Invoke (this, e);
         



        }
    }
}
