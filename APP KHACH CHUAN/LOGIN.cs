using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_KHACH_CHUAN
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        public Form1 f1 = new Form1();
        public static string taikhoan;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == f1.Laydatasql("select taikhoan from tbl_khach where taikhoan='" + txtTaiKhoan.Text + "'") && txtPass.Text == f1.Laydatasql("select matkhau from tbl_khach where matkhau='" + txtPass.Text + "'"))
            {

               


                Form1.khachid = Convert.ToInt32(f1.Laydatasql("select khachid from tbl_Khach where taikhoan LIKE N'"+txtTaiKhoan.Text+"'"));
                
                
                this.Hide();
                f1.Show();






            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản !!! Vui lòng nhập lại .");
            }


        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            groupDangNhap.Hide();
            groupDangKi.Hide();
            groupDoiLaiMatKhau.Hide();
            groupQuenMatKhau.Show();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            groupDangNhap.Hide();
            groupDangKi.Show();
            groupDoiLaiMatKhau.Hide();
            groupQuenMatKhau.Hide();

        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan_QuenMatKhau.Text == f1.Laydatasql("select taikhoan from tbl_khach where taikhoan='" + txtTaiKhoan_QuenMatKhau.Text + "'") && txtTen_QuenMatKhau.Text == f1.Laydatasql("select tenkhach from tbl_khach where TenKhach='" + txtTen_QuenMatKhau.Text + "'") && txtEmail_QuenMatKhau.Text == f1.Laydatasql("select email from tbl_khach where email='" + txtEmail_QuenMatKhau.Text + "'"))
            {
                groupDangNhap.Hide();
                groupDangKi.Hide();
                groupDoiLaiMatKhau.Show();
                groupQuenMatKhau.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin !!!");
            }
        }

        private void btnXacNhanDangKi_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() != "" || txtTaiKhoan_DangKi.Text.Trim() != "" || txtTen.Text.Trim() != "")
            {
                if (txtMatKhau.Text == txtLapLaiMatKhau.Text)
                {



                    f1.sqlcode("INSERT INTO tbl_khach(TenKhach,DiaChi,Email,taikhoan,MATKHAU) VALUES (N'" + txtTen.Text + "',N'" + txtDiaChi.Text + "',N'" + txtEmail.Text + "',N'" + txtTaiKhoan_DangKi.Text.Trim() + "',N'" + txtMatKhau.Text.Trim() + "')");
                    MessageBox.Show("Đăng kí thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng nhau");
                }
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin !!!");

            groupDangKi.Hide();
            groupDangNhap.Show();


        }

        private void btnHuyDangKi_Click(object sender, EventArgs e)
        {
            groupDangNhap.Show();
            groupDangKi.Hide();
            

        }

        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            groupDangNhap.Show();
            groupDangKi.Hide();
            groupDoiLaiMatKhau.Hide();
            groupQuenMatKhau.Hide();
            if (txtMatKhau_QuenMatKhau == txtLapLaiMatKhau_QuenMatKhau)
                {
                    f1.sqlcode("UPDATE tbl_khach SET MATKHAU = '" + txtMatKhau_QuenMatKhau.Text + "' WHERE taikhoan='" + txtTaiKhoan_QuenMatKhau.Text + "'");
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else MessageBox.Show("Mật khẩu phải trùng nhau !!!");

            
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            groupDangNhap.Show();
            groupDangKi.Hide();
            groupDoiLaiMatKhau.Hide();
            groupQuenMatKhau.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupDangNhap.Show();
            groupDangKi.Hide();
            groupDoiLaiMatKhau.Hide();
            groupQuenMatKhau.Hide();
        }
    }
}
