using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
   public  class getfoods
    {
        private int idfoods;
        private string foodsname;
        private byte[] foodimage;
        private string foodstype;
        private double foodsprice;

        public int Idfoods { get => idfoods; set => idfoods = value; }
        public string Foodsname { get => foodsname; set => foodsname = value; }
        public byte[] Foodimage { get => foodimage; set => foodimage = value; }
        public string Foodstype { get => foodstype; set => foodstype = value; }
        public double Foodsprice { get => foodsprice; set => foodsprice = value; }

        public getfoods(int idfoods,string foodsname , byte[] foodimge,string foodstype,double foodsprice)
        {
            this.Idfoods = idfoods;
            this.Foodsname = foodsname;
            this.Foodimage = foodimge;
            this.Foodstype = foodstype;
            this.Foodsprice = foodsprice;

        }
        public getfoods(DataRow row)
        {
            this.Idfoods = (int)row["id"];
            this.Foodsname =row ["foodsname"].ToString();
            this.Foodimage = (byte[])row["foodimage"];
            this.Foodstype = row["typename"].ToString();
            this.Foodsprice =Convert.ToDouble(row["foodsprice"]);
        }
    }
}
