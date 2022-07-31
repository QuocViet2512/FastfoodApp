using QuanLyNhaHangQuanAn.models;
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
    public partial class RESOURCES : Form
    {
        models.entityedit enti;
        public RESOURCES()
        {
            InitializeComponent();
            enti = new models.entityedit();
            loadtest();
        }



        private void loadtest()
        {

        }
        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }
    }
}
