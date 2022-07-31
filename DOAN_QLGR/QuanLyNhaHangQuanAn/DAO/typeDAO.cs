using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
    class typeDAO
    {
        private static typeDAO instance;

        internal static typeDAO Instance
        {
            get { if (instance == null) instance = new typeDAO(); return instance; }
            private set { instance = value; }
        }
        private typeDAO() { }
        public List<foodstype> getlistfoodstype()
        {
            List<foodstype> ft = new List<foodstype>();

            DataTable dt = new DataTable();
            string query = "select*from foodstype";
            dt = Dataprovider.Instance.Execquery(query);
            foreach (DataRow item in dt.Rows)
            {
                foodstype ftype = new foodstype(item);
                ft.Add(ftype);
            }
            return ft;
        }
    }
}
