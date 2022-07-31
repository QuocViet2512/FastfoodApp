using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class table
    {
        public table(string tablenumble,string status)
        {
            this.Tablenumber = tablenumber;
            this.Status = status;
            this.Id = id;
        }
        public table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tablenumber = row["TABLENUMBER"].ToString();
            this.Status = row["TSTATUS"].ToString();
        }
        private string tablenumber;

        public string Tablenumber { get => tablenumber; set => tablenumber = value; }
       

        private string status;
        public string Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }

        private int id;
    }
}
