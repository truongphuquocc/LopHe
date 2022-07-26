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
using System.Xml.Linq;
using HelloForm.Entities;

namespace HelloForm
{
    public partial class frmProfile : Form
    {
        List<SinhVien> sinhVienList = new List<SinhVien>();
        string path = @"SinhVien.txt";
        string fXml = @"../../SinhVien.xml";
        //XDocument xd = XDocument.Load(fXml);'
        private XDocument xd1;

        public frmProfile()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadDataSinhVien();
        }

        private void picAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Chọn ảnh đại diện";
            fileDialog.Filter = "File ảnh |*.jpg;*.png;*.jpeg;*.bmp";
            var rs = fileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picAva.ImageLocation = fileDialog.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = txtMSV.Text,
                HoDem = txtHoDem.Text,
                Ten = txtTen.Text,
                Email = txtEmail.Text,
                GioiTinh = (rdbNam.Checked ? GIOITINH.Nam : rdbNu.Checked ? GIOITINH.Nu : GIOITINH.Khac),
                NgaySinh = dtpNgaySinh.Value,
                QueQuan = txtQueQuan.Text,
                SoDienThoai = txtSDT.Text,
                NoiSinh = txtNoiSinh.Text
            };

            //if (File.Exists(path))
            //{
                string[] lines = System.IO.File.ReadAllLines(@"SinhVien.txt");
                foreach (string line in lines)
                {
                    SinhVien sinhvien = SinhVien.Parse(line);
                    sinhVienList.Add(sinhvien);
                }
            //}

            if ((txtMSV.Text != "" && txtHoDem.Text != "" && txtTen.Text != "" && txtNoiSinh.Text != "" &&
                txtQueQuan.Text != "" && txtSDT.Text != "" && txtEmail.Text != "" &&
                (rdbNam.Checked == true || rdbNu.Checked == true || rdbKhac.Checked == true)) && (isExistId(sinhVienList, txtMSV.Text) == false))
            {
                StreamWriter writer = new StreamWriter("SinhVien.txt", true);
                writer.WriteLine(sv.ToString());
                writer.Close();

                XElement emp = new XElement("SinhVien",
                //new XElement("MaSinhVien", sv.MaSinhVien),
                new XElement("HoDem", sv.HoDem),
                new XElement("Ten", sv.Ten),
                new XElement("NgaySinh", sv.NgaySinh.ToString()),
                new XElement("GioiTinh", sv.GioiTinh.ToString()),
                new XElement("NoiSinh", sv.NoiSinh),
                new XElement("QueQuan", sv.QueQuan),
                new XElement("SoDienThoai", sv.SoDienThoai),
                new XElement("Email", sv.Email)
                );
                emp.SetAttributeValue("MaSinhVien", sv.MaSinhVien);
                xd1.Element("Students").Add(emp);
                xd1.Save(fXml);
                MessageBox.Show("lưu thành công");
            }

            if ((isExistId(sinhVienList, txtMSV.Text) == true))
            {
                MessageBox.Show("Trùng mã sinh viên");
                lbMSV.Visible = true;
            }

            #region validation : data
            if (txtMSV.Text == "" || (isExistId(sinhVienList, txtMSV.Text) == true))
            {
                lbMSV.Visible = true;
                lbTextMSV.Visible = true;
            }

            else if (txtMSV.Text != "")
            {
                lbMSV.Visible = false;
                lbTextMSV.Visible = false;
            }

            if (txtHoDem.Text == "")
            {
                lbHoDem.Visible = true;
                lbTextHoDem.Visible = true;
            }

            else if (txtHoDem.Text != "")
            {
                lbHoDem.Visible = false;
                lbTextHoDem.Visible = false;
            }

            if (txtTen.Text == "")
            {
                lbTen.Visible = true;
                lbTextTen.Visible = true;
            }

            else if (txtTen.Text != "")
            {
                lbTen.Visible = false;
                lbTextTen.Visible = false;
            }

            if (txtNoiSinh.Text == "")
            {
                lbNoiSinh.Visible = true;
                lbTextNoiSinh.Visible = true;
                //return;
            }

            else if (txtNoiSinh.Text != "")
            {
                lbNoiSinh.Visible = false;
                lbTextNoiSinh.Visible = false;
            }

            if (txtQueQuan.Text == "")
            {
                lbQueQuan.Visible = true;
                lbTextQueQuan.Visible = true;
            }

            else if (txtQueQuan.Text != "")
            {
                lbQueQuan.Visible = false;
                lbTextQueQuan.Visible = false;
            }

            if (txtSDT.Text == "")
            {
                lbSDT.Visible = true;
                lbTextSDT.Visible = true;
                //return;
            }

            else if (txtSDT.Text != "")
            {
                lbSDT.Visible = false;
                lbTextSDT.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                lbEmail.Visible = true;
                lbTextEmail.Visible = true;
            }

            else if (txtEmail.Text != "")
            {
                lbEmail.Visible = false;
                lbTextEmail.Visible = false;
            }

            if (rdbNam.Checked == false && rdbNu.Checked == false && rdbKhac.Checked == false)
            {
                lbGioiTinh.Visible = true;
                lbTextGioiTinh.Visible = true;
                //return;
            }

            else if (rdbNam.Checked != false || rdbNu.Checked != false || rdbKhac.Checked != false)
            {
                lbGioiTinh.Visible = false;
                lbTextGioiTinh.Visible = false;
            }
            #endregion
        }

        private void txtMSV_Validating(object sender, CancelEventArgs e)
        {


        }

        private void btnXML_Click(object sender, EventArgs e)
        {

            SinhVien sv = new SinhVien
            {
                MaSinhVien = txtMSV.Text,
                HoDem = txtHoDem.Text,
                Ten = txtTen.Text,
                Email = txtEmail.Text,
                GioiTinh = (rdbNam.Checked ? GIOITINH.Nam : rdbNu.Checked ? GIOITINH.Nu : GIOITINH.Khac),
                NgaySinh = dtpNgaySinh.Value,
                QueQuan = txtQueQuan.Text,
                SoDienThoai = txtSDT.Text,
                NoiSinh = txtNoiSinh.Text
            };

            XElement emp = new XElement("SinhVien",
                //new XElement("MaSinhVien", sv.MaSinhVien),
                new XElement("HoDem", sv.HoDem),
                new XElement("Ten", sv.Ten),
                new XElement("NgaySinh", sv.NgaySinh.ToString()),
                new XElement("GioiTinh", sv.GioiTinh.ToString()),
                new XElement("NoiSinh", sv.NoiSinh),
                new XElement("QueQuan", sv.QueQuan),
                new XElement("SoDienThoai", sv.SoDienThoai),
                new XElement("Email", sv.Email)
                );
            emp.SetAttributeValue("MaSinhVien", sv.MaSinhVien);
            xd1.Element("Students").Add(emp);
            xd1.Save(fXml);
        }

        /// <summary>
        /// Kiểm tra msv có tồn tại hay không
        /// </summary>
        /// <param name="svlist"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool isExistId(List<SinhVien> svlist, string ID)
        {
            foreach (SinhVien sv2 in svlist)
            {
                string tempSv = sv2.MaSinhVien;
                if (tempSv.ToLower() == ID.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public void LoadDataSinhVien()
        {
            //System.Data.DataSet sv = new DataSet();
            //sv.ReadXml(fXml);
            xd1 = XDocument.Load(fXml);
            var data = xd1.Descendants("Employee").Select(p => new
            {
                //MaSinhVien = p.Element("MaSinhVien").Value,
                HoDem = p.Element("HoDem").Value,
                Ten = p.Element("Ten").Value,
                NgaySinh = p.Element("NgaySinh").Value,
                GioiTinh = p.Element("GioiTinh").Value,
                NoiSinh = p.Element("NoiSinh").Value,
                QueQuan = p.Element("QueQuan").Value,
                SoDienThoai = p.Element("SoDienThoai").Value,
                Email = p.Element("Email").Value,
            }).ToList();
        }
    }
}

