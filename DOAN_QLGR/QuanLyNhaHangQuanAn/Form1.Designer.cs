namespace QuanLyNhaHangQuanAn
{
    partial class frmdiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.nbudcount = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbudcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giảm giá ";
            // 
            // nbudcount
            // 
            this.nbudcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbudcount.Location = new System.Drawing.Point(43, 89);
            this.nbudcount.Name = "nbudcount";
            this.nbudcount.Size = new System.Drawing.Size(253, 45);
            this.nbudcount.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhaHangQuanAn.Properties.Resources._1486395314_13_discount_80575;
            this.pictureBox1.Location = new System.Drawing.Point(302, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btndone
            // 
            this.btndone.BackColor = System.Drawing.Color.DarkOrange;
            this.btndone.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Done_icon;
            this.btndone.Location = new System.Drawing.Point(114, 178);
            this.btndone.Name = "btndone";
            this.btndone.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btndone.Size = new System.Drawing.Size(159, 48);
            this.btndone.TabIndex = 2;
            this.btndone.Text = "Xong ";
            this.btndone.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndone.UseVisualStyleBackColor = false;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // frmdiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(393, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbudcount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdiscount";
            ((System.ComponentModel.ISupportInitialize)(this.nbudcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndone;
        public System.Windows.Forms.NumericUpDown nbudcount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}