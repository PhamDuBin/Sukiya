namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichLamViec")]
    public partial class LichLamViec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichLamViec()
        {
            CT_LichLam = new HashSet<CT_LichLam>();
        }

        [Key]
        [Column(TypeName = "date")]
        public DateTime NgayLam { get; set; }

        [Required]
        [StringLength(10)]
        public string Thu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_LichLam> CT_LichLam { get; set; }
    }
}
