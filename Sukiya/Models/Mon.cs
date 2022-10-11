namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mon")]
    public partial class Mon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mon()
        {
            CT_Mon = new HashSet<CT_Mon>();
            CT_PhieuGoiMon = new HashSet<CT_PhieuGoiMon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMon { get; set; }

        public int MaLM { get; set; }

        [Required]
        [StringLength(30)]
        public string TenMon { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        [Required]
        [StringLength(1)]
        public string Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Mon> CT_Mon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuGoiMon> CT_PhieuGoiMon { get; set; }

        public virtual LoaiMon LoaiMon { get; set; }
    }
}
