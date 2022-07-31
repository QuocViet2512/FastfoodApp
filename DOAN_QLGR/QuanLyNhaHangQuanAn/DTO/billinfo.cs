using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class billinfo
    {
        private int id;
        private int idbill;
        private int idfoods;
        private DateTime? checkday;
        private int amount;

        public billinfo(int id, int idbill, int idfoods, DateTime? checkday, int amount)
        {
            this.Id = id;
            this.Idbill = idbill;
            this.Idfoods = idfoods;
            this.Checkday = checkday;
            this.Amount = amount;
        }
        public billinfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Idbill = (int)row["idbill"];
            this.Idfoods = (int)row["idfoods"];
            this.Checkday = (DateTime?)row["checkday"];
            this.Amount = (int)row["amount"];
        }

        public int Id { get { return id; } set { id = value; } }
        public int Idbill { get { return idbill; } set { idbill = value; } }
        public int Idfoods { get { return idfoods; } set { idfoods = value; } }
        public DateTime? Checkday { get { return checkday; } set { checkday = value; } }
        public int Amount { get { return amount; } set {amount = value; } }
    }
}
