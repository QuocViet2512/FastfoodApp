using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
    class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        {
            get
            {
                if (instance == null)instance= new TableDAO(); return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public static int width = 130;
        public static int height = 130;
        private TableDAO() { }
        public List<table> loadtable()
        {
            List<table> list = new List<table>();
            DataTable data = Dataprovider.Instance.Execquery("DBO.GETTABLE");
            foreach (DataRow item in data.Rows)
            {
                table table = new table(item);
                list.Add(table);
            }
       
            return list;
        }
    }
}
