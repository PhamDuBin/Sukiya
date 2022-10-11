namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_LichLam
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NgayLam { get; set; }

        public int GioVao { get; set; }

        public int GioRa { get; set; }

        public virtual LichLamViec LichLamViec { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
