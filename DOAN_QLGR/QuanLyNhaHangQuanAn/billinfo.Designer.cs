namespace QuanLyNhaHangQuanAn
{
    partial class billinfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfound = new System.Windows.Forms.Button();
            this.crtrpif = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
          //  this.CrystalReport11 = new QuanLyNhaHangQuanAn.CrystalReport1();
           // this.CrystalReportbif1 = new QuanLyNhaHangQuanAn.CrystalReportbif();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnfound);
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 1;
            // 
            // btnfound
            // 
            this.btnfound.Location = new System.Drawing.Point(304, 0);
            this.btnfound.Name = "btnfound";
            this.btnfound.Size = new System.Drawing.Size(222, 55);
            this.btnfound.TabIndex = 0;
            this.btnfound.Text = "Xem xong ";
            this.btnfound.UseVisualStyleBackColor = true;
            this.btnfound.Click += new System.EventHandler(this.btnfound_Click);
            // 
            // crtrpif
            // 
            this.crtrpif.ActiveViewIndex = 0;
            this.crtrpif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtrpif.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtrpif.Location = new System.Drawing.Point(0, 1);
            this.crtrpif.Name = "crtrpif";
            //this.crtrpif.ReportSource = this.CrystalReportbif1;
            this.crtrpif.Size = new System.Drawing.Size(800, 474);
            this.crtrpif.TabIndex = 0;
            // 
            // billinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crtrpif);
            this.Name = "billinfo";
            this.Text = "Chi tiết hóa đơn";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtrpif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfound;
      //  private CrystalReportbif CrystalReportbif1;
   //     private CrystalReport1 CrystalReport11;
    }
}