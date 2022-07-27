using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSinhVienProject.DAL
{
    public partial class QLSinhVienModel : DbContext
    {
        public QLSinhVienModel()
            : base("name=QLSinhVienModel")
        {
        }

        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
