using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            var matKhau = txtMatKhau.Text;

            if(string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng đăng nhập tên đăng nhập", "Thông báo");
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng đăng nhập mật khẩu", "Thông báo");
                txtMatKhau.Focus();
                return;
            }

            if (login(tenDangNhap, matKhau))
            {
                MessageBox.Show("đăng nhập thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("đăng nhập thất bại vui lòng xem lại tên đăng nhập hoặc mật khẩu", "Thông báo");
                txtTenDangNhap.Focus();
            }
        }

        bool login(string tenDangNhap, string matKhau)
        {
            if (tenDangNhap == "tpquoc22" && matKhau == "123456")
                return true;
            else
                return false;
        }
    }
}
