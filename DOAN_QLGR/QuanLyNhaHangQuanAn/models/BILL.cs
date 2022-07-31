namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILL")]
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            BILLINFOes = new HashSet<BILLINFO>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CHECKIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CHECKOUT { get; set; }

        public int IDTABLE { get; set; }

        public double? DISCOUNT { get; set; }

        public double? TAKEREAL { get; set; }

        public double? TOTAL { get; set; }

        public bool BSTATUS { get; set; }

        public virtual OTABLE OTABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }
    }
}
