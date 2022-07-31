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
    public partial class frmAccountProfile : Form
    {
        private account login;

        public account Login { get { return login; } set { login = value; changeacc(login); }  }





    public frmAccountProfile(account acc)
        {
            InitializeComponent();
            this.Login  = acc;
           
        }

        private void changeacc(account acc)
        {
            txbDisPlayName.Text = Login.Displayname;
            txbUserName.Text = Login.Username;
           
           // txbPassWord.Text = Login.Password;
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNewPass_TextChanged(object sender, EventArgs e)
        {
            //changeacc(account acc);
           
        }
        private void txbReEnterPass_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txbReEnterPass.Text, txbNewPass.Text, true) == 0)
            {
                lblcheck.Text = "OK";
                lblcheck.ForeColor = Color.Green;
            }
            else
            {
                lblcheck.Text = "X";
                lblcheck.ForeColor = Color.Red;
            }
        }

        private void updateacc()
        {
            string username = txbUserName.Text;
            string displayname = txbDisPlayName.Text;
            string newpassword = txbNewPass.Text;
            string pasword = txbPassWord.Text;
            string reenter = txbReEnterPass.Text;
            if (!newpassword.Equals(reenter)) { MessageBox.Show("Thông báo","Nhập lại mật khẩu phải trùng với mật khẩu mới"); }
            else
            {
                if (AccountDAO.Instance.changeacc(username, displayname, pasword, newpassword))
                {
                    MessageBox.Show( "Cập nhật thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (updatedone != null) { updatedone(this, new accountevent(AccountDAO.Instance.getaccount(username))); }
                    notifyIcon1.Dispose();
                }
                else
                {
                    MessageBox.Show( "Cập nhật thất bại \nVui lòng xem lại thông tin", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
        private event EventHandler<accountevent> updatedone;
        public event EventHandler<accountevent> Updatedone
        {
            add { updatedone += value; }
            remove { updatedone -= value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateacc();
            txbNewPass.ResetText();
            txbPassWord.ResetText();
            txbReEnterPass.ResetText();

        }

        private void txbDisPlayName_TextChanged(object sender, EventArgs e)
        {
            if (txbDisPlayName.Text.Length <= 30)
            {
                lblchecklengh.Text = "OK";
                lblchecklengh.ForeColor = Color.Green;
            }
            else
            {
                lblchecklengh.Text = "Qúa dài";
                lblchecklengh.ForeColor = Color.Red;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        public class accountevent : EventArgs
        {
            private account acc;
            public account Acc { get => acc; set => acc = value; }
            public accountevent(account acc)
            {
                this.Acc = acc;
            }
        }
    }
}
