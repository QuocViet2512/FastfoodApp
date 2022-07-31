using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangQuanAn.DTO
{
    public class account
    {
        private string displayname;
        private string username;
        private string password;
        private int position;
        private string accountype;

        public string Displayname { get => displayname; set => displayname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Position { get => position; set => position = value; }
        public string Accountype { get => accountype; set => accountype = value; }

        public account(string displayname , string username,string pasword,int position,string accounttype)
        {
            this.Displayname = displayname;
            this.Username = username;
            this.Password = pasword;
            this.Position = position;
            this.Accountype = accounttype;
        }
        public account(DataRow row)
        {
            this.Displayname = row["displayname"].ToString();
            this.Username = row["username"].ToString();
            this.Password = row["upassword"].ToString();
            this.Position = (int)row["position"];
            this.Accountype = row["accounttype"].ToString();
        }
    }
}
