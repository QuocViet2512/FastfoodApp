namespace QuanLyNhaHangQuanAn
{
    partial class amount
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
            this.nbudamount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbudamount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nbudamount);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 200);
            this.panel1.TabIndex = 0;
            // 
            // nbudamount
            // 
            this.nbudamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbudamount.Location = new System.Drawing.Point(85, 60);
            this.nbudamount.Name = "nbudamount";
            this.nbudamount.Size = new System.Drawing.Size(237, 41);
            this.nbudamount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.DarkOrange;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnok.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Done_icon;
            this.btnok.Location = new System.Drawing.Point(127, 126);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(156, 46);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Xong ";
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(418, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "amount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "amount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbudamount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nbudamount;
    }
}