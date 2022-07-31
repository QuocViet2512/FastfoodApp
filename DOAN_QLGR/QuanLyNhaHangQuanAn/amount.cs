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
    public partial class amount : Form
    {
        public amount()
        {
            InitializeComponent();
        }
        public double getamount()
        {
            return Convert.ToDouble(nbudamount.Value.ToString());
            
        }

        private void btnok_Click(object sender, EventArgs e)
        {
           // nbudamount.;
            this.Close();
        }
    }
}
