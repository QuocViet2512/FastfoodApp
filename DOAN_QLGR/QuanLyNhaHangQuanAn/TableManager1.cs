using QuanLyNhaHangQuanAn.DAO;
using QuanLyNhaHangQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Menu = System.Windows.Forms.Menu;

namespace QuanLyNhaHangQuanAn
{
    public partial class frmOder : Form
    {
        ImageList iList = new ImageList();
        private frmTableManager tbl;

        frmdiscount d = new frmdiscount();
        amount m = new amount();

        public frmTableManager Tbl { get { return tbl; } set { tbl = value; } }

        public frmOder(frmTableManager fr)
        {
            InitializeComponent();
            ltvfoodsmenu.View = View.LargeIcon;
            ltvfoodsmenu.LargeImageList = iList;
            iList.ImageSize = new Size(140, 140);
            iList.ColorDepth = ColorDepth.Depth32Bit;

            showmenu();
            loadtype();
            dis();
            setautowr();
            getamount();
            Tbl = fr;

        }

        public void settable()
        {

        }

        public int returnidbill()
        {
            table idtable = ltvlistoder.Tag as table;

             int idbill = billDAO.Instance.getunchekbill(idtable.Id);
            return idbill;
        }


            public void showbill(int idtable)
            {
                txbTotal.ResetText();
                List<QuanLyNhaHangQuanAn.DTO.Menu> listinfo = menuDAO.Instance.getlisttotalfoods(idtable);
                double total = 0;
                ltvlistoder.Items.Clear();
                double discount1 = 0;
                foreach (QuanLyNhaHangQuanAn.DTO.Menu item in listinfo)
                {
                    ListViewItem listview = new ListViewItem(item.Foodsname.ToString());
                    listview.SubItems.Add(item.Amount.ToString());
                    listview.SubItems.Add(item.Price.ToString("#,###"));
                    listview.SubItems.Add(item.Total.ToString("#,###"));
                    listview.SubItems.Add(item.Idfoods.ToString());
                    ltvlistoder.Items.Add(listview);
                    total += item.Total;
                }
                discount1 = total * dis();
                tbxdiscount.Text = (-discount1).ToString("#,###");
                double t = total - discount1;
                txbTotal.Text = t.ToString("#,###");
            }

            public void showmenu()
            {
                int i = 0;
                List<foods> listfoods = foodsDAO.Instance.getlistfood();
                foreach (foods item in listfoods)
                {

                    iList.Images.Add(bytearraytoimage(item.Image));
                    string[] row = { item.Foodsname.ToString(), item.Id.ToString() };
                    ListViewItem lvim = new ListViewItem(row);
                    lvim.ImageIndex = i;
                    ltvfoodsmenu.Items.Add(lvim);
                    i++;
                }
            }


        private void loadtype()
        {
            List<foodstype> ft = typeDAO.Instance.getlistfoodstype();

            cbxfoodstype.DataSource = ft;
            cbxfoodstype.DisplayMember = "Typename";
        }

        private void loadfoodbytype(int id)
        {
            List<foods> fs = foodsDAO.Instance.getlistbytype(id);
        }
        private Image bytearraytoimage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return System.Drawing.Image.FromStream(ms);
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            ltvfoodsmenu.LargeImageList = iList;
            int id = 0;

            foodstype selected = cbxfoodstype.SelectedValue as foodstype;
            if (cbxfoodstype.SelectedItem == null)
            {
                iList.Images.Clear();
                ltvfoodsmenu.Clear();
                showmenu();
            }
            else
            {
                id = selected.Id;
                iList.Images.Clear();
                ltvfoodsmenu.Clear();
                List<foods> listfoods = foodsDAO.Instance.getlistbytype(id);
                int i = 0;

                foreach (foods item in listfoods)
                {

                    iList.Images.Add(bytearraytoimage(item.Image));
                    string[] row = { item.Foodsname.ToString(), item.Id.ToString() };
                    ListViewItem lvim = new ListViewItem(row);
                    lvim.ImageIndex = i;
                    ltvfoodsmenu.Items.Add(lvim);
                    i++;
                }
            }
        }

        private void setautowr()
        {
            List<foods> lfd = foodsDAO.Instance.getlistfood();
            foreach (foods item in lfd)
            {
                txbfoodsname.AutoCompleteCustomSource.Add(item.Foodsname);
            }
        }
        private void txbfoodsname_TextChanged_1(object sender, EventArgs e)
        {


            if (txbfoodsname.Text == "") { iList.Images.Clear(); ltvfoodsmenu.Clear(); showmenu(); lblfindnamefoods.Text = "Tìm kiếm"; }
            else
            {

                lblfindnamefoods.Text = "";
                List<foods> listfoods = foodsDAO.Instance.getlistfood();


                int j = 0;
                ltvfoodsmenu.Clear();
                iList.Images.Clear();

                foreach (foods item in listfoods)
                {
                    if (string.Compare(txbfoodsname.Text, item.Foodsname, false) == 0)
                    {
                        iList.Images.Clear();
                        ltvfoodsmenu.Items.Clear();
                        iList.Images.Add(bytearraytoimage(item.Image));
                        string[] row1 = { item.Foodsname.ToString(), item.Id.ToString() };
                        ListViewItem lvim1 = new ListViewItem(row1, j);
                        ltvfoodsmenu.Items.Add(lvim1);
                        j++;
                    }



                }
            }
        }
        public void insertbill()
        {
            for (int i = 0; i < ltvfoodsmenu.SelectedItems.Count; i++)
            {
                this.ltvlistoder.Items.Add(this.ltvfoodsmenu.SelectedItems[i]);
            }
        }


        private void ltvfoodsmenu_MouseClick(object sender, MouseEventArgs e)
        {

            table idtable = ltvlistoder.Tag as table;//).Id;
            frmdiscount count = new frmdiscount();

            int idbill = billDAO.Instance.getunchekbill(idtable.Id);

            int amount = 0; amount++;
            int idfoods = 0;
            if (ltvfoodsmenu.SelectedItems.Count > 0) { idfoods = (int)Convert.ToInt32(ltvfoodsmenu.SelectedItems[0].SubItems[1].Text); }

            if (ltvfoodsmenu.SelectedItems.Count > 0)
                if (idbill == -1)
                {
                    billDAO.Instance.insertbill(idtable.Id);
                    billinfoDAO.Instance.insertbillinfo(billinfoDAO.Instance.getmax(), idfoods, amount);
                }
                else
                {
                    billinfoDAO.Instance.insertbillinfo(idbill, idfoods, amount);
                }

            showbill(idtable.Id);
        }
        private void btndone_Click(object sender, EventArgs e)
        {
            int idtable = (ltvlistoder.Tag as table).Id;
            checktable(idtable);

            tbl.loadtable();
            this.Close();
        }

        private double dis()
        {
            return (double)d.getdiscount() / 100;
        }

        private void btndiscount_Click(object sender, EventArgs e)
        {

            d.ShowDialog();
            test();
           // int id = (ltvlistoder.Tag as table).Id;
        }

        private int getamount()
        {
            return (int)m.getamount();
        }

        private void test()
        {
            table idtable = ltvlistoder.Tag as table;
            showbill(idtable.Id);
            dis();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {

            table idtable = ltvlistoder.Tag as table;//).Id;
            frmdiscount count = new frmdiscount();
            int idbill = billDAO.Instance.getunchekbill(idtable.Id);

            //int amount = -getamount();
            int idfoods = 0;
            if (ltvlistoder.SelectedItems.Count > 0)
            {
                m.ShowDialog(); idfoods = (int)Convert.ToInt32(ltvlistoder.SelectedItems[0].SubItems[4].Text);
            }
            if (ltvlistoder.SelectedItems.Count > 0)

            {
                billDAO.Instance.insertbill(idtable.Id);
                billinfoDAO.Instance.insertbillinfo(idbill, idfoods, -getamount());
            }

            showbill(idtable.Id);
            int id = (ltvlistoder.Tag as table).Id;

        }

        //--------------------------------------------------------------------------------------------------
        public void checktable(int idtable)
        {

            if (ltvlistoder.Items.Count == 0)
            {
                billDAO.Instance.updateavail(idtable);

            }
            else { billDAO.Instance.updatehave(idtable); }
            Tbl.loadtable();
        }
        //--------------------------------------------------------------------------------------------------
        private void frmOder_Load(object sender, EventArgs e)
        {

        }
        private void btnPay_Click(object sender, EventArgs e)
        {
        
            frpb rp = new frpb(this);
            if (ltvlistoder.Items.Count == 0)
            {
                MessageBox.Show("Không thể thanh toán khi không có món ,vui lòng kiểm tra lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                table idtable = ltvlistoder.Tag as table;
                double discount = 0;
                double takereal = 0; if (txbTotal.Text == "") { takereal = 0; }

                else { takereal = Convert.ToDouble(txbTotal.Text); }

                if (tbxdiscount.Text == "") { discount = 0; } else { discount = Convert.ToDouble(tbxdiscount.Text); }
                double total = -(discount) + takereal;
                int idbill = billDAO.Instance.getunchekbill(idtable.Id);
                if (idbill != 0)
                {
                    billDAO.Instance.checkout(idbill, discount, takereal, total); showbill(idtable.Id);
                    checktable(idtable.Id);
                    Tbl.loadtable();
                    
                    rp.setdata(idbill);
                    rp.Show();

                }


            }

        }

        private void lblfindnamefoods_Click(object sender, EventArgs e)
        {

        }

        private void cbxfoodstype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

