namespace APP_KHACH_CHUAN
{
    partial class ShopFood
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
            this.txtTenShop = new System.Windows.Forms.Label();
            this.txtDiaChiShop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenShop
            // 
            this.txtTenShop.AutoSize = true;
            this.txtTenShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenShop.Location = new System.Drawing.Point(3, 144);
            this.txtTenShop.Name = "txtTenShop";
            this.txtTenShop.Size = new System.Drawing.Size(91, 24);
            this.txtTenShop.TabIndex = 1;
            this.txtTenShop.Text = "Tên shop";
            // 
            // txtDiaChiShop
            // 
            this.txtDiaChiShop.AutoSize = true;
            this.txtDiaChiShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDiaChiShop.Location = new System.Drawing.Point(20, 168);
            this.txtDiaChiShop.Name = "txtDiaChiShop";
            this.txtDiaChiShop.Size = new System.Drawing.Size(67, 24);
            this.txtDiaChiShop.TabIndex = 2;
            this.txtDiaChiShop.Text = "Địa chỉ";
            this.txtDiaChiShop.Click += new System.EventHandler(this.txtDiaChiShop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShopFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDiaChiShop);
            this.Controls.Add(this.txtTenShop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShopFood";
            this.Size = new System.Drawing.Size(200, 196);
            this.Load += new System.EventHandler(this.ShopFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTenShop;
        private System.Windows.Forms.Label txtDiaChiShop;
    }
}
