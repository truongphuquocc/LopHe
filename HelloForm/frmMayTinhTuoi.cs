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
    public partial class frmMayTinhTuoi : Form
    {
        public frmMayTinhTuoi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txttuoi.Text))
            {
                //lbtuoi2.Visible = true;
                MessageBox.Show("Vui lòng nhập số tuổi của bạn", "Thông báo");
                txttuoi.Focus();
                return;
            }
       
                lbtuoi2.Text = "bằng một cách kỳ diệu bạn đã " + txttuoi.Text + " tuổi rồi!";
                lbtuoi2.Show();
           




        }

        private void txttuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMayTinhTuoi_Load(object sender, EventArgs e)
        {

        }

        private void lbtuoi2_Click(object sender, EventArgs e)
        {
          //  lbtuoi2.Visible = true;
        }
    }
}
