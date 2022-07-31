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
    public partial class demo1 : Form
    {

    
        public demo1()
        {
            InitializeComponent();
           // rpb = new frpb();
          
        }

        public void showinfo(int idbill)
        {

            DataTable dt = new DataTable();
            dt = billinfoDAO.Instance.showbillinfo(idbill);

            dataGridView1.DataSource = dt;

        }
        private void demo1_Load(object sender, EventArgs e)
        {

        }

        private void btndone_Click(object sender, EventArgs e)
        {
            Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (dataGridView1.Rows[0].Cells[0].Value == null) {
                    id = 0;
      
                }
                else { id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString()); }
                reshowbill rs = new reshowbill(this);
                rs.setdata(id);
                rs.ShowDialog();
            }
            catch { };
        }
    }
}
