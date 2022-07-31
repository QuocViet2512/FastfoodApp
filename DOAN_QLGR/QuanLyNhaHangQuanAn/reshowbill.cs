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
    public partial class reshowbill : Form
    {
        demo1 billif;
        public reshowbill(demo1 rp)
        {
            InitializeComponent();
            billif = rp;
        }
        public void setdata(int id)
        {
            DataTable dt = new DataTable();
            CrystalReport3 report2 = new CrystalReport3();
            dt = billinfoDAO.Instance.rpbill(id);
            report2.SetDataSource(dt);
          
            crtreshow.ReportSource = report2;
            crtreshow.Zoom(90);

        }

        private void btnprintbill_Click(object sender, EventArgs e)
        {

            crtreshow.PrintReport();



            
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            crtreshow.ExportReport();
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            billif.Close();
            this.Close();
        }
    }
}
