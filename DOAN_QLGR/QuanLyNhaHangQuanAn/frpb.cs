using CrystalDecisions.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLyNhaHangQuanAn.DAO;
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
    public partial class frpb : Form
    {
        frmOder oder;
        public frpb(frmOder rp)
        {
            InitializeComponent();
            oder = rp;
        }
       // public frpb() { } 
       
        public void setdata(int id)
        {
            DataTable dt = new DataTable();
            CrystalReport3 report2 = new CrystalReport3();
            dt = billinfoDAO.Instance.rpbill(id);
            report2.SetDataSource(dt);
            crystalReportViewer1.ReportSource=report2;
        }

        private void btndone_Click_1(object sender, EventArgs e)
        {
            this.Close();
            oder.Close();
        }

        private void btnprintbill_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void btnexport_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.ExportReport();
        }

    }
}
