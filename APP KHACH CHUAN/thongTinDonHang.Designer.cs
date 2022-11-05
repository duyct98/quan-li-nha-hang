namespace APP_KHACH_CHUAN
{
    partial class thongTinDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongTinDonHang));
            this.panelDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongBiil = new System.Windows.Forms.Label();
            this.txtDonHangID = new System.Windows.Forms.Label();
            this.btnHoanThanhDonHang = new System.Windows.Forms.Button();
            this.btnThuNho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDonHang
            // 
            resources.ApplyResources(this.panelDonHang, "panelDonHang");
            this.panelDonHang.Name = "panelDonHang";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTongBiil
            // 
            resources.ApplyResources(this.txtTongBiil, "txtTongBiil");
            this.txtTongBiil.Name = "txtTongBiil";
            // 
            // txtDonHangID
            // 
            resources.ApplyResources(this.txtDonHangID, "txtDonHangID");
            this.txtDonHangID.Name = "txtDonHangID";
            // 
            // btnHoanThanhDonHang
            // 
            this.btnHoanThanhDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnHoanThanhDonHang, "btnHoanThanhDonHang");
            this.btnHoanThanhDonHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHoanThanhDonHang.Name = "btnHoanThanhDonHang";
            this.btnHoanThanhDonHang.UseVisualStyleBackColor = false;
            this.btnHoanThanhDonHang.Click += new System.EventHandler(this.btnHoanThanhDonHang_Click);
            // 
            // btnThuNho
            // 
            resources.ApplyResources(this.btnThuNho, "btnThuNho");
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.UseVisualStyleBackColor = true;
            this.btnThuNho.Click += new System.EventHandler(this.button1_Click);
            // 
            // thongTinDonHang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ControlBox = false;
            this.Controls.Add(this.btnHoanThanhDonHang);
            this.Controls.Add(this.btnThuNho);
            this.Controls.Add(this.txtDonHangID);
            this.Controls.Add(this.txtTongBiil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDonHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "thongTinDonHang";
            this.Load += new System.EventHandler(this.thongTinDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTongBiil;
        private System.Windows.Forms.Label txtDonHangID;
        private System.Windows.Forms.Button btnHoanThanhDonHang;
        private System.Windows.Forms.Button btnThuNho;
    }
}