namespace CUAHANG
{
    partial class itemDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GIA = new System.Windows.Forms.Label();
            this.txtTenFood = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaFood = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá";
            // 
            // GIA
            // 
            this.GIA.AutoSize = true;
            this.GIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GIA.Location = new System.Drawing.Point(336, 100);
            this.GIA.Name = "GIA";
            this.GIA.Size = new System.Drawing.Size(46, 20);
            this.GIA.TabIndex = 6;
            this.GIA.Text = "VND";
            this.GIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenFood
            // 
            this.txtTenFood.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtTenFood.Enabled = false;
            this.txtTenFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenFood.Location = new System.Drawing.Point(108, 15);
            this.txtTenFood.Name = "txtTenFood";
            this.txtTenFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTenFood.Size = new System.Drawing.Size(274, 26);
            this.txtTenFood.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong.Location = new System.Drawing.Point(108, 56);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoLuong.Size = new System.Drawing.Size(274, 26);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtGiaFood
            // 
            this.txtGiaFood.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtGiaFood.Enabled = false;
            this.txtGiaFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtGiaFood.Location = new System.Drawing.Point(108, 97);
            this.txtGiaFood.Name = "txtGiaFood";
            this.txtGiaFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaFood.Size = new System.Drawing.Size(222, 26);
            this.txtGiaFood.TabIndex = 9;
            // 
            // itemDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.txtGiaFood);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenFood);
            this.Controls.Add(this.GIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "itemDonHang";
            this.Size = new System.Drawing.Size(406, 137);
            this.Load += new System.EventHandler(this.itemDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GIA;
        private System.Windows.Forms.TextBox txtTenFood;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaFood;
    }
}
