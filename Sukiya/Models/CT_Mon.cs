namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_Mon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNVL { get; set; }

        public double LieuLuong { get; set; }

        [Required]
        [StringLength(40)]
        public string CachLam { get; set; }

        public virtual Mon Mon { get; set; }

        public virtual NguyenVatLieu NguyenVatLieu { get; set; }
    }
}
