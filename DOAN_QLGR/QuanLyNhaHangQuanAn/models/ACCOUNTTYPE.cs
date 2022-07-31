namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNTTYPE")]
    public partial class ACCOUNTTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNTTYPE()
        {
            ACCOUNTs = new HashSet<ACCOUNT>();
        }

        [Key]
        public int POSITION { get; set; }

        [Column("ACCOUNTTYPE")]
        [Required]
        [StringLength(20)]
        public string ACCOUNTTYPE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNTs { get; set; }
    }
}
