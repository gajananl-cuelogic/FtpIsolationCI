namespace FtpWebApplication
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Tbl_Device> Tbl_Device { get; set; }
        public virtual DbSet<Tbl_ScreenshotDetails> Tbl_ScreenshotDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_Device>()
                .Property(e => e.DeviceIp)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Device>()
                .HasMany(e => e.Tbl_ScreenshotDetails)
                .WithOptional(e => e.Tbl_Device)
                .HasForeignKey(e => e.Fk_DeviceId);
        }
    }
}
