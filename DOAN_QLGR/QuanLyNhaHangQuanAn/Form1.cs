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
    public partial class frmdiscount : Form
    {
        public frmdiscount()
        {
            InitializeComponent();
            //getdiscount();


        }
        public double getdiscount()
        {
            return  Convert.ToDouble(nbudcount.Value.ToString());
          
        }
        private void btndone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
