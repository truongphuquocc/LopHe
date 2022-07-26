using HelloForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class frmDanhSachSinhVien : Form
    {
        string fPath = ("SinhVien.txt");
        List<SinhVien> lstSv;

        public frmDanhSachSinhVien()
        {
            InitializeComponent();
            lstSv = new List<SinhVien>();
            DataTable table = new DataTable();
            var list = NapDanhSachSinhVien(fPath);
            lblTongSinhVien.Text = $"{ list.Count} SinhVien";
            sinhVienBindingSource.DataSource = list;
            dataGridView1.DataSource = sinhVienBindingSource;
            //dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// Đọc dữ liệu từ file SinhVien.txt thành danh sách sinh viên
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        List<SinhVien> NapDanhSachSinhVien(string fileName)
        {
            List<SinhVien> rs = new List<SinhVien>();

            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                SinhVien sv = SinhVien.Parse(line);
                rs.Add(sv);
            }
            return rs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            var list = NapDanhSachSinhVien(fPath);
            sinhVienBindingSource.DataSource = list;
            dataGridView1.DataSource = sinhVienBindingSource;
        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new frmProfile();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            //int index = e.row
            if(MessageBox.Show("Bạn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
            }


        }

        private void ReLoad_Click(object sender, EventArgs e)
        {
            var list = NapDanhSachSinhVien(fPath);
            lblTongSinhVien.Text = $"{ list.Count} SinhVien";
            sinhVienBindingSource.DataSource = list;
            dataGridView1.DataSource = sinhVienBindingSource;
        }

        int index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
