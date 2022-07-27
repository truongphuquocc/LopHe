using QLSinhVienProject.DAL;
using QLSinhVienProject.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapLopHoc();
        }

        void NapLopHoc()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var dsLopHoc = model.LopHocs.ToList();
            cmbLopHoc.DataSource = dsLopHoc;
            cmbLopHoc.DisplayMember = "TenLop";
        }

        void NapHocSinh()
        {
            var lop = cmbLopHoc.SelectedItem as LopHoc;
            QLSinhVienModel model = new QLSinhVienModel();
            var dsHocSinh = model.SinhViens.Where(e => e.IDLop == lop.IDLop).Select(e =>
              new SinhVienVM
              {
                  ID = e.ID,
                  GioiTinh = e.GioiTinh,
                  NgaySinh = e.NgaySinh,
                  NoiSinh = e.NoiSinh,
                  HoDem = e.HoDem,
                  Ten = e.Ten,
                  QueQuan = e.QueQuan
              }).ToList();
            sinhVienVMBindingSource.DataSource = dsHocSinh;
            dataGridView1.DataSource = sinhVienVMBindingSource;
              

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapHocSinh();
        }

        //TODO: ef turorial
    }
}
