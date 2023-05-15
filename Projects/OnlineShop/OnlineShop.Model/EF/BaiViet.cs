namespace OnlineShop.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBaiViet { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDungBaiViet { get; set; }

        public int MaChuDe { get; set; }

        public bool IsDelete { get; set; }
    }
}
