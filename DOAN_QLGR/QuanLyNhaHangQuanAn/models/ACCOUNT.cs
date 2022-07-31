namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(30)]
        public string DISPLAYNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string UPASSWORD { get; set; }

        public int POSITION { get; set; }

        public virtual ACCOUNTTYPE ACCOUNTTYPE { get; set; }
    }
}
