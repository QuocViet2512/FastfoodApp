using DevExpress.ClipboardSource.SpreadsheetML;
using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
    public class menuDAO
    {
        private static menuDAO instance;

        internal static menuDAO Instance
        {
            get { if (instance == null) instance = new menuDAO(); return instance; }
            private set { instance = value; }
        }
        private menuDAO() { }
        public List<Menu> getlisttotalfoods(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            string query = "EXEC GETPRICE @IDTABLE =" + id;
            DataTable data = Dataprovider.Instance.Execquery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu list = new Menu(item);
                listmenu.Add(list);
            }
            return listmenu;
        }
    }
}
