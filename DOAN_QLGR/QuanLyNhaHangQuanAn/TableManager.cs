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
using static QuanLyNhaHangQuanAn.frmAccountProfile;

namespace QuanLyNhaHangQuanAn
{
    public partial class frmTableManager : Form
    {
        private account login;

        public account Login { get { return login; } set { login = value; setnulladmin(Login.Position); } }

        //public account Login { get { return login; } set { login = value; setnulladmin(Login.Position); } }

        public frmTableManager(account acc)
        {
            InitializeComponent();
            this.Login = acc;
            loadtable();

            // this.Enabled = false;
        }

        void setnulladmin(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            quảnLíNhậpToolStripMenuItem.Enabled = type == 1;
            lbluser.Text = Login.Displayname+"  ("+Login.Accountype+")  ";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile(Login);
            f.Updatedone += F_Updatedone;
            f.ShowDialog();
        }

        private void F_Updatedone(object sender, accountevent e)
        {
            lbluser.Text = e.Acc.Displayname + "  (" + Login.Accountype + ")  ";
            //throw new NotImplementedException();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin(this );
            f.ShowDialog();
        }
        public void loadtable()
        {
            fnpotable.Controls.Clear();
           List<table> tablelist= TableDAO.Instance.loadtable();

            //---------------------------------------------------------
            foreach (table item in tablelist)
            {
                Button bt = new Button();
                {
                    bt.Width = TableDAO.width;
                    bt.Height = TableDAO.height;
                    fnpotable.Controls.Add(bt);
                    bt.Text = item.Tablenumber + Environment.NewLine + item.Status;
                    if(item.Status.Equals("Trống"))
                    {
                        bt.BackColor = Color.DodgerBlue;
                    }
                    else
                    {

                        bt.BackColor = Color.Gray;
                    }
                
                }
                bt.Click += bt_Click;
                bt.Tag = item;

            }

        }

        //public frmTableManager frm;
        private void bt_Click(object sender, EventArgs e)
        {
          int idtable = ((sender as Button).Tag as table).Id;
            frmOder n = new frmOder(this);
            n.ltvlistoder.Tag = (sender as Button).Tag;
            n.showbill(idtable);
            n.ShowDialog();
         
            
        }

        private void nhậpNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //int count = 1;
        //string a;
        //int len =0 ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbluser.Text.Length > 20)
            {
                  lbluser.Text = lbluser.Text.Substring(1, lbluser.Text.Length - 1)  + lbluser.Text.Substring(0, 1);
                //lbluser.Text =  lbluser.Text.Substring( 1,lbluser.Text.Length - 1)+ lbluser.Text.Substring( lbluser.Text.Length - 1,1) ;
            }
            lbltimemove.Text = System.DateTime.Now.ToLongTimeString();
            //if (count > len)
            //{
            //    count = 0;

            //}
            //lbluser.Text = a.Substring(0, count);

        }

        private void frmTableManager_Load(object sender, EventArgs e)
        {
           //a= lbluser.Text;
           // len =a.Length;
        }

        private void phiênBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update update = new update();
            update.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contact contact = new contact();
            contact.ShowDialog();
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus us = new aboutus();
            us.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void quảnLíNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RESOURCES rs = new RESOURCES();
            rs.ShowDialog();
        }

        //private void frmTableManager_Load(object sender, EventArgs e)
        //{
        //    loadtable();
        //}
    }
}
