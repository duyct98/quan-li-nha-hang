namespace APP_KHACH_CHUAN
{
    partial class itemFood
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtGiaFood = new System.Windows.Forms.Label();
            this.txtTenFood = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDoiGia = new System.Windows.Forms.TextBox();
            this.txtDoiTen = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(141, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 50);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "+";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(141, 80);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(68, 50);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "-";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtGiaFood
            // 
            this.txtGiaFood.AutoSize = true;
            this.txtGiaFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtGiaFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaFood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGiaFood.Location = new System.Drawing.Point(22, 138);
            this.txtGiaFood.Name = "txtGiaFood";
            this.txtGiaFood.Size = new System.Drawing.Size(77, 24);
            this.txtGiaFood.TabIndex = 4;
            this.txtGiaFood.Text = "0 Đồng";
            // 
            // txtTenFood
            // 
            this.txtTenFood.AutoSize = true;
            this.txtTenFood.BackColor = System.Drawing.Color.White;
            this.txtTenFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFood.ForeColor = System.Drawing.Color.Blue;
            this.txtTenFood.Location = new System.Drawing.Point(22, 169);
            this.txtTenFood.Name = "txtTenFood";
            this.txtTenFood.Size = new System.Drawing.Size(76, 25);
            this.txtTenFood.TabIndex = 5;
            this.txtTenFood.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(141, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Location = new System.Drawing.Point(9, 106);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(70, 24);
            this.btnThemAnh.TabIndex = 7;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(141, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDoiGia
            // 
            this.txtDoiGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDoiGia.Location = new System.Drawing.Point(10, 136);
            this.txtDoiGia.Name = "txtDoiGia";
            this.txtDoiGia.Size = new System.Drawing.Size(199, 29);
            this.txtDoiGia.TabIndex = 9;
            this.txtDoiGia.TextChanged += new System.EventHandler(this.txtDoiGia_TextChanged);
            // 
            // txtDoiTen
            // 
            this.txtDoiTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDoiTen.Location = new System.Drawing.Point(10, 167);
            this.txtDoiTen.Name = "txtDoiTen";
            this.txtDoiTen.Size = new System.Drawing.Size(199, 29);
            this.txtDoiTen.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 33);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picturebox1
            // 
            this.picturebox1.BackgroundImage = global::APP_KHACH_CHUAN.Properties.Resources.noimage;
            this.picturebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox1.Location = new System.Drawing.Point(10, 5);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(125, 125);
            this.picturebox1.TabIndex = 0;
            this.picturebox1.TabStop = false;
            this.picturebox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // itemFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDoiTen);
            this.Controls.Add(this.txtDoiGia);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTenFood);
            this.Controls.Add(this.txtGiaFood);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.btnThem);
            this.Name = "itemFood";
            this.Size = new System.Drawing.Size(212, 196);
            this.Load += new System.EventHandler(this.itemFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label txtGiaFood;
        private System.Windows.Forms.Label txtTenFood;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDoiGia;
        private System.Windows.Forms.TextBox txtDoiTen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
