namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESOURCES")]
    public partial class RESOURCE
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string RESOURCESNAME { get; set; }

        public int RESOURCESTYPEID { get; set; }

        public int RESOURCESAMOUNT { get; set; }

        public virtual RESOURCESTYPE RESOURCESTYPE { get; set; }
    }
}
