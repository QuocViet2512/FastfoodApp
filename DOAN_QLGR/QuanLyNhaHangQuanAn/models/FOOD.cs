namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FOODS")]
    public partial class FOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOOD()
        {
            BILLINFOes = new HashSet<BILLINFO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FOODSNAME { get; set; }

        public int IDTYPE { get; set; }

        [Column(TypeName = "money")]
        public decimal FOODSPRICE { get; set; }

        [Column(TypeName = "image")]
        public byte[] FOODIMAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }

        public virtual FOODSTYPE FOODSTYPE { get; set; }
    }
}
