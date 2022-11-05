using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace APP_KHACH_CHUAN
{
    public partial class itemFoodDonHang : UserControl
    {
        public itemFoodDonHang()
        {
            InitializeComponent();
        }
        int IDFood;
        public string loai { get; set; }
        public static List<itemFoodDonHang> listDatHang = new List<itemFoodDonHang>();
        public void setTenFood(string data)
        {
            tenFood.Text = data;
        }
        public string getTenFood()
        {
           return tenFood.Text;
        }
        public void setIDFood(int data)
        {
            IDFood = data;
        }
        public int getIDFood()
        {
            return IDFood;
        }
        public void SetGiaFood(double data)
        {
            Gia.Text = data.ToString();
        }
        public double getGiaFood()
        {
            return Convert.ToDouble(Gia.Text);
        }
        private void itemFoodDonHang_Load(object sender, EventArgs e)
        {

        }
        public int getSoLuong()
        {
            return Convert.ToInt32(SoLuong.Text) ;
        }
        public void resetSolLuong()
        {
            SoLuong.Text = 0.ToString();
        }
        public void tangSoLuong()
        {
            SoLuong.Text = (Convert.ToInt32(SoLuong.Text) + 1).ToString() ;
        }
        public void giamSoLuong()
        {
            if(Convert.ToInt32(SoLuong.Text)==0)
            {

            }
            else
            SoLuong.Text = (Convert.ToInt32(SoLuong.Text) - 1).ToString();

        }

        private void tenFood_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        public int count { get; set; }
        public static int getCount=0;
       

     
    }
}
