namespace QuanLyNhaHangQuanAn
{
    partial class frmTableManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpNguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhậpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềChúngTôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiênBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fnpotable = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimemove = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.nhậpNguyênLiệuToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1467, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Admin_icon;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.profile_settings_icon;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Folder_Profiles_icon;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.logout_icon;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(249, 38);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // nhậpNguyênLiệuToolStripMenuItem
            // 
            this.nhậpNguyênLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíNhậpToolStripMenuItem});
            this.nhậpNguyênLiệuToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.diagram_06_24511;
            this.nhậpNguyênLiệuToolStripMenuItem.Name = "nhậpNguyênLiệuToolStripMenuItem";
            this.nhậpNguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.nhậpNguyênLiệuToolStripMenuItem.Text = "Kho";
            this.nhậpNguyênLiệuToolStripMenuItem.Click += new System.EventHandler(this.nhậpNguyênLiệuToolStripMenuItem_Click);
            // 
            // quảnLíNhậpToolStripMenuItem
            // 
            this.quảnLíNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíNhậpToolStripMenuItem1});
            this.quảnLíNhậpToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.carrots_96797;
            this.quảnLíNhậpToolStripMenuItem.Name = "quảnLíNhậpToolStripMenuItem";
            this.quảnLíNhậpToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.quảnLíNhậpToolStripMenuItem.Text = "Nguyên liệu ";
            // 
            // quảnLíNhậpToolStripMenuItem1
            // 
            this.quảnLíNhậpToolStripMenuItem1.Name = "quảnLíNhậpToolStripMenuItem1";
            this.quảnLíNhậpToolStripMenuItem1.Size = new System.Drawing.Size(200, 28);
            this.quảnLíNhậpToolStripMenuItem1.Text = "Quản lí nhập ";
            this.quảnLíNhậpToolStripMenuItem1.Click += new System.EventHandler(this.quảnLíNhậpToolStripMenuItem1_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềPhầnMềmToolStripMenuItem,
            this.vềChúngTôiToolStripMenuItem,
            this.phiênBảnToolStripMenuItem,
            this.liênHệToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.help_question_1566;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // vềPhầnMềmToolStripMenuItem
            // 
            this.vềPhầnMềmToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.information_info_1565;
            this.vềPhầnMềmToolStripMenuItem.Name = "vềPhầnMềmToolStripMenuItem";
            this.vềPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.vềPhầnMềmToolStripMenuItem.Text = "Về phần mềm ";
            // 
            // vềChúngTôiToolStripMenuItem
            // 
            this.vềChúngTôiToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.user_info_icon;
            this.vềChúngTôiToolStripMenuItem.Name = "vềChúngTôiToolStripMenuItem";
            this.vềChúngTôiToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.vềChúngTôiToolStripMenuItem.Text = "Về chúng tôi";
            this.vềChúngTôiToolStripMenuItem.Click += new System.EventHandler(this.vềChúngTôiToolStripMenuItem_Click);
            // 
            // phiênBảnToolStripMenuItem
            // 
            this.phiênBảnToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.app_upload_22041;
            this.phiênBảnToolStripMenuItem.Name = "phiênBảnToolStripMenuItem";
            this.phiênBảnToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.phiênBảnToolStripMenuItem.Text = "Phiên bản ";
            this.phiênBảnToolStripMenuItem.Click += new System.EventHandler(this.phiênBảnToolStripMenuItem_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.chat_53_icon_icons_com_65955;
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Actions_help_contents_icon1;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(219, 38);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // fnpotable
            // 
            this.fnpotable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fnpotable.AutoScroll = true;
            this.fnpotable.BackColor = System.Drawing.Color.SeaShell;
            this.fnpotable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fnpotable.Location = new System.Drawing.Point(154, 221);
            this.fnpotable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fnpotable.Name = "fnpotable";
            this.fnpotable.Padding = new System.Windows.Forms.Padding(110, 0, 69, 0);
            this.fnpotable.Size = new System.Drawing.Size(1161, 458);
            this.fnpotable.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox1.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(154, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1161, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox2.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Popeyes_New_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(1096, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 170;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimemove
            // 
            this.lbltimemove.AutoSize = true;
            this.lbltimemove.BackColor = System.Drawing.Color.SeaShell;
            this.lbltimemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimemove.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbltimemove.Location = new System.Drawing.Point(161, 67);
            this.lbltimemove.Name = "lbltimemove";
            this.lbltimemove.Size = new System.Drawing.Size(109, 38);
            this.lbltimemove.TabIndex = 4;
            this.lbltimemove.Text = "label1";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Peru;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ImageKey = "(none)";
            this.lbluser.Location = new System.Drawing.Point(121, 10);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(51, 24);
            this.lbluser.TabIndex = 5;
            this.lbluser.Text = "user";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Location = new System.Drawing.Point(1025, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 40);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xin chào:";
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::QuanLyNhaHangQuanAn.Properties.Resources._3896857;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltimemove);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fnpotable);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống cửa hàng POPEYES";
            this.Load += new System.EventHandler(this.frmTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel fnpotable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem nhậpNguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềChúngTôiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiênBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhậpToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimemove;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}