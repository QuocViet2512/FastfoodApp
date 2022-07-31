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
    public partial class Help : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Help()
        {
            InitializeComponent();
        }



        private void btnGT_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\gioithieu.chm");
        }

        private void btnKQCN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\khaiquatcn.chm");
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\dangnhap.chm");
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\datban.chm");
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\datmon.chm");
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\doanhthu.chm");
        }

        private void btnTVAD_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\help.chm");
        }

        private void btnTDTT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "File:E:\\DOAN_QLGR\\QuanLyNhaHangQuanAn\\help\\thhaydoitt.chm");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
