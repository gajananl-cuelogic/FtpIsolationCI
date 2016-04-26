namespace FtpWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Device()
        {
            Tbl_ScreenshotDetails = new HashSet<Tbl_ScreenshotDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(250)]
        public string DeviceId { get; set; }

        [StringLength(250)]
        public string DeviceName { get; set; }

        public string DeviceStatus { get; set; }

        [StringLength(50)]
        public string DeviceIp { get; set; }

        public int? ScreenShotInterval { get; set; }

        public bool? IsShutdownDevice { get; set; }

        public bool? IsPause { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreatedDatetime { get; set; }

        public DateTime? UpdatedDatetime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ScreenshotDetails> Tbl_ScreenshotDetails { get; set; }
    }
}
