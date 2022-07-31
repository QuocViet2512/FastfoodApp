using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class foods
    {


        public foods(int id,string foodsname,int idtype,double foodsprice,byte[] image)
        {
            this.Id = id;
            this.Foodsname = foodsname;
            this.Idtype = idtype;
            this.Foodsprice = foodsprice;
            this.Image = image;
        }
        public foods (DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Foodsname = row["foodsname"].ToString();
            this.Idtype = (int)row["idtype"];
            this.Foodsprice = (double)Convert.ToDouble( row["FOODSPRICE"]);
            this.Image = (byte[])row["FOODIMAGE"];
        }

        private byte[] image;
        private int id;
        private string foodsname;
        private int idtype;
        private double foodsprice;

        public int Id { get => id; set => id = value; }
        public string Foodsname { get => foodsname; set => foodsname = value; }
        public int Idtype { get => idtype; set => idtype = value; }
        public double Foodsprice { get => foodsprice; set => foodsprice = value; }
        public byte[] Image { get => image; set => image = value; }
     
    }
}
