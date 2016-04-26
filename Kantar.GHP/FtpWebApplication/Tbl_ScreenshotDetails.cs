namespace FtpWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_ScreenshotDetails
    {
        public long Id { get; set; }

        [StringLength(250)]
        public string Fk_DeviceId { get; set; }

        [StringLength(500)]
        public string ScreenshotPath { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreatedDatetime { get; set; }

        public virtual Tbl_Device Tbl_Device { get; set; }
    }
}
