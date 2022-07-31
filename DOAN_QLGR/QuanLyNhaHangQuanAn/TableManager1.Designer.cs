namespace QuanLyNhaHangQuanAn
{
    partial class frmOder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOder));
            this.pnlfoodsview = new System.Windows.Forms.Panel();
            this.ltvlistoder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbfind = new System.Windows.Forms.GroupBox();
            this.lblfindnamefoods = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.txbfoodsname = new System.Windows.Forms.TextBox();
            this.cbxfoodstype = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxdiscount = new System.Windows.Forms.TextBox();
            this.btndiscount = new System.Windows.Forms.Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndone = new System.Windows.Forms.Button();
            this.btnChangetable = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.ltvfoodsmenu = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlfoodsview.SuspendLayout();
            this.grbfind.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlfoodsview
            // 
            this.pnlfoodsview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlfoodsview.Controls.Add(this.ltvlistoder);
            this.pnlfoodsview.Location = new System.Drawing.Point(457, 12);
            this.pnlfoodsview.Name = "pnlfoodsview";
            this.pnlfoodsview.Size = new System.Drawing.Size(785, 462);
            this.pnlfoodsview.TabIndex = 0;
            // 
            // ltvlistoder
            // 
            this.ltvlistoder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvlistoder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvlistoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvlistoder.FullRowSelect = true;
            this.ltvlistoder.GridLines = true;
            this.ltvlistoder.HideSelection = false;
            this.ltvlistoder.Location = new System.Drawing.Point(3, 3);
            this.ltvlistoder.Name = "ltvlistoder";
            this.ltvlistoder.ShowItemToolTips = true;
            this.ltvlistoder.Size = new System.Drawing.Size(779, 456);
            this.ltvlistoder.TabIndex = 0;
            this.ltvlistoder.UseCompatibleStateImageBehavior = false;
            this.ltvlistoder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 253;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 205;
            // 
            // grbfind
            // 
            this.grbfind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbfind.Controls.Add(this.lblfindnamefoods);
            this.grbfind.Controls.Add(this.label2);
            this.grbfind.Controls.Add(this.label1);
            this.grbfind.Controls.Add(this.btnfind);
            this.grbfind.Controls.Add(this.txbfoodsname);
            this.grbfind.Controls.Add(this.cbxfoodstype);
            this.grbfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbfind.Location = new System.Drawing.Point(7, 12);
            this.grbfind.Name = "grbfind";
            this.grbfind.Size = new System.Drawing.Size(430, 108);
            this.grbfind.TabIndex = 1;
            this.grbfind.TabStop = false;
            this.grbfind.Text = "Tìm Kiếm";
            // 
            // lblfindnamefoods
            // 
            this.lblfindnamefoods.AutoSize = true;
            this.lblfindnamefoods.BackColor = System.Drawing.Color.White;
            this.lblfindnamefoods.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblfindnamefoods.Location = new System.Drawing.Point(132, 72);
            this.lblfindnamefoods.Name = "lblfindnamefoods";
            this.lblfindnamefoods.Size = new System.Drawing.Size(91, 20);
            this.lblfindnamefoods.TabIndex = 5;
            this.lblfindnamefoods.Text = "Tìm kiếm ";
            this.lblfindnamefoods.Click += new System.EventHandler(this.lblfindnamefoods_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Món Ăn";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại Món Ăn";
            // 
            // btnfind
            // 
            this.btnfind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfind.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.find2;
            this.btnfind.Location = new System.Drawing.Point(337, 26);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(79, 70);
            this.btnfind.TabIndex = 2;
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txbfoodsname
            // 
            this.txbfoodsname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbfoodsname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbfoodsname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbfoodsname.Location = new System.Drawing.Point(122, 69);
            this.txbfoodsname.Name = "txbfoodsname";
            this.txbfoodsname.Size = new System.Drawing.Size(209, 27);
            this.txbfoodsname.TabIndex = 1;
            this.txbfoodsname.TextChanged += new System.EventHandler(this.txbfoodsname_TextChanged_1);
            // 
            // cbxfoodstype
            // 
            this.cbxfoodstype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxfoodstype.FormattingEnabled = true;
            this.cbxfoodstype.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbxfoodstype.Location = new System.Drawing.Point(122, 32);
            this.cbxfoodstype.Name = "cbxfoodstype";
            this.cbxfoodstype.Size = new System.Drawing.Size(209, 28);
            this.cbxfoodstype.TabIndex = 0;
            this.cbxfoodstype.SelectedIndexChanged += new System.EventHandler(this.cbxfoodstype_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxdiscount);
            this.panel1.Controls.Add(this.btndiscount);
            this.panel1.Controls.Add(this.txbTotal);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Location = new System.Drawing.Point(457, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 73);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(372, 17);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(132, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tạm tính ";
            // 
            // tbxdiscount
            // 
            this.tbxdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxdiscount.Enabled = false;
            this.tbxdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxdiscount.Location = new System.Drawing.Point(93, 20);
            this.tbxdiscount.Name = "tbxdiscount";
            this.tbxdiscount.ReadOnly = true;
            this.tbxdiscount.Size = new System.Drawing.Size(167, 34);
            this.tbxdiscount.TabIndex = 3;
            this.tbxdiscount.Text = "0";
            // 
            // btndiscount
            // 
            this.btndiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btndiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiscount.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.box1_101952__1_;
            this.btndiscount.Location = new System.Drawing.Point(11, 4);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(75, 66);
            this.btndiscount.TabIndex = 2;
            this.btndiscount.UseVisualStyleBackColor = true;
            this.btndiscount.Click += new System.EventHandler(this.btndiscount_Click);
            // 
            // txbTotal
            // 
            this.txbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotal.Enabled = false;
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.ForeColor = System.Drawing.Color.Red;
            this.txbTotal.Location = new System.Drawing.Point(510, 20);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(262, 30);
            this.txbTotal.TabIndex = 1;
            this.txbTotal.Text = "0";
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(332, 38);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 0);
            this.lbltotal.TabIndex = 0;
            this.lbltotal.Text = "Tạm Tính ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.btndone);
            this.panel2.Controls.Add(this.btnChangetable);
            this.panel2.Controls.Add(this.btnCanel);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Location = new System.Drawing.Point(457, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 87);
            this.panel2.TabIndex = 4;
            // 
            // btndone
            // 
            this.btndone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btndone.AutoSize = true;
            this.btndone.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btndone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndone.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Save_as_icon;
            this.btndone.Location = new System.Drawing.Point(413, 14);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(160, 57);
            this.btndone.TabIndex = 3;
            this.btndone.Text = "   Xong";
            this.btndone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndone.UseVisualStyleBackColor = false;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // btnChangetable
            // 
            this.btnChangetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangetable.AutoSize = true;
            this.btnChangetable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChangetable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangetable.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Other_Power_Switch_User_Metro_icon;
            this.btnChangetable.Location = new System.Drawing.Point(12, 14);
            this.btnChangetable.Name = "btnChangetable";
            this.btnChangetable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChangetable.Size = new System.Drawing.Size(162, 57);
            this.btnChangetable.TabIndex = 2;
            this.btnChangetable.Text = "Chuyển Bàn";
            this.btnChangetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangetable.UseVisualStyleBackColor = false;
            // 
            // btnCanel
            // 
            this.btnCanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCanel.AutoSize = true;
            this.btnCanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanel.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Close_2_icon;
            this.btnCanel.Location = new System.Drawing.Point(211, 14);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCanel.Size = new System.Drawing.Size(160, 57);
            this.btnCanel.TabIndex = 1;
            this.btnCanel.Text = "   Hủy món";
            this.btnCanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.AutoSize = true;
            this.btnPay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.pay;
            this.btnPay.Location = new System.Drawing.Point(613, 14);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(160, 57);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // ltvfoodsmenu
            // 
            this.ltvfoodsmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvfoodsmenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.ltvfoodsmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvfoodsmenu.FullRowSelect = true;
            this.ltvfoodsmenu.GridLines = true;
            this.ltvfoodsmenu.HideSelection = false;
            this.ltvfoodsmenu.Location = new System.Drawing.Point(7, 126);
            this.ltvfoodsmenu.Name = "ltvfoodsmenu";
            this.ltvfoodsmenu.Size = new System.Drawing.Size(430, 520);
            this.ltvfoodsmenu.TabIndex = 5;
            this.ltvfoodsmenu.UseCompatibleStateImageBehavior = false;
            this.ltvfoodsmenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltvfoodsmenu_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên món ăn ";
            this.columnHeader5.Width = 100;
            // 
            // frmOder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::QuanLyNhaHangQuanAn.Properties.Resources._3863877;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 656);
            this.Controls.Add(this.ltvfoodsmenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grbfind);
            this.Controls.Add(this.pnlfoodsview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Quán Ăn";
            this.Load += new System.EventHandler(this.frmOder_Load);
            this.pnlfoodsview.ResumeLayout(false);
            this.grbfind.ResumeLayout(false);
            this.grbfind.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlfoodsview;
        private System.Windows.Forms.GroupBox grbfind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txbfoodsname;
        private System.Windows.Forms.ComboBox cbxfoodstype;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.Button btnChangetable;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btndiscount;
        private System.Windows.Forms.ListView ltvfoodsmenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox tbxdiscount;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView ltvlistoder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfindnamefoods;
    }
}