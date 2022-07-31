using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class billtest
    {
    
        public DateTime? Checkin { get { return checkin; } set { checkin = value; } }
        public DateTime? Checkout { get { return checkout; } set { checkout = value; } }
        public double Discount { get => discount; set => discount = value; }
        public double Takereal { get => takereal; set => takereal = value; }
        public double Total { get => total; set => total = value; }
        public string Tablename { get => tablename; set => tablename = value; }
        public int Idbill { get => idbill; set => idbill = value; }

        private string tablename;
        private DateTime? checkin;
        private DateTime? checkout;
        private double discount;
        private double takereal;
        private double total;
        private int idbill;
        public billtest(string tablename , DateTime? checkin, DateTime? checkout, int idtable, bool bstatus, double discont = 0, double takereal = 0, double total = 0, int idbill=0)
        {
            this.Tablename = tablename;
            this.Checkin = checkin;
            this.Checkout = checkout;
            this.Discount = discont;
            this.Takereal = takereal;
            this.Total = total;
            this.Idbill = idbill;


        }
        public billtest(DataRow row)
        {
            this.Tablename = row["tablenumber"].ToString();
            this.Checkin = (DateTime?)row["checkin"];
            //this.Checkout = (DateTime?)row["checkout"];
            var check = row["checkout"];
            if (check.ToString() != "") { this.Checkout = (DateTime?)check; }
            this.Idbill = (int)row["id"];
            this.Discount = Convert.ToDouble(row["discount"]);
            this.Takereal = Convert.ToDouble(row["takereal"]);
            this.Total = Convert.ToDouble(row["total"]);
        }
    }

}
