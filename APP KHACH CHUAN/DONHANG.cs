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
    public partial class DONHANG : Form
    {
        public DONHANG()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();


        List<ListHoaDon> listhoadon = new List<ListHoaDon>();

        private void button1_Click(object sender, EventArgs e)
        {
            int donhangid = 0;
            for (int i = 0; i < Convert.ToInt32(f1.Laydatasql("select Count(donhangid) from tbl_donhang ")); i++)
            {
                while (true)
                {

                    listhoadon.Add(new ListHoaDon());

                    int test = Convert.ToInt32(f1.Laydatasql("select donhangid from tbl_donhang where donhangid = '" + donhangid + "'"));
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

        private void DONHANG_Load(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }
    }
}
