namespace APP_KHACH_CHUAN
{
    partial class ItemDatHang
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
            this.txtTenFood = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.Label();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenFood
            // 
            this.txtTenFood.AutoSize = true;
            this.txtTenFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFood.ForeColor = System.Drawing.Color.Red;
            this.txtTenFood.Location = new System.Drawing.Point(115, 12);
            this.txtTenFood.Name = "txtTenFood";
            this.txtTenFood.Size = new System.Drawing.Size(91, 25);
            this.txtTenFood.TabIndex = 10;
            this.txtTenFood.Text = "tênfood";
            // 
            // txtSoluong
            // 
            this.txtSoluong.AutoSize = true;
            this.txtSoluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoluong.Location = new System.Drawing.Point(116, 50);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(85, 24);
            this.txtSoluong.TabIndex = 9;
            this.txtSoluong.Text = "soluong";
            // 
            // picturebox1
            // 
            this.picturebox1.BackgroundImage = global::APP_KHACH_CHUAN.Properties.Resources.noimage;
            this.picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox1.Location = new System.Drawing.Point(345, 6);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(65, 68);
            this.picturebox1.TabIndex = 6;
            this.picturebox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên món:";
            // 
            // ItemDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenFood);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.picturebox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemDatHang";
            this.Size = new System.Drawing.Size(420, 81);
            this.Load += new System.EventHandler(this.ItemDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTenFood;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.Label txtSoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
