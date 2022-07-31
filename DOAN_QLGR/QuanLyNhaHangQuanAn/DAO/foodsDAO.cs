using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangQuanAn.DAO
{
    public class foodsDAO
    {
        private static foodsDAO instance;

        public static foodsDAO Instance {
            get { if(instance == null)instance = new foodsDAO(); return instance; }
            private set { instance = value; }
        }
        private foodsDAO() { }
        public List<foods> getlistfood()
        {
           List< foods> fs = new List<foods>();

            string query = "select * from foods ";//where"; //idtype="+id;
            DataTable data = Dataprovider.Instance.Execquery(query);
            foreach (DataRow item in data.Rows)
            {
                foods f = new foods(item);
                fs.Add(f);
            }
            return fs;
        }
        public List<foods> getlistbytype(int id)
        {
            List<foods> fsid = new List<foods>();
            string query = "select* from foods where idtype=" + id;
            DataTable dt = Dataprovider.Instance.Execquery(query);
          
            foreach (DataRow item in dt.Rows)
            {
                foods f = new foods(item);
                fsid.Add(f);
                
            }
            return fsid;
        }
        public List<foods> getlistfoodtofind(string qr)
        {
            List<foods> fs = new List<foods>();

            string query = "select * from foods where "+qr; //idtype="+id;
            DataTable data = Dataprovider.Instance.Execquery(query);
            foreach (DataRow item in data.Rows)
            {
                foods f = new foods(item);
                fs.Add(f);
            }
            return fs;
        }
        public List<getfoods> getfoods()
        {
            List<getfoods> gt = new List<getfoods>();
            string qr = "exec getfoods ";
            DataTable dt = Dataprovider.Instance.Execquery(qr);
            foreach (DataRow item in dt.Rows)
            {
                getfoods gf = new getfoods(item);
                gt.Add(gf);
            }
            return gt;
        }

    }
}
