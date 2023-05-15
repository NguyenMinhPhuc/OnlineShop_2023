namespace OnlineShop.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHienThi { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTaiKhoan { get; set; }

        public byte[] MatKhau { get; set; }
    }
}
