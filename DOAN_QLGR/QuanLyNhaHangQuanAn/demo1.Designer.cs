namespace QuanLyNhaHangQuanAn
{
    partial class demo1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndone = new System.Windows.Forms.Button();
            this.btnoutbill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // btndone
            // 
            this.btndone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Done_icon;
            this.btndone.Location = new System.Drawing.Point(813, 486);
            this.btndone.Name = "btndone";
            this.btndone.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btndone.Size = new System.Drawing.Size(211, 64);
            this.btndone.TabIndex = 1;
            this.btndone.Text = "Xem xong";
            this.btndone.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndone.UseVisualStyleBackColor = false;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // btnoutbill
            // 
            this.btnoutbill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnoutbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoutbill.Image = global::QuanLyNhaHangQuanAn.Properties.Resources.Done_icon;
            this.btnoutbill.Location = new System.Drawing.Point(87, 486);
            this.btnoutbill.Name = "btnoutbill";
            this.btnoutbill.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnoutbill.Size = new System.Drawing.Size(293, 64);
            this.btnoutbill.TabIndex = 2;
            this.btnoutbill.Text = "Xuất hóa đơn này";
            this.btnoutbill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnoutbill.UseVisualStyleBackColor = false;
            this.btnoutbill.Click += new System.EventHandler(this.button1_Click);
            // 
            // demo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.btnoutbill);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "demo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "demo1";
            this.Load += new System.EventHandler(this.demo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.Button btnoutbill;
    }
}