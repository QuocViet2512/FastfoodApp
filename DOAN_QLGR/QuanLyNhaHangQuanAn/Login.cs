using QuanLyNhaHangQuanAn.DAO;
using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangQuanAn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           // checkacc();


        }
        frmAdmin admin;
        public frmLogin(frmAdmin a)
        {
            InitializeComponent();
            admin = a;
           // checkacc();
            //checkacc();


        }


        private void setnull()
        {
            txbUserName.ResetText();
            txbPassWord.ResetText();
            txbUserName.Focus();
          
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự thoát chương trình?", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        bool login(string username , string password)
        {
            return AccountDAO.Instance.login(username, password);

        }
       // public delegate account saveacc(account a);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;
            if (login(username , password))
            {
                account login = AccountDAO.Instance.getaccount(username);
                frmTableManager f = new frmTableManager(login);
                frmAdmin ad = new frmAdmin(login);
                this.Hide();
                f.ShowDialog();
                this.Show();
              //  checkacc();
              //  setnull();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu\n\t Thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }

        //public bool checkacc()
        //{
        //    bool a=false;

        //    string username = txbUserName.Text;
        //    string password = txbPassWord.Text;
        //    if (login(username, password))
        //    {
        //        if(admin.checkon()==username)
        //        a = true;

        //    }
        //    else { a = false; }

        //    return a;
        //}



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
