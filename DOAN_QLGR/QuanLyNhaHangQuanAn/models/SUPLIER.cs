namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUPLIERS")]
    public partial class SUPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPLIER()
        {
            RESOURCESTYPEs = new HashSet<RESOURCESTYPE>();
        }

        [Key]
        [StringLength(10)]
        public string SUPLIERSID { get; set; }

        [Required]
        [StringLength(50)]
        public string SUPLIERSNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string PHONENUMBER { get; set; }

        [Required]
        [StringLength(50)]
        public string SUPLIERSADDRESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESOURCESTYPE> RESOURCESTYPEs { get; set; }
    }
}
