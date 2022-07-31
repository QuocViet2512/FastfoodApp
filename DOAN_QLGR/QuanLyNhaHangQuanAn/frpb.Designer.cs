namespace QuanLyNhaHangQuanAn
{
    partial class frpb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frpb));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport31 = new QuanLyNhaHangQuanAn.CrystalReport3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprintbill = new System.Windows.Forms.Button();
            this.btndone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1000, 515);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnexport);
            this.panel1.Controls.Add(this.btnprintbill);
            this.panel1.Controls.Add(this.btndone);
            this.panel1.Location = new System.Drawing.Point(12, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 92);
            this.panel1.TabIndex = 1;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexport.AutoSize = true;
            this.btnexport.Location = new System.Drawing.Point(27, 20);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(193, 58);
            this.btnexport.TabIndex = 6;
            this.btnexport.Text = "Xuất hóa đơn dưới ";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click_1);
            // 
            // btnprintbill
            // 
            this.btnprintbill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprintbill.AutoSize = true;
            this.btnprintbill.Location = new System.Drawing.Point(398, 20);
            this.btnprintbill.Name = "btnprintbill";
            this.btnprintbill.Size = new System.Drawing.Size(193, 58);
            this.btnprintbill.TabIndex = 5;
            this.btnprintbill.Text = "In hóa đơn";
            this.btnprintbill.UseVisualStyleBackColor = true;
            this.btnprintbill.Click += new System.EventHandler(this.btnprintbill_Click_1);
            // 
            // btndone
            // 
            this.btndone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndone.AutoSize = true;
            this.btndone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndone.Location = new System.Drawing.Point(776, 20);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(193, 58);
            this.btndone.TabIndex = 4;
            this.btndone.Text = "Xong";
            this.btndone.UseVisualStyleBackColor = false;
            this.btndone.Click += new System.EventHandler(this.btndone_Click_1);
            // 
            // frpb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frpb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
   
        private CrystalReport3 CrystalReport31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprintbill;
        private System.Windows.Forms.Button btndone;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}