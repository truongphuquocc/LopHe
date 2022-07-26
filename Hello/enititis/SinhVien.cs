using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.enititis
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }

        public string HoDem { get; set; }

        public string Ten { get; set; }

        public DateTime NgaySinh { get; set; }

        public String NoiSinh { get; set; }

        public GIOITINH GioiTinh { get; set; }

        public String QueQuan { get; set; }

        public String SoDienThoai { get; set; }

        public String Email { get; set; }

        public override string ToString()
        {
            return $"{MaSinhVien}|{HoDem}|{Ten}|{Email}|{GioiTinh}|{NgaySinh}|{QueQuan}|{NoiSinh}|{SoDienThoai}";
        }

        // TODO: Validation data
        // TODO: Check exist data
        // TODO: save data format XML

        public static SinhVien Parse(string str)
        {
            var rs = str.Split(new char[] { '|' });
            SinhVien sv = new SinhVien
            {
                MaSinhVien = rs[0],
                HoDem = rs[1],
                Ten = rs[2],
                NgaySinh = Convert.ToDateTime(rs[5]),
                NoiSinh = rs[6],
                GioiTinh = (rs[4] == "Nam" ? GIOITINH.Nam : rs[4] == "Nu" ? GIOITINH.Nu : GIOITINH.Khac),
                QueQuan = rs[7],
                SoDienThoai = rs[8],
                Email = rs[3]
            };
            return sv;
        }
    }

    public enum GIOITINH
    {
        Nam, Nu, Khac
    }
}
