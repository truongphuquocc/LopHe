using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloForm.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class SinhVien
    {
        public string MaSinhVien { get; set; }

        public string HoDem { get; set; }

        public string Ten { get; set; }

        public string HoVaTen
        {
            get
            {
                return $"{HoDem} {Ten}";
            }
        }

        public DateTime NgaySinh { get; set; }

        public int Tuoi
        {
            get
            {
                var a = (DateTime.Today.Year * 100 + DateTime.Today.Month) * 100 + DateTime.Today.Day;
                var b = (NgaySinh.Year * 100 + NgaySinh.Month) * 100 + NgaySinh.Day;
                return (a - b) / 10000;
            }
        }

        public String NoiSinh { get; set; }

        public GIOITINH GioiTinh { get; set; }

        public String QueQuan { get; set; }

        public String SoDienThoai { get; set; }

        public String Email { get; set; }

        public SinhVien()
        {

        }

        public override string ToString()
        {
            return $"{MaSinhVien}|{HoDem}|{Ten}|{NgaySinh}|{NoiSinh}|{GioiTinh}|{QueQuan}|{SoDienThoai}|{Email}";
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
                NgaySinh = Convert.ToDateTime(rs[3]),
                NoiSinh = rs[4],
                GioiTinh = (rs[5] == "Nam" ? GIOITINH.Nam : rs[5] == "Nu" ? GIOITINH.Nu : GIOITINH.Khac),
                QueQuan = rs[6],
                SoDienThoai = rs[7],
                Email = rs[8]
            };
            return sv;
        }
    }

    public enum GIOITINH
    {
        Nam, Nu, Khac
    }

}
