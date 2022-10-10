namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuTraLuong")]
    public partial class PhieuTraLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPTL { get; set; }

        public int MaBangChamCong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienPhuCap { get; set; }

        public int TongGioLam { get; set; }

        [Column(TypeName = "money")]
        public decimal TienLuong { get; set; }

        public virtual BangChamCong BangChamCong { get; set; }
    }
}
