using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DAO
{
    public  class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }
       public bool login(string username, string password)
        {
            string query = "LOGIN @USERNAME , @UPASSWORD";
            DataTable result = Dataprovider.Instance.Execquery(query,new object[]{username, password });
            return result.Rows.Count> 0;
        }

        public account getaccount(string username)
        {
         DataTable dt = Dataprovider.Instance.Execquery("select displayname, username , UPASSWORD,ACCOUNTTYPE.POSITION ,ACCOUNTTYPE.ACCOUNTTYPE from ACCOUNT,ACCOUNTTYPE where ACCOUNT.POSITION=ACCOUNTTYPE.POSITION AND USERNAME ='"+username+"'");
            foreach(DataRow item in dt.Rows)
            {
                return new account(item);
            }
            return null;
        }
        public bool  changeacc(string username , string displayname , string upassword ,string newpassword)
        {
           int resuls =  Dataprovider.Instance.Execnonquery("EXEC UPDATEACCOUNT @USERNAME , @DISPLAYNAME , @UPASSWORD , @NEWPASSWORD", new object[] { username, displayname, upassword, newpassword}    );
            return resuls>0;
        }
    }
}
