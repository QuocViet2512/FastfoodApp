using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
    public class billDAO
    {
        private static billDAO instance;

        public static billDAO Instance {
            get
            {
                if (instance == null) instance = new billDAO(); return instance;
            }
            private set {
                instance = value;
            }
        }
        private billDAO() { }
        public int getunchekbill(int idtable)
        {
            DataTable data = Dataprovider.Instance.Execquery("SELECT* FROM BILL WHERE IDTABLE = '"+idtable+"' AND BSTATUS = 0");
            if (data.Rows.Count > 0)
            {
                bill bill = new bill(data.Rows[0]);
                return bill.Id;
            }
            else { return -1; }
            
        }
        public void insertbill(int id )
        {
            DataTable data = Dataprovider.Instance.Execquery("EXEC INSERTBILL @IDTABLE ", new object[] { id });
        }
        public void checkout (int id, double discount,double takereal,double total)
        {
            string query = "update bill set bstatus = 1 , discount="+discount+" , takereal="+takereal+" , checkout=getdate() , total="+total+" where id="+id;
            Dataprovider.Instance.Execnonquery(query);
        }
        public DataTable viewincome (DateTime checkin, DateTime checkout)
        {
            return  Dataprovider.Instance.Execquery("EXEC VIEWINCOME @CHECKIN , @CHECKOUT ", new object[] {checkin, checkout });
        }


        //_________________________________________________________________________________________

        public List<billtest> getviewincome1 (DateTime checkin, DateTime checkout)
        {
            List<billtest> listmenu = new List<billtest>();
            DataTable data = Dataprovider.Instance.Execquery("EXEC VIEWINCOME @CHECKIN , @CHECKOUT ", new object[] { checkin, checkout });
            foreach (DataRow item in data.Rows)
            {
                billtest list = new billtest(item);
                listmenu.Add(list);
            }
            return listmenu;
        }
        public List<allbill> getallview()
        {
            List<allbill> list = new List<allbill>();
            DataTable dt = Dataprovider.Instance.Execquery("EXEC GETALLBILLNOCHECK");
            foreach (DataRow item in dt.Rows)
            {
                allbill bill = new allbill(item);
                list.Add(bill);
            }

            return list;
        }
        public List<allbill> getviewid(int idbill)
        {
            List<allbill> list = new List<allbill>();
            DataTable dt = Dataprovider.Instance.Execquery("EXEC GETBILLCHECKID @IDBILL="+idbill);
            foreach (DataRow item in dt.Rows)
            {
                allbill bill = new allbill(item);
                list.Add(bill);
            }

            return list;
        }



        public void updateavail(int idtable)
        {
            Dataprovider.Instance.Execquery("update OTABLE set  TSTATUS = N'Trống'  where ID='" + idtable + "'");
        }
        public void updatehave(int idtable)
        {
            Dataprovider.Instance.Execquery("update OTABLE set  TSTATUS = N'Có người'  where ID='" + idtable + "'");
        }

        private void deletebillmonthother()

        {
            Dataprovider.Instance.Execquery("deletebill");
        }
    }
}
