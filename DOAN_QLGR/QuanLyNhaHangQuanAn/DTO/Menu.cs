using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class Menu
    {
        public Menu (int idfoods,string foodsname ,int amount,double price,double total=0)
        {
            Idfoods = idfoods;
            this.Foodsname = foodsname;
            this.Amount = amount;
            this.Price = price;
            this.Total = total;
        }
        public Menu(DataRow row)
        {
          this.Idfoods = (int)row["IDFOODS"];
            this.Foodsname = row["FOODSNAME"].ToString();
            this.Amount = (int)row["AMOUNT"];
            this.Price = (double) Convert.ToDouble( row["FOODSPRICE"].ToString());
            this.Total = (double)Convert.ToDouble( row["TOTAL"].ToString());
        }
       private int idfoods;
        private int amount;
        private double price;
        private string foodsname;
        private double total;

        public int Amount { get => amount; set => amount = value; }
        public double Price { get => price; set => price = value; }
        public string Foodsname { get => foodsname; set => foodsname = value; }
        public double Total { get => total; set => total = value; }
        public int Idfoods { get => idfoods; set => idfoods = value; }
    }
}
