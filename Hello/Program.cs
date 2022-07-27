using Hello.enititis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //string textFile = @"SinhVien.txt";
            List<SinhVien> sinhVienList = new List<SinhVien>();

            string[] lines = System.IO.File.ReadAllLines(@"SinhVien.txt");
            foreach (string line in lines)
            {
                SinhVien sinhvien = SinhVien.Parse(line);
                sinhVienList.Add(sinhvien);

            }

            Console.WriteLine(" So luong phan tu trong List la: {0}", sinhVienList.Count);
            System.Console.ReadKey();

        }
    }
}
