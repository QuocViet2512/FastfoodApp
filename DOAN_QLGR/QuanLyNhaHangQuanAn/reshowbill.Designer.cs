namespace QuanLyNhaHangQuanAn
{
    partial class reshowbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reshowbill));
            this.crtreshow = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprintbill = new System.Windows.Forms.Button();
            this.btndone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crtreshow
            // 
            this.crtreshow.ActiveViewIndex = -1;
            this.crtreshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crtreshow.AutoSize = true;
            this.crtreshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtreshow.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtreshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtreshow.Location = new System.Drawing.Point(-1, -1);
            this.crtreshow.Margin = new System.Windows.Forms.Padding(4);
            this.crtreshow.Name = "crtreshow";
            this.crtreshow.Size = new System.Drawing.Size(1095, 515);
            this.crtreshow.TabIndex = 1;
            this.crtreshow.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnexport);
            this.panel1.Controls.Add(this.btnprintbill);
            this.panel1.Controls.Add(this.btndone);
            this.panel1.Location = new System.Drawing.Point(12, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 92);
            this.panel1.TabIndex = 2;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnexport.AutoSize = true;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Location = new System.Drawing.Point(27, 20);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(193, 58);
            this.btnexport.TabIndex = 6;
            this.btnexport.Text = "Xuất hóa đơn ";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnprintbill
            // 
            this.btnprintbill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprintbill.AutoSize = true;
            this.btnprintbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintbill.Location = new System.Drawing.Point(398, 20);
            this.btnprintbill.Name = "btnprintbill";
            this.btnprintbill.Size = new System.Drawing.Size(288, 58);
            this.btnprintbill.TabIndex = 5;
            this.btnprintbill.Text = "In hóa đơn";
            this.btnprintbill.UseVisualStyleBackColor = true;
            this.btnprintbill.Click += new System.EventHandler(this.btnprintbill_Click);
            // 
            // btndone
            // 
            this.btndone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndone.AutoSize = true;
            this.btndone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.Location = new System.Drawing.Point(871, 20);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(193, 58);
            this.btndone.TabIndex = 4;
            this.btndone.Text = "Xong";
            this.btndone.UseVisualStyleBackColor = false;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // reshowbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1095, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crtreshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reshowbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reshowbill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crtreshow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprintbill;
        private System.Windows.Forms.Button btndone;
    }
}