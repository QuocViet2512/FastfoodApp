namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INCOME")]
    public partial class INCOME
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATEINCOM { get; set; }

        public double COLLECT { get; set; }

        public double SPEND { get; set; }

        public double PROFIT { get; set; }
    }
}
