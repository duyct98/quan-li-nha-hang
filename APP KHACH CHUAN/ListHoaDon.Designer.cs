namespace APP_KHACH_CHUAN
{
    partial class ListHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txtGiaFood = new System.Windows.Forms.Label();
            this.txtHoaDonID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "THỰC HIỆN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng hoá đơn: ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(2, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 15);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID:";
            // 
            // txtGiaFood
            // 
            this.txtGiaFood.AutoSize = true;
            this.txtGiaFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaFood.Location = new System.Drawing.Point(111, 28);
            this.txtGiaFood.Name = "txtGiaFood";
            this.txtGiaFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGiaFood.Size = new System.Drawing.Size(65, 15);
            this.txtGiaFood.TabIndex = 8;
            this.txtGiaFood.Text = "Gia Food";
            // 
            // txtHoaDonID
            // 
            this.txtHoaDonID.AutoSize = true;
            this.txtHoaDonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonID.Location = new System.Drawing.Point(26, 13);
            this.txtHoaDonID.Name = "txtHoaDonID";
            this.txtHoaDonID.Size = new System.Drawing.Size(21, 15);
            this.txtHoaDonID.TabIndex = 7;
            this.txtHoaDonID.Text = "ID";
            // 
            // ListHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtGiaFood);
            this.Controls.Add(this.txtHoaDonID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListHoaDon";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(298, 53);
            this.Load += new System.EventHandler(this.ListHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label txtGiaFood;
        private System.Windows.Forms.Label txtHoaDonID;
    }
}
