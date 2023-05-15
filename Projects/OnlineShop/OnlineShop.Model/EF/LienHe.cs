namespace OnlineShop.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienHe")]
    public partial class LienHe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLienHe { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNguoiLienHe { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        public bool IsDelete { get; set; }
    }
}
