namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILLINFO")]
    public partial class BILLINFO
    {
        public int ID { get; set; }

        public int IDBILL { get; set; }

        [Column(TypeName = "date")]
        public DateTime CHECKDAY { get; set; }

        public int IDFOODS { get; set; }

        public int AMOUNT { get; set; }

        public virtual BILL BILL { get; set; }

        public virtual FOOD FOOD { get; set; }
    }
}
