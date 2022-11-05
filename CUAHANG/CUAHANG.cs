using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CUAHANG
{
    public partial class CUAHANG : Form
    {
        public CUAHANG()
        {
            InitializeComponent();
        }
        public string strcon = "Data Source=ADMIN;Initial Catalog=QL_APPFOODtest45;Integrated Security=True";
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

        private void BtnSuaGia_Click(object sender, EventArgs e)
        {
            
           // sqlcode("UPDATE tbl_hangban set tenhang = '" + itemFood +"'");

        }
        private void BtnSuaAnh_Click(object sender, EventArgs e)
        {
           

        }
        private void BtnSuaTen_Click(object sender, EventArgs e)
        {
           
        }

        private void btbThucUong_Click(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            homePanel.Controls.Clear();
            homePanel.Controls.Add(btnThemMon);
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
                    itemFood.listThucUong[i].BtnSuaGia_Click += new System.EventHandler(BtnSuaGia_Click);
                    itemFood.listThucUong[i].BtnSuaAnh_Click += new System.EventHandler(BtnSuaAnh_Click);
                    itemFood.listThucUong[i].BtnSuaTen_Click += new System.EventHandler(BtnSuaTen_Click);
                    homePanel.Controls.Add(itemFood.listThucUong[i]);




                }
                
            }



        }

        private void btnMonAnChinh_Click(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            homePanel.Controls.Clear();
            homePanel.Controls.Add(btnThemMon);
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
                    itemFood.listAnChinh[i].BtnSuaGia_Click += new System.EventHandler(BtnSuaGia_Click);
                    itemFood.listAnChinh[i].BtnSuaAnh_Click += new System.EventHandler(BtnSuaAnh_Click);
                    itemFood.listAnChinh[i].BtnSuaTen_Click += new System.EventHandler(BtnSuaTen_Click);
                    homePanel.Controls.Add(itemFood.listAnChinh[i]);




                }

            }
        }

        private void btnAnVat_Click(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            homePanel.Controls.Clear();
            homePanel.Controls.Add(btnThemMon);
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
                    itemFood.listAnVat[i].BtnSuaGia_Click += new System.EventHandler(BtnSuaGia_Click);
                    itemFood.listAnVat[i].BtnSuaAnh_Click += new System.EventHandler(BtnSuaAnh_Click);
                    itemFood.listAnVat[i].BtnSuaTen_Click += new System.EventHandler(BtnSuaTen_Click);
                    homePanel.Controls.Add(itemFood.listAnVat[i]);




                }

            }
        }

        private void btnRuouBia_Click(object sender, EventArgs e)
        {
            homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            homePanel.Controls.Clear();
            homePanel.Controls.Add(btnThemMon);
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
                    itemFood.listRuouBia[i].BtnSuaGia_Click += new System.EventHandler(BtnSuaGia_Click);
                    itemFood.listRuouBia[i].BtnSuaAnh_Click += new System.EventHandler(BtnSuaAnh_Click);
                    itemFood.listRuouBia[i].BtnSuaTen_Click += new System.EventHandler(BtnSuaTen_Click);
                    homePanel.Controls.Add(itemFood.listRuouBia[i]);




                }

            }
        }


        List<itemOrder> listOrder = new List<itemOrder>();
        private void CUAHANG_Load(object sender, EventArgs e)
        {

            int donhangid = 0;
            for(int i=0; i <Convert.ToInt32(Laydatasql("select Count(donhangid) from tbl_donhang "));i++ )
            {
                while (true)
                {
                    
                    listOrder.Add(new itemOrder());
                    
                    int test = Convert.ToInt32(Laydatasql("select donhangid from tbl_donhang where donhangid = '" + donhangid + "'")) ;
                    if (test != 0)
                    {
                        listOrder[i].donHangID = donhangid;
                        orderPanel.Controls.Add(listOrder[i]);
                        donhangid++;
                        break;
                    }
                    donhangid++;


                }


                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MenuThemItemFOOD f1 = new MenuThemItemFOOD();
            f1.ShowDialog();
        }
        public void BtnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
