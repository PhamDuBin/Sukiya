namespace Sukiya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguyenVatLieu")]
    public partial class NguyenVatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguyenVatLieu()
        {
            CT_Mon = new HashSet<CT_Mon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNVL { get; set; }

        [Required]
        [StringLength(20)]
        public string TenNVL { get; set; }

        public int DVT { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        public int SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_Mon> CT_Mon { get; set; }
    }
}
