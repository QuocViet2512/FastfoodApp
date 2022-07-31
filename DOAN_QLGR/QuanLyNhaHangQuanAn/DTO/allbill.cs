using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class allbill
    {

        public int Id { get { return idbill; } set { idbill = value; } }
        public DateTime? Checkin { get { return checkin; } set { checkin = value; } }
        public DateTime? Checkout { get { return checkout; } set { checkout = value; } }
        public bool Bstatus { get { return bstatus; } set { bstatus = value; } }
       // public int Idtable { get => idtable; set => idtable = value; }
        public double Discount { get => discount; set => discount = value; }
        public double Takereal { get => takereal; set => takereal = value; }
        public double Total { get => total; set => total = value; }
        public string Tablenumber { get => tablenumber; set => tablenumber = value; }

        private int idbill;
        private DateTime? checkin;
        private DateTime? checkout;
        string tablenumber;
        //private int idtable;
        private bool bstatus;
        private double discount;
        private double takereal;
        private double total;
        public allbill(int id, DateTime? checkin, DateTime? checkout, string tablenumber, bool bstatus, double discont = 0, double takereal = 0, double total = 0)
        {
            this.Id = id;
            this.Checkin = checkin;
            this.Checkout = checkout;
           // this.Idtable = idtable;
            this.Bstatus = bstatus;
            this.Discount = discont;
            this.Takereal = takereal;
            this.Total = total;
            this.Tablenumber = tablenumber;


        }
        public allbill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Checkin = (DateTime?)row["checkin"];
            //this.Checkout = (DateTime?)row["checkout"];
            var check = row["checkout"];
            if (check.ToString() != "") { this.Checkout = (DateTime?)check; }
          // this.Tablenumber = row["idtable"].ToString();
            //this.Bstatus = (bool)row["bstatus"];
            this.Discount = Convert.ToDouble(row["discount"]);
            this.Takereal = Convert.ToDouble(row["takereal"]);
            this.Total = Convert.ToDouble(row["total"]);
            this.Tablenumber = row["tablenumber"].ToString();
        }
    }

}
