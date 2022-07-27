using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienProject.ViewModel
{
    public class SinhVienVM
    {
        public string ID { get; set; }

        public string HoDem { get; set; }

        public string Ten { get; set; }

        public string HovaTen
        {
            get
            {
                return $"{HoDem} {Ten}";
            }
        }

        public DateTime? NgaySinh { get; set; }

        public byte? GioiTinh { get; set; }

        public string GioiTinhStr
        {
            get
            {
                switch(GioiTinh)
                {
                    case 0:
                        return "Nam";
                    case 1:
                        return "Nu";
                    default:
                        return "Khac";
                }    
            }
        }

        public string NoiSinh { get; set; }

        public string QueQuan { get; set; }

    }
}
