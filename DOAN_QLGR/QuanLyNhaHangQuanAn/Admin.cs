using DevExpress.XtraExport.Implementation;
using QuanLyNhaHangQuanAn.DAO;
using QuanLyNhaHangQuanAn.DTO;
using QuanLyNhaHangQuanAn.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace QuanLyNhaHangQuanAn
{
    public partial class frmAdmin : Form
    {
       public  models.entityedit enti;
        private frmTableManager ftb;
        private frmOder bill;
 
        // List<MyPicture>
        public frmAdmin(frmTableManager fr)
        {
            InitializeComponent();
            enti = new models.entityedit();

            //loadfoods();

            Ftb = fr;
            bill = new frmOder(fr);



            //-----income-----


            setvalue();
            getviewincome(dtpkFromDate.Value, dtpkToDate.Value);
           
            //---------------
            //---acc---------
            loadacc();
            setlockbtacc(true);
            setlocktextacc(true);
            loadaccountype();
            setnullacc();
            //------------------
            //-----foodstype----
            loadfoodstype();
            setlockbtfoodtsype(true);
            setlocktextfoodstype(true);
            //------------------
            //-----foods--------
            loadfood();
            loadtypeoffoods();
            setlockbtfoods(true);
            setlocktextfoods(true);
            //------------------
            //------table-------
            loadtstatus();
            loadtable();
            setlockbttable(true);
            setlocktexttable(true);
            setnulltable();
            //------------------



        }
        frmLogin log;
        public frmAdmin(frmLogin A)
        {
            InitializeComponent();
            log = A;
      
        }


        bool newacc  ;
        bool newfoodstype;
        bool newfood;
        bool newtable;

        public frmTableManager Ftb { get => ftb; set => ftb = value; }
        private account login;

       // public account Login { get { return Login1; }  set => Login1 = value; /*checkon(Login);*/  }

        public account Login { get => login; set => login = value;}

        public frmAdmin(account login1)
        {
            InitializeComponent();
            Login = login1;

           
        }


        //----------------------------FOODS------------------------------------------------------------------------------------
        private void setlockbtfoods(bool foods)
        {
            btnAddFood.Enabled = foods;
            btnDeleteFood.Enabled = foods;
            btnEditFood.Enabled = foods;
            btnsavefoods.Enabled = !foods;
            btncancelfoods.Enabled = !foods;
            btnupimagefoods.Enabled = !foods;
        }
        private void setlocktextfoods(bool foods)
        {
            txbFoodID.ReadOnly = foods;
            txbFoodName.ReadOnly = foods;
            cbFoodCategory.Enabled = !foods;
            nmFoodPrice.Enabled = !foods;
            ptrbview.Enabled = !foods;
        }
        private void setnullfoods()
        {
            txbFoodID.Text = "";
            txbFoodName.Text = "";
            cbFoodCategory.Text = "";
            ptrbview.Image = null;
            nmFoodPrice.ResetText();
        }
        private void loadtypeoffoods()
        {
            List<FOODSTYPE> ftp = enti.FOODSTYPEs.ToList();
       
            
                cbFoodCategory.DataSource = ftp;
                cbFoodCategory.DisplayMember = "TYPENAME";
            
            //cbFoodCategory
        }

        private void loadfood()
        {
            ltvfoods.Items.Clear();
            List<FOOD> lfd = enti.FOODS.ToList();
            List<FOODSTYPE> lft = enti.FOODSTYPEs.ToList();
            // DataTable dt = new DataTable();
            ListViewItem fd;
            foreach (FOOD item in lfd)
            {
                foreach (FOODSTYPE item1 in lft)
                {
                    if (item.IDTYPE == item1.ID)
                    {
                        string[] row = { item.ID.ToString(), item.FOODSNAME, ((byte[])item.FOODIMAGE).ToString(), item1.TYPENAME, item.FOODSPRICE.ToString("#,###") };
                        fd = new ListViewItem(row);
                        ltvfoods.Items.Add(fd);
                    }

                }

            }

            //dtgvFood.DataSource = dt;
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            setlockbtfoods(false);
            setlocktextfoods(false);
            txbFoodID.Enabled=false;
            setnullacc();
            newfood = true;
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            List < FOOD > foodlist= enti.FOODS.ToList();
            if (ltvfoods.SelectedItems.Count > 0)
            {
                setlockbtfoods(false);
                setlocktextfoods(false);
                txbFoodID.ReadOnly = true;
               // btnDeleteFood.Enabled = false;
                txbFoodID.Text = ltvfoods.SelectedItems[0].SubItems[0].Text;
                txbFoodName.Text = ltvfoods.SelectedItems[0].SubItems[1].Text;
                cbFoodCategory.Text = ltvfoods.SelectedItems[0].SubItems[3].Text;
                //byte[] img = (byte[]) ltvfoods.SelectedItems[0].SubItems[2].Text;
                ptrbview.Image = ByteToImage(foodlist[ltvfoods.FocusedItem.Index].FOODIMAGE);
                if( ltvfoods.SelectedItems[0].SubItems[4].Text != "")
                {
                    nmFoodPrice.Value = (int)Convert.ToDouble(ltvfoods.SelectedItems[0].SubItems[4].Text);
                }
                else { nmFoodPrice.Value = 0; }
            }
            newfood = false;


        }
        private void toolfoods()
        {
            int idfoods = 0;
            
            List<FOODSTYPE> lft = enti.FOODSTYPEs.ToList();
            FOODSTYPE typeoffood = cbFoodCategory.SelectedValue as FOODSTYPE;
            int foodprice = (int)(Convert.ToDouble(nmFoodPrice.Value));
            FOOD addfood = new FOOD();
            if (newfood == true)
            {
               

                addfood.ID = idfoods;
                addfood.FOODSNAME = txbFoodName.Text;
                addfood.IDTYPE = (typeoffood.ID);
                addfood.FOODIMAGE = convertimgtobyte(ptrbview.Image);
                addfood.FOODSPRICE = foodprice;
                enti.FOODS.Add(addfood);

            }
            else
            {
                int idfoods2 = Convert.ToInt32(txbFoodID.Text);
                FOOD editfoods = enti.FOODS.FirstOrDefault(c => c.ID == idfoods2);
                editfoods.FOODSNAME = txbFoodName.Text;
                editfoods.FOODIMAGE = convertimgtobyte(ptrbview.Image);
                editfoods.IDTYPE = typeoffood.ID;
                editfoods.FOODSPRICE = foodprice;
                //editacc.POSITION = typeacc.POSITION;
            }
        }
        private void btnupimagefoods_Click(object sender, EventArgs e)
        {
            string filename;
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter ="PNG|*.png|JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filename = openFile.FileName;
                    lblfilename.Text = "("+filename+")";
                    ptrbview.Image = Image.FromFile(filename);
                }
            }
        }


        private Image ByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] convertimgtobyte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }

        }




        private void btnsavefoods_Click(object sender, EventArgs e)
        {
            if (txbFoodName.Text == "" || cbFoodCategory.Text == "" || nmFoodPrice.Value==null || ptrbview.Image == null||cbFoodCategory.ValueMember==null)
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                toolfoods();
                enti.SaveChanges();
                setlockbtfoods(true);
                setlocktextfoods(true);
                setnullfoods();
                loadfood();

            }
        }
        bool dlf;

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            
            List<FOOD> lfd = enti.FOODS.ToList();
            List<BILLINFO> lbif = enti.BILLINFOes.ToList();
            List<OTABLE> otb = enti.OTABLEs.ToList();

        
            int idfood = 0;
            if (ltvfoods.SelectedItems.Count > 0)
            {
                idfood = Convert.ToInt32(ltvfoods.SelectedItems[0].SubItems[0].Text);

                MessageBox.Show(idfood.ToString());
                foreach (FOOD item in lfd)
                {

                    if (idfood == item.ID)
                    {
                        DialogResult result = MessageBox.Show("Mọi dữ liệu sẽ mất hoàn toàn sau khi xóa.\nBạn có chắc chắn xóa không ?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            foreach (BILLINFO item1 in lbif)
                            {
                                if (idfood == item1.IDFOODS)
                                {
                                    enti.BILLINFOes.Remove(item1);
                                }
                                dlf = true;
                            }
                            enti.FOODS.Remove(item);


                        }
                        else
                        {
                            if (result == DialogResult.Cancel)
                            {
                                MessageBox.Show("Thao tác đã hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                   


                }
            }
            else { dlf = false; }
            enti.SaveChanges();

            if (dlf == true)
            {
                int idtable = 0;
                foreach (OTABLE item in otb)
                {
                    if (item.TSTATUS.Equals("Có người"))
                    {
                        idtable = item.ID;
                        bill.checktable(idtable);
                    }
                   
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ftb.loadtable();
            }
            else { MessageBox.Show("Lỗi khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            loadfood();

        }

        private void btncancelfoods_Click(object sender, EventArgs e)
        {
            setlockbtfoods(true);
            setlocktextfoods(true);
            setnullfoods();
            loadfood();
        }
        private void btnoutfoods_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        //---------------------------------------------------------------------------------------------------------------------
        //----------------------------TABLE------------------------------------------------------------------------------------
        private void setlockbttable(bool table)
        {
            btnAddTable.Enabled = table;
            btnDeleteTable.Enabled = table;
            btnEditTable.Enabled = table;
            btnsavetable.Enabled = !table;
            btncanceltable.Enabled = !table;
            
        }
        private void setlocktexttable(bool table)
        {
            txbTableID.ReadOnly = table;
            txbTableName.ReadOnly = table;


        }
        private void setnulltable()
        {
            txbTableName.Text = "";
            txbTableID.Text = "";

        }




        private void loadtable()
        {
            ltvtable.Items.Clear();
            List<OTABLE> lot = enti.OTABLEs.ToList();
            //enti.FOODSTYPEs.ToList();
            foreach (var item in lot)
            {
                string[] row = { item.ID.ToString(), item.TABLENUMBER, item.TSTATUS };
                ListViewItem tb = new ListViewItem(row);
                ltvtable.Items.Add(tb);
            }
        }
        private void loadtstatus()
        {

            cbTableStatus.Items.Add("Có Người");
            cbTableStatus.Items.Add("Trống");
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            setlockbttable(false);
            setlocktexttable(false);
            txbTableID.Enabled = false;
            btnDeleteTable.Enabled = false;
            setnulltable();
            newtable = true;
        }
        private void tooltable()
        {
            OTABLE addtb = new OTABLE();
            if (newtable == true)
            {
                addtb.TABLENUMBER = txbTableName.Text;
                addtb.TSTATUS = cbTableStatus.Text;
                enti.OTABLEs.Add(addtb);
            }
            else
            {

                int id2 = Convert.ToInt32(txbTableID.Text);
               OTABLE edittb = enti.OTABLEs.FirstOrDefault(c => c.ID == id2);
                edittb.TABLENUMBER = txbTableName.Text;
                edittb.TSTATUS = cbTableStatus.Text;
            }

        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (ltvtable.SelectedItems.Count > 0)
            {

                setlockbttable(false);
                setlocktexttable(false);
                txbTableID.ReadOnly = true;
                txbTableID.Text = ltvtable.SelectedItems[0].SubItems[0].Text;
                txbTableName.Text = ltvtable.SelectedItems[0].SubItems[1].Text;
                cbTableStatus.Text = ltvtable.SelectedItems[0].SubItems[2].Text;

                newfoodstype = false;
            }
           
        }

        private void btnsavetable_Click(object sender, EventArgs e)
        {
       
                List<OTABLE> lot = enti.OTABLEs.ToList();
                if (txbTableName.Text == "" || cbTableStatus.Text == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    tooltable();
                    enti.SaveChanges();
                    setlockbttable(true);
                    setlocktexttable(true);
                    btnDeleteTable.Enabled = false;
                    setnulltable();
                    loadtable(); 
                    Ftb.loadtable();
                }

        }
        bool dlttable;
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            
            List<BILL> lbill = enti.BILLs.ToList();
            List<FOOD> lfd = enti.FOODS.ToList();
            List<BILLINFO> lbif = enti.BILLINFOes.ToList();
            List<OTABLE> lot = enti.OTABLEs.ToList();
            int idtable = 0;

            if (ltvtable.SelectedItems.Count > 0) { idtable = Convert.ToInt32(ltvtable.SelectedItems[0].SubItems[0].Text); }
            foreach (OTABLE item in lot)
            {
                if (idtable == item.ID)
                {

                    DialogResult result = MessageBox.Show("Mọi dữ liệu sẽ mất hoàn toàn sau khi xóa.\nBạn có chắc chắn xóa không ?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        foreach (BILL item1 in lbill)
                        {
                            if (item1.IDTABLE == item.ID)
                            {
                                
                                foreach (BILLINFO item2 in lbif)
                                {
                                    if (item1.ID == item2.IDBILL)
                                    {
                                        enti.BILLINFOes.Remove(item2);
                                    }
                                }
                                enti.BILLs.Remove(item1);
                            }
                        }
                        enti.OTABLEs.Remove(item);
                        dlttable = true;
                    }
                    else
                    {
                        if (result == DialogResult.Cancel)
                        {
                            MessageBox.Show("Thao tác đã hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else { dlttable = false; }

            }
            enti.SaveChanges();

            if (dlttable == true)
            {

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ftb.loadtable();
                loadtable();
            }
            else { MessageBox.Show("Lỗi khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            loadfood();
        }

        private void btncanceltable_Click(object sender, EventArgs e)
        {
            setlockbttable(true);
            setlocktexttable(true);
            btnDeleteTable.Enabled = false;
            setnulltable();
            loadtable();
        }

        private void btnclosetable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------------------------------------------------------------------------------------------------------------
        //----------------------------FOODSTYPE--------------------------------------------------------------------------------

        private void setlockbtfoodtsype(bool type)
        {
            btnAddCategory.Enabled = type;
            btnDeleteCategory.Enabled = type;
            btnEditCategory.Enabled = type;
            btnsavetype.Enabled = !type;
            btncanceltype.Enabled = !type;
        }
        private void setlocktextfoodstype(bool type)
        {
            txbCategoryID.ReadOnly = type;
            txbCategoryName.ReadOnly = type;
        }
        private void setnullfoodstype()
        {
            txbCategoryID.Text = "";
            txbCategoryName.Text="";
        }
        private void loadfoodstype()
        {
            ltvfoodstype.Items.Clear();
            List<FOODSTYPE> lft = enti.FOODSTYPEs.ToList();
            foreach (var item in lft)
            {
                string[] row = { item.ID.ToString(), item.TYPENAME };
                ListViewItem ft = new ListViewItem(row);
                ltvfoodstype.Items.Add(ft);
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            setlockbtfoodtsype(false);
            setlocktextfoodstype(false);
            txbCategoryID.ReadOnly = true;
            btnDeleteCategory.Enabled = false;
            setnullfoodstype();
            newfoodstype = true;
        }
        private void toolfoodstype()
        {  
            FOODSTYPE ft = new FOODSTYPE();
            if (newfoodstype == true)
            {
                ft.TYPENAME = txbCategoryName.Text;
                enti.FOODSTYPEs.Add(ft);
            }
            else
            {
                int id2 = Convert.ToInt32(txbCategoryID.Text);
                FOODSTYPE edittype = enti.FOODSTYPEs.FirstOrDefault(c => c.ID==id2);
                edittype.TYPENAME = txbCategoryName.Text;

            }

        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (ltvfoodstype.SelectedItems.Count > 0)
            {
                setlockbtfoodtsype(false);
                setlocktextfoodstype(false);
                txbCategoryID.ReadOnly = true;
                txbCategoryID.Text = ltvfoodstype.SelectedItems[0].SubItems[0].Text;
                txbCategoryName.Text = ltvfoodstype.SelectedItems[0].SubItems[1].Text;
             }
            newfoodstype = false;
        }
        private void btnsavetype_Click(object sender, EventArgs e)
        {
            if (txbCategoryName.Text=="")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                toolfoodstype();
                enti.SaveChanges();
                setlockbtfoodtsype(true);
                setlocktextfoodstype(true);
                setnullfoodstype();
                loadfoodstype();
            }


        }


        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            bool a = false;
            List<FOODSTYPE> lft = enti.FOODSTYPEs.ToList();
            List<FOOD> lfd = enti.FOODS.ToList();
            List<BILLINFO> lbif = enti.BILLINFOes.ToList();
            List<OTABLE> lot = enti.OTABLEs.ToList();
            int idftype = 0;

            if (ltvfoodstype.SelectedItems.Count > 0) { idftype = Convert.ToInt32(ltvfoodstype.SelectedItems[0].SubItems[0].Text); }
            foreach (FOODSTYPE item in lft)
            {
                if (idftype == item.ID)
                {

                    DialogResult result = MessageBox.Show("Mọi dữ liệu sẽ mất hoàn toàn sau khi xóa.\nBạn có chắc chắn xóa không ?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        enti.FOODSTYPEs.Remove(item);
                        foreach (FOOD item1 in lfd)
                        {
                            if (idftype == item1.IDTYPE)
                            {
                                foreach (BILLINFO item2 in lbif)
                                {
                                    if (item1.ID == item2.IDFOODS)
                                    {
                                        enti.BILLINFOes.Remove(item2);
                                    }
                                }
                                enti.FOODS.Remove(item1);
                            }
                           
                            a = true;
                        }
                    }
                    else
                    {
                        if (result == DialogResult.Cancel)
                        {
                            MessageBox.Show("Thao tác đã hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else { a = false; }

            }
            enti.SaveChanges();

            if (a == true)
            {
                
                foreach (OTABLE item in lot)
                {
                    int idtable = 0;
                    if (item.TSTATUS=="Có người")
                    {
                        idtable = item.ID;
                        bill.checktable(idtable);
                    
                    }
                    
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ftb.loadtable();
            }
            else { MessageBox.Show("Lỗi khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            loadfoodstype();

        }
        private void btncanceltype_Click(object sender, EventArgs e)
        {
            setlockbtfoodtsype(true);
            setlocktextfoodstype(true);
            btnDeleteCategory.Enabled = false;
            setnullfoodstype();
            loadfoodstype();
        }

        private void btnouttype_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // entityedit.
        //--------------------------------------------------------------------------------------------------------------------

        //-----------------------------INCOME----------------------------------------------------------------------------------

        bool deleteob;
        private void deletetool()
        {
            List<BILL> lbill = enti.BILLs.ToList();
            List<BILLINFO> lbillif = enti.BILLINFOes.ToList();
            int idbill = 0;
            foreach (BILL item in lbill)
            {
                if(item.CHECKIN.Month!= DateTime.Now.Month)
                {
                    idbill = item.ID;
                    enti.BILLs.Remove(item);
                    foreach (BILLINFO item1 in lbillif)
                    {
                        if (idbill == item1.IDBILL)
                        {
                            enti.BILLINFOes.Remove(item1);
                        }
                    }
                    
                }
            }
            enti.SaveChanges();
            deleteob = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                deletetool();
                if (deleteob == true)
                {
                    MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Lỗi khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else {  MessageBox.Show("Đã hủy thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
            getviewincome(dtpkFromDate.Value, dtpkToDate.Value);


        }



        private void getviewincome(DateTime checkin, DateTime checkout)
        {

            List<billtest> listinfo = billDAO.Instance.getviewincome1(checkin, checkout);
            ltvincome.Items.Clear();
            foreach (billtest item in listinfo)
            {
                ListViewItem listview = new ListViewItem(item.Idbill.ToString());
                listview.SubItems.Add(item.Tablename.ToString());
                listview.SubItems.Add(item.Checkin.Value.Date.ToString("dd/MM/yyyy"));
                listview.SubItems.Add(item.Checkout.Value.Date.ToString("dd/MM/yyyy"));
                listview.SubItems.Add(item.Total.ToString("#,###"));
                listview.SubItems.Add(item.Discount.ToString("#,###"));
                listview.SubItems.Add(item.Takereal.ToString("#,###"));
                //listview.SubItems.Add(item.Idbill.ToString());
                ltvincome.Items.Add(listview);
            }

        }
        private void getallbill()
        {
            List<allbill> listinfo = billDAO.Instance.getallview();
            ltvincome.Items.Clear();
            foreach (allbill item in listinfo)
            {
                ListViewItem listview = new ListViewItem(item.Id.ToString());
                listview.SubItems.Add(item.Tablenumber.ToString());
                listview.SubItems.Add(item.Checkin.Value.Date.ToString("dd/MM/yyyy"));
                listview.SubItems.Add(item.Checkout.Value.Date.ToString("dd/MM/yyyy"));
                listview.SubItems.Add(item.Total.ToString("#,###"));
                listview.SubItems.Add(item.Discount.ToString("#,###"));
                listview.SubItems.Add(item.Takereal.ToString("#,###"));
                //listview.SubItems.Add(item.Idbill.ToString());
                ltvincome.Items.Add(listview);
            }
        }
        private void setvalue()
        {
            DateTime dt = DateTime.Now;
            dtpkFromDate.Value = new DateTime(dt.Year, dt.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            ltvincome.Items.Clear();
            DateTime checkin = dtpkFromDate.Value.Date;
            DateTime checkout = dtpkToDate.Value.Date;
           // loadviewincome(checkin,checkout);
            getviewincome(checkin, checkout);
        }

        private void showinfo(int idbill)
        {
            DataTable dt = new DataTable();
       
            dt = billinfoDAO.Instance.showbillinfo(idbill);
          //  CachedCrystalReportbif rpif = new CachedCrystalReportbif();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            DataTable dt = billDAO.Instance.viewincome(dtpkFromDate.Value, dtpkToDate.Value);
            //reportincome rp1 = new reportincome();
            //rp1.DataSource = dt;
            //rp1.ShowPreview();
            RPICM rp = new RPICM();
            //rp.DataSource = dt;
            rp.ShowPreview();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idbill = 0;
            if (ltvincome.SelectedItems.Count > 0)
            {
                idbill = Convert.ToInt32(ltvincome.SelectedItems[0].SubItems[0].Text);
                // MessageBox.Show(idbill.ToString());
            }
            demo1 d = new demo1();
            d.showinfo(idbill);
            d.ShowDialog();
        }

        private void getbillid(int idbill)
        {
            List<allbill> listinfo = billDAO.Instance.getviewid(idbill);
            ltvincome.Items.Clear();
            foreach (allbill item in listinfo)
            {
                if (idbill == item.Id)
                {
                    ListViewItem listview = new ListViewItem(item.Id.ToString());
                    listview.SubItems.Add(item.Tablenumber.ToString());
                    listview.SubItems.Add(item.Checkin.Value.Date.ToString("dd/MM/yyyy"));
                    listview.SubItems.Add(item.Checkout.Value.Date.ToString("dd/MM/yyyy"));
                    listview.SubItems.Add(item.Total.ToString("#,###"));
                    listview.SubItems.Add(item.Discount.ToString("#,###"));
                    listview.SubItems.Add(item.Takereal.ToString("#,###"));
                    //listview.SubItems.Add(item.Idbill.ToString());
                    ltvincome.Items.Add(listview);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbxfindidbill.Text != "")
            {
                int idbill = 0;
                int value;
                if (tbxfindidbill.Text == "") { getviewincome(dtpkFromDate.Value, dtpkToDate.Value); }
                else { if (int.TryParse(tbxfindidbill.Text, out value)) { idbill = value; } getbillid(idbill); }
                lblfindidbill.Text = "";
            }
            else { lblfindidbill.Text = "Tìm kiếm"; }
         
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                getallbill();
                //getviewincome(dtpkFromDate.Value, dtpkToDate.Value);
                dtpkFromDate.Enabled = false;
                dtpkToDate.Enabled = false;

            }
            else
            {
                dtpkFromDate.Enabled = true;
                dtpkToDate.Enabled = true;
            }
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //int idbill = 0;

            //if (tbxfindidbill.Text == "") { ltvincome.Clear(); loadviewicdontcheckday(); }
            //else
            //{
            //    idbill = int.Parse(tbxfindidbill.Text);
            //    ltvincome.Clear();
            //    getbillid(idbill);

            //}
        }
        //-----------------------------------------------------------------------------------------------------------

        //-------------------------ACCOUNT--------------------------------------------------------------------------


        private void setlockbtacc(bool acc)
        {
            btnAddAccount.Enabled = acc;
            btnEditAccount.Enabled = acc;
            btnDeleteAccount.Enabled = acc;
            btnsaveacc.Enabled = !acc;
            btncancelacc.Enabled = !acc;
        }
        private void setlocktextacc(bool acc)
        {
            txbUserName.ReadOnly = acc;
            txbDisPlayName.ReadOnly = acc;
            tbxpassacc.ReadOnly = acc;
            cbAccountType.Enabled = !acc;
        }
        private void setnullacc()
        {
            txbUserName.Text = "";
            txbDisPlayName.Text = "";
            tbxpassacc.Text = "";
            cbAccountType.Text = "";
        }
        //---ĐƯA DỮ LIỆU LÊN LISTVIEW-----
        private void loadacc()
        {
            ltvacc.Items.Clear();
            List<ACCOUNT> lacc = enti.ACCOUNTs.ToList();
            List<ACCOUNTTYPE> lat = enti.ACCOUNTTYPEs.ToList();
            foreach (var item in lacc)
            {
                foreach (var item1 in lat)
                {
                    if (item.POSITION == item1.POSITION)
                    {
                        string[] row = { item.USERNAME.ToString(), item.DISPLAYNAME, item.UPASSWORD, item1.ACCOUNTTYPE1 };
                        ListViewItem ac = new ListViewItem(row);
                        ltvacc.Items.Add(ac);
                    }

                }

            }


            // entityedit.
        }
    
        private void loadaccountype()
        {
            List<ACCOUNTTYPE> lat = enti.ACCOUNTTYPEs.ToList();
            cbAccountType.DataSource = lat;
            cbAccountType.DisplayMember = "ACCOUNTTYPE1";
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            setlockbtacc(false);
            setlocktextacc(false);
            setnullacc();
           newacc = true;
        }


        public string checkon()
        {
            if (ltvacc.SelectedItems.Count > 0)
            {

                return ltvacc.SelectedItems[0].SubItems[0].Text; ;
            }
            return null;
        }
        bool dltacc;
        
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
           // string accon = Login.Username;

            //  string lgacc = Login.Username;
            List<ACCOUNT> acc = enti.ACCOUNTs.ToList();
            string user = "";
            if (ltvacc.SelectedItems.Count > 0)
            {
                user = ltvacc.SelectedItems[0].SubItems[0].Text;

                foreach (ACCOUNT item in acc)
                {
                    if (string.Compare(user, item.USERNAME, false) == 0)
                    {
                        enti.ACCOUNTs.Remove(item);
                        dltacc = true;
                        checkon();

                    }
                   
                }
            }
            else { dltacc = false; }


            //if (log.checkacc() == true)
            //{
            //    this.Close();
            //    Ftb.Close();
            //}

            //if (Login.Username == user)
            //{

            //account acccheck = Login;
            //if (acccheck.Username == user)
            //{
            //      this.Close();
            ////    Ftb.Close();
            //}
            enti.SaveChanges();
           
            if (dltacc == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Lỗi khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            loadacc();
           
        }
   
        private void toolsacc()
        {
            string username = txbUserName.Text;
            ACCOUNTTYPE typeacc = cbAccountType.SelectedValue as ACCOUNTTYPE;
            List<ACCOUNT> acc = enti.ACCOUNTs.ToList();
            ACCOUNT addacc = new ACCOUNT();
            if (newacc == true)
            {
                foreach (ACCOUNT item in acc)
                {
                    if (string.Compare(txbUserName.Text, item.USERNAME, false) != 0)
                    {
                        addacc.USERNAME = (username);
                        addacc.DISPLAYNAME = txbDisPlayName.Text;
                        addacc.UPASSWORD = tbxpassacc.Text;
                        addacc.POSITION = (typeacc.POSITION);
                       
                    }
                    else
                    {
                        MessageBox.Show("Tên Người dùng đã tồn tại", "Thông báo");
                    }
                    enti.ACCOUNTs.Add(addacc);
                }
            }
            else
            {

                ACCOUNT editacc = enti.ACCOUNTs.FirstOrDefault(c => c.USERNAME == username);
                editacc.DISPLAYNAME = txbDisPlayName.Text;
                editacc.UPASSWORD = tbxpassacc.Text;
                editacc.POSITION = typeacc.POSITION;
            }

        }

     //------NÚT LƯU-----
        private void btnsaveacc_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "" || txbDisPlayName.Text == "" || tbxpassacc.Text == "" || cbAccountType.SelectedValue == null)
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                toolsacc();
                enti.SaveChanges();
                setlockbtacc(true);
                setlocktextacc(true);
                setnullacc();
                loadacc();
            }


        }

        //---NÚT SỬA----
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (ltvacc.SelectedItems.Count > 0)
            {
                ACCOUNT typeacc = cbAccountType.SelectedValue as ACCOUNT;
                setlockbtacc(false);
                setlocktextacc(false);
                txbUserName.ReadOnly = true;
                txbUserName.Text = ltvacc.SelectedItems[0].SubItems[0].Text;
                txbDisPlayName.Text = ltvacc.SelectedItems[0].SubItems[1].Text;
                tbxpassacc.Text = ltvacc.SelectedItems[0].SubItems[2].Text;
                cbAccountType.Text = ltvacc.SelectedItems[0].SubItems[3].Text;


            }
            newacc = false;
        }

        private void btncancelacc_Click(object sender, EventArgs e)
        {
            setlockbtacc(true);
            setlocktextacc(true);
            setnullacc();
            loadacc();
        }

        private void btncloseacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnrpacc_Click(object sender, EventArgs e)
        {
            rpacc rp = new rpacc();
            rp.ShowPreview();
        }

        private void lblfilename_Click(object sender, EventArgs e)
        {

        }

        private void txbCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfindidbill_Click(object sender, EventArgs e)
        {

        }

  


















        //private void toolimg()
        //{
        //    FOOD imgf = new FOOD();
        //}




        /// //////////////////////////////////////////////////////////////////////////



        //-------------------------------------------------------------------------------------------------------------
    }

          
 }
    