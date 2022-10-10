namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangChamCong")]
    public partial class BangChamCong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangChamCong()
        {
            PhieuTraLuong = new HashSet<PhieuTraLuong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBangChamCong { get; set; }

        public int MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLam { get; set; }

        public TimeSpan GioVaoLam { get; set; }

        public TimeSpan GioTanCa { get; set; }

        [Required]
        [StringLength(1)]
        public string Ca { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongCoBan { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTraLuong> PhieuTraLuong { get; set; }
    }
}
