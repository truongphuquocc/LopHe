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
    public partial class frmPINLogin : Form
    {
        public frmPINLogin()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var matKhau = txtMatKhau.Text;

            if (txtMatKhau.Text.Length >= 6)
            {
                if (matKhau == "123456")
                {
                    MessageBox.Show("đăng nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("đăng nhập thất bại vui lòng xem lại mật khẩu", "Thông báo");
                    txtMatKhau.Focus();
                    txtMatKhau.Clear();
                }
            }
        }

        private void frmPINLogin_Load(object sender, EventArgs e)
        {
           // Application.Exit();
        }


        private void txtMatKhau_Enter(object sender, EventArgs e)
        {

        }

        bool login(string matKhau)
        {
            if (matKhau == "123456")
                return true;
            else
                return false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text += 0;
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
