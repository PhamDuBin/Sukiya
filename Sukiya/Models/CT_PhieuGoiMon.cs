namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PhieuGoiMon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPGM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMon { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string Size { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte SoLuong { get; set; }

        public virtual Mon Mon { get; set; }

        public virtual PhieuGoiMon PhieuGoiMon { get; set; }
    }
}
