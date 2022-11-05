namespace APP_KHACH_CHUAN
{
    partial class itemFoodDonHang
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
            this.tenFood = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.Gia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenFood
            // 
            this.tenFood.AutoSize = true;
            this.tenFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenFood.Location = new System.Drawing.Point(3, 9);
            this.tenFood.Name = "tenFood";
            this.tenFood.Size = new System.Drawing.Size(31, 15);
            this.tenFood.TabIndex = 0;
            this.tenFood.Text = "Tên";
            this.tenFood.Click += new System.EventHandler(this.tenFood_Click);
            // 
            // SoLuong
            // 
            this.SoLuong.Enabled = false;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.Location = new System.Drawing.Point(178, 28);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(40, 21);
            this.SoLuong.TabIndex = 3;
            this.SoLuong.Text = "0";
            this.SoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Enabled = false;
            this.Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia.Location = new System.Drawing.Point(3, 28);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(29, 15);
            this.Gia.TabIndex = 4;
            this.Gia.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng";
            this.label1.Click += new System.EventHandler(this.tenFood_Click);
            // 
            // itemFoodDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenFood);
            this.Name = "itemFoodDonHang";
            this.Size = new System.Drawing.Size(230, 52);
            this.Load += new System.EventHandler(this.itemFoodDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenFood;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label label1;
    }
}
