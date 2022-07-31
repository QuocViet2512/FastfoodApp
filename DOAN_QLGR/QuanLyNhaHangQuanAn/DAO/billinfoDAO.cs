using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
    public class billinfoDAO
    {
        private static billinfoDAO instance;

        public static billinfoDAO Instance {
            get
            {
                if (instance == null) instance = new billinfoDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public billinfoDAO() { }
        public List<billinfo> GetBillinfo(int id)
        {
            List<billinfo> listbillinfo = new List<billinfo>();
            DataTable data = Dataprovider.Instance.Execquery("SELECT* FROM BILLINFO WHERE IDBILL = " + id + "");
            foreach (DataRow item in data.Rows)
            {
                billinfo info = new billinfo();
                listbillinfo.Add(info);
            }

            return listbillinfo;
        }
        public void insertbillinfo(int idbill, int idfoods, int amount)
        {
            DataTable data = Dataprovider.Instance.Execquery("EXEC INSERTBILLINFO @IDBILL , @IDFOODS , @AMOUNT ", new object[] { idbill, idfoods, amount });
        }
        public int getmax()
        {
            try
            {
                return (int)Dataprovider.Instance.Execscalar("select max(id)from bill");
            }
            catch
            {
                return 1;
            }
        }
        public DataTable showbillinfo(int idbill)
        {

            return Dataprovider.Instance.Execquery("EXEC TEST @IDBILL=" + idbill);
        }
        public DataTable rpbill(int idbill)
        {

            return Dataprovider.Instance.Execquery("exec BILLVIEW @idbill=" + idbill);
        }
        public void deletebillifmonthother (int IDBILL){
            Dataprovider.Instance.Execnonquery("EXEC deletebillif @IDBILL="+IDBILL);
            }
    }
}
