namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESOURCESTYPE")]
    public partial class RESOURCESTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESOURCESTYPE()
        {
            RESOURCES = new HashSet<RESOURCE>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string RESOURCESTYPENAME { get; set; }

        [Required]
        [StringLength(10)]
        public string SUPLIERSID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESOURCE> RESOURCES { get; set; }

        public virtual SUPLIER SUPLIER { get; set; }
    }
}
