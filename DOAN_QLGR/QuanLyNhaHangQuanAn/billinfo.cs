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
    public partial class billinfo : Form
    {
        public billinfo()
        {
            InitializeComponent();
        }

        public void showinfo(int idbill)
        {
           
            //CachedCrystalReportbif rpif = new CachedCrystalReportbif();
            //DataTable dt = new DataTable();
            //dt = billinfoDAO.Instance.showbillinfo(idbill);
            //rpif.Container.Components = dt;
            //crtrpif.ReportSource = rpif;

        }
        private void btnfound_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
