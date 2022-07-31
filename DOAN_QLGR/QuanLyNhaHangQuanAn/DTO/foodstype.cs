using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    class foodstype
    {
        public foodstype(int id , string typename)
        {
            this.Id = id;
            this.Typename = typename;
        }
        public foodstype(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Typename = row["TYPENAME"].ToString();
        }
        private int id;
        private string typename;
        
        public int Id { get => id; set => id = value; }
  
        public string Typename { get => typename; set => typename = value; }
    }

}
