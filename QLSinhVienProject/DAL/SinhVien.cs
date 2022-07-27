namespace QLSinhVienProject.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string MaSinhVien { get; set; }

        [Required]
        [StringLength(20)]
        public string HoDem { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(250)]
        public string NoiSinh { get; set; }

        public byte? GioiTinh { get; set; }

        public long? IDLop { get; set; }

        public string QueQuan { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
