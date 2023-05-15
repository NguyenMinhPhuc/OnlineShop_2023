namespace OnlineShop.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuDe")]
    public partial class ChuDe
    {
        [Key]
        public int MaChuDe { get; set; }

        [Required]
        [StringLength(250)]
        public string TenChuDe { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public bool IsDelete { get; set; }
    }
}
