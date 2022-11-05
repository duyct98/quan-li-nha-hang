namespace APP_KHACH_CHUAN
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.homePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.labelGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.panelDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelHoaDon = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRuouBia = new System.Windows.Forms.Button();
            this.btnMonChinh = new System.Windows.Forms.Button();
            this.btnAnVat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThucUong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongHoaDon = new System.Windows.Forms.Label();
            this.txtDiaChiKhach = new System.Windows.Forms.TextBox();
            this.txtSDTKhach = new System.Windows.Forms.TextBox();
            this.txtEmailKhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.txtdonhangid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.DataThongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupQUANLI = new System.Windows.Forms.GroupBox();
            this.btnDanhChoQuanLy = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnThemItem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnChinhSuaFOOD = new System.Windows.Forms.Button();
            this.DonHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TênHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupMatKhauQuanLY = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnHuyXacNhan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataThongTinHoaDon)).BeginInit();
            this.GroupQUANLI.SuspendLayout();
            this.groupMatKhauQuanLY.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.AutoScroll = true;
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.homePanel.Location = new System.Drawing.Point(0, 78);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(893, 498);
            this.homePanel.TabIndex = 0;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(898, 543);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(228, 32);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Tiến hành đặt món";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHuyDon.Location = new System.Drawing.Point(1132, 543);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(303, 32);
            this.btnHuyDon.TabIndex = 3;
            this.btnHuyDon.Text = "Hủy Đơn Hàng";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.BackColor = System.Drawing.SystemColors.Control;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGia.Location = new System.Drawing.Point(909, 511);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(159, 24);
            this.labelGia.TabIndex = 4;
            this.labelGia.Text = "Tổng Đơn Hàng";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtGia.Location = new System.Drawing.Point(1132, 511);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(243, 29);
            this.txtGia.TabIndex = 5;
            this.txtGia.Text = "0";
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // panelDonHang
            // 
            this.panelDonHang.AllowDrop = true;
            this.panelDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelDonHang.AutoScroll = true;
            this.panelDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDonHang.Location = new System.Drawing.Point(898, 78);
            this.panelDonHang.Name = "panelDonHang";
            this.panelDonHang.Size = new System.Drawing.Size(230, 425);
            this.panelDonHang.TabIndex = 7;
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.label14);
            this.groupMenu.Controls.Add(this.label13);
            this.groupMenu.Controls.Add(this.panelHoaDon);
            this.groupMenu.Controls.Add(this.btnRuouBia);
            this.groupMenu.Controls.Add(this.btnMonChinh);
            this.groupMenu.Controls.Add(this.btnAnVat);
            this.groupMenu.Controls.Add(this.label1);
            this.groupMenu.Controls.Add(this.btnThucUong);
            this.groupMenu.Controls.Add(this.homePanel);
            this.groupMenu.Controls.Add(this.panelDonHang);
            this.groupMenu.Controls.Add(this.txtGia);
            this.groupMenu.Controls.Add(this.labelGia);
            this.groupMenu.Controls.Add(this.btnHuyDon);
            this.groupMenu.Controls.Add(this.btnThanhToan);
            this.groupMenu.Location = new System.Drawing.Point(12, 45);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(1531, 599);
            this.groupMenu.TabIndex = 9;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "MENU";
            this.groupMenu.Enter += new System.EventHandler(this.groupMenu_Enter);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1134, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 37);
            this.label14.TabIndex = 17;
            this.label14.Text = "ĐƠN HÀNG ĐANG CHỜ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(898, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 37);
            this.label13.TabIndex = 17;
            this.label13.Text = "ĐƠN HÀNG";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelHoaDon.Location = new System.Drawing.Point(1134, 78);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(298, 427);
            this.panelHoaDon.TabIndex = 13;
            this.panelHoaDon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHoaDon_Paint);
            // 
            // btnRuouBia
            // 
            this.btnRuouBia.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnRuouBia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRuouBia.FlatAppearance.BorderSize = 0;
            this.btnRuouBia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuouBia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRuouBia.Location = new System.Drawing.Point(664, 39);
            this.btnRuouBia.Name = "btnRuouBia";
            this.btnRuouBia.Size = new System.Drawing.Size(229, 36);
            this.btnRuouBia.TabIndex = 11;
            this.btnRuouBia.Text = "RƯỢU - BIA";
            this.btnRuouBia.UseVisualStyleBackColor = false;
            this.btnRuouBia.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMonChinh
            // 
            this.btnMonChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMonChinh.FlatAppearance.BorderSize = 0;
            this.btnMonChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMonChinh.Location = new System.Drawing.Point(426, 39);
            this.btnMonChinh.Name = "btnMonChinh";
            this.btnMonChinh.Size = new System.Drawing.Size(232, 36);
            this.btnMonChinh.TabIndex = 10;
            this.btnMonChinh.Text = "MÓN ĂN CHÍNH";
            this.btnMonChinh.UseVisualStyleBackColor = false;
            this.btnMonChinh.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAnVat
            // 
            this.btnAnVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnVat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAnVat.FlatAppearance.BorderSize = 0;
            this.btnAnVat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnVat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAnVat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnVat.Location = new System.Drawing.Point(246, 39);
            this.btnAnVat.Name = "btnAnVat";
            this.btnAnVat.Size = new System.Drawing.Size(174, 36);
            this.btnAnVat.TabIndex = 9;
            this.btnAnVat.Text = "ĂN VẶT";
            this.btnAnVat.UseVisualStyleBackColor = false;
            this.btnAnVat.Click += new System.EventHandler(this.btnAnVat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1382, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "VND";
            // 
            // btnThucUong
            // 
            this.btnThucUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThucUong.FlatAppearance.BorderSize = 0;
            this.btnThucUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucUong.Location = new System.Drawing.Point(0, 39);
            this.btnThucUong.Name = "btnThucUong";
            this.btnThucUong.Size = new System.Drawing.Size(240, 36);
            this.btnThucUong.TabIndex = 0;
            this.btnThucUong.Text = "THỨC UỐNG";
            this.btnThucUong.UseVisualStyleBackColor = false;
            this.btnThucUong.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongHoaDon);
            this.groupBox1.Controls.Add(this.txtDiaChiKhach);
            this.groupBox1.Controls.Add(this.txtSDTKhach);
            this.groupBox1.Controls.Add(this.txtEmailKhach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtdonhangid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 169);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN TRÊN HOÁ ĐƠN";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.AutoSize = true;
            this.txtTongHoaDon.Location = new System.Drawing.Point(963, 44);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(56, 20);
            this.txtTongHoaDon.TabIndex = 9;
            this.txtTongHoaDon.Text = "0 VND";
            // 
            // txtDiaChiKhach
            // 
            this.txtDiaChiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKhach.Location = new System.Drawing.Point(586, 119);
            this.txtDiaChiKhach.Name = "txtDiaChiKhach";
            this.txtDiaChiKhach.Size = new System.Drawing.Size(359, 26);
            this.txtDiaChiKhach.TabIndex = 8;
            // 
            // txtSDTKhach
            // 
            this.txtSDTKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKhach.Location = new System.Drawing.Point(586, 90);
            this.txtSDTKhach.Name = "txtSDTKhach";
            this.txtSDTKhach.Size = new System.Drawing.Size(359, 26);
            this.txtSDTKhach.TabIndex = 7;
            // 
            // txtEmailKhach
            // 
            this.txtEmailKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailKhach.Location = new System.Drawing.Point(586, 57);
            this.txtEmailKhach.Name = "txtEmailKhach";
            this.txtEmailKhach.Size = new System.Drawing.Size(359, 26);
            this.txtEmailKhach.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(457, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(457, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(457, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(963, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tổng tiền hoá đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(457, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã hoá đơn";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(126, 123);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(325, 26);
            this.txtTenNhanVien.TabIndex = 4;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(586, 24);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(359, 26);
            this.txtTenKhach.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(126, 90);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(325, 26);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayBan.Location = new System.Drawing.Point(126, 57);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(325, 26);
            this.txtNgayBan.TabIndex = 1;
            // 
            // txtdonhangid
            // 
            this.txtdonhangid.Enabled = false;
            this.txtdonhangid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonhangid.Location = new System.Drawing.Point(126, 24);
            this.txtdonhangid.Name = "txtdonhangid";
            this.txtdonhangid.Size = new System.Drawing.Size(325, 26);
            this.txtdonhangid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dataHoaDon);
            this.groupBox2.Controls.Add(this.DataThongTinHoaDon);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(7, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1145, 369);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sắp xếp tăng dần theo tổng tiền hoá đơn",
            "Sắp xếp giảm dần theo tổng tiền hoá đơn",
            "Ngày hôm nay",
            "1 Tháng gần nhất",
            "3 Tháng gần nhất"});
            this.comboBox1.Location = new System.Drawing.Point(82, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Sắp xếp theo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToAddRows = false;
            this.dataHoaDon.AllowUserToDeleteRows = false;
            this.dataHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonHangID,
            this.tongbill,
            this.NgayBan});
            this.dataHoaDon.Location = new System.Drawing.Point(6, 51);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.ShowCellErrors = false;
            this.dataHoaDon.ShowCellToolTips = false;
            this.dataHoaDon.ShowEditingIcon = false;
            this.dataHoaDon.ShowRowErrors = false;
            this.dataHoaDon.Size = new System.Drawing.Size(531, 312);
            this.dataHoaDon.TabIndex = 1;
            this.dataHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDon_CellContentClick);
            // 
            // DataThongTinHoaDon
            // 
            this.DataThongTinHoaDon.AllowUserToAddRows = false;
            this.DataThongTinHoaDon.AllowUserToDeleteRows = false;
            this.DataThongTinHoaDon.AllowUserToResizeColumns = false;
            this.DataThongTinHoaDon.AllowUserToResizeRows = false;
            this.DataThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HangID,
            this.TênHang,
            this.SoLuong,
            this.DonGia});
            this.DataThongTinHoaDon.Location = new System.Drawing.Point(559, 51);
            this.DataThongTinHoaDon.Name = "DataThongTinHoaDon";
            this.DataThongTinHoaDon.Size = new System.Drawing.Size(580, 312);
            this.DataThongTinHoaDon.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(555, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Thông tin hàng bán";
            // 
            // GroupQUANLI
            // 
            this.GroupQUANLI.Controls.Add(this.groupBox2);
            this.GroupQUANLI.Controls.Add(this.groupBox1);
            this.GroupQUANLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupQUANLI.Location = new System.Drawing.Point(101, 44);
            this.GroupQUANLI.Name = "GroupQUANLI";
            this.GroupQUANLI.Size = new System.Drawing.Size(1313, 569);
            this.GroupQUANLI.TabIndex = 12;
            this.GroupQUANLI.TabStop = false;
            this.GroupQUANLI.Text = " ";
            this.GroupQUANLI.Enter += new System.EventHandler(this.GroupQUANLI_Enter);
            // 
            // btnDanhChoQuanLy
            // 
            this.btnDanhChoQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhChoQuanLy.Location = new System.Drawing.Point(914, 11);
            this.btnDanhChoQuanLy.Name = "btnDanhChoQuanLy";
            this.btnDanhChoQuanLy.Size = new System.Drawing.Size(233, 39);
            this.btnDanhChoQuanLy.TabIndex = 13;
            this.btnDanhChoQuanLy.Text = "DÀNH CHO QUẢN LÝ";
            this.btnDanhChoQuanLy.UseVisualStyleBackColor = true;
            this.btnDanhChoQuanLy.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // btnThemItem
            // 
            this.btnThemItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemItem.Location = new System.Drawing.Point(772, 11);
            this.btnThemItem.Name = "btnThemItem";
            this.btnThemItem.Size = new System.Drawing.Size(133, 39);
            this.btnThemItem.TabIndex = 15;
            this.btnThemItem.Text = "Thêm Item bán";
            this.btnThemItem.UseVisualStyleBackColor = true;
            this.btnThemItem.Click += new System.EventHandler(this.btnThemItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ngày đặt hàng";
            // 
            // btnChinhSuaFOOD
            // 
            this.btnChinhSuaFOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaFOOD.Location = new System.Drawing.Point(587, 12);
            this.btnChinhSuaFOOD.Name = "btnChinhSuaFOOD";
            this.btnChinhSuaFOOD.Size = new System.Drawing.Size(179, 38);
            this.btnChinhSuaFOOD.TabIndex = 14;
            this.btnChinhSuaFOOD.Text = "CHỈNH SỬA Item bán";
            this.btnChinhSuaFOOD.UseVisualStyleBackColor = true;
            this.btnChinhSuaFOOD.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // DonHangID
            // 
            this.DonHangID.DataPropertyName = "DonHangID";
            this.DonHangID.FillWeight = 10F;
            this.DonHangID.HeaderText = "Đơn hàng ID";
            this.DonHangID.MinimumWidth = 100;
            this.DonHangID.Name = "DonHangID";
            this.DonHangID.Width = 140;
            // 
            // tongbill
            // 
            this.tongbill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tongbill.DataPropertyName = "tongbill";
            dataGridViewCellStyle15.Format = "#,###";
            this.tongbill.DefaultCellStyle = dataGridViewCellStyle15;
            this.tongbill.FillWeight = 10F;
            this.tongbill.HeaderText = "Tổng tiền hoá đơn";
            this.tongbill.Name = "tongbill";
            this.tongbill.Width = 170;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.FillWeight = 10F;
            this.NgayBan.HeaderText = "Ngày xuất hoá đơn";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 180;
            // 
            // HangID
            // 
            this.HangID.DataPropertyName = "HangID";
            this.HangID.HeaderText = "Hàng ID";
            this.HangID.Name = "HangID";
            // 
            // TênHang
            // 
            this.TênHang.DataPropertyName = "TenHang";
            this.TênHang.HeaderText = "Tên mặt hàng";
            this.TênHang.Name = "TênHang";
            this.TênHang.Width = 180;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle16.Format = "#,###";
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle16;
            this.DonGia.HeaderText = "Giá tiền";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 160;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Hoá đơn";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(1304, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 39);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.Location = new System.Drawing.Point(1150, 11);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(148, 39);
            this.btnDangXuat.TabIndex = 18;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupMatKhauQuanLY
            // 
            this.groupMatKhauQuanLY.Controls.Add(this.btnHuyXacNhan);
            this.groupMatKhauQuanLY.Controls.Add(this.btnTiepTuc);
            this.groupMatKhauQuanLY.Controls.Add(this.txtPass);
            this.groupMatKhauQuanLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatKhauQuanLY.Location = new System.Drawing.Point(600, 286);
            this.groupMatKhauQuanLY.Name = "groupMatKhauQuanLY";
            this.groupMatKhauQuanLY.Size = new System.Drawing.Size(260, 100);
            this.groupMatKhauQuanLY.TabIndex = 19;
            this.groupMatKhauQuanLY.TabStop = false;
            this.groupMatKhauQuanLY.Text = "Mật khẩu quản lý";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(11, 25);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(243, 26);
            this.txtPass.TabIndex = 0;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(172, 57);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(82, 35);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHuyXacNhan
            // 
            this.btnHuyXacNhan.Location = new System.Drawing.Point(11, 57);
            this.btnHuyXacNhan.Name = "btnHuyXacNhan";
            this.btnHuyXacNhan.Size = new System.Drawing.Size(96, 35);
            this.btnHuyXacNhan.TabIndex = 2;
            this.btnHuyXacNhan.Text = "Huỷ";
            this.btnHuyXacNhan.UseVisualStyleBackColor = true;
            this.btnHuyXacNhan.Click += new System.EventHandler(this.btnHuyXacNhan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(914, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(233, 39);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 625);
            this.Controls.Add(this.btnDanhChoQuanLy);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupMatKhauQuanLY);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChinhSuaFOOD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnThemItem);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.GroupQUANLI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataThongTinHoaDon)).EndInit();
            this.GroupQUANLI.ResumeLayout(false);
            this.groupMatKhauQuanLY.ResumeLayout(false);
            this.groupMatKhauQuanLY.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel homePanel;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.FlowLayoutPanel panelDonHang;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.Button btnThucUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRuouBia;
        private System.Windows.Forms.Button btnMonChinh;
        private System.Windows.Forms.Button btnAnVat;
        private System.Windows.Forms.FlowLayoutPanel panelHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChiKhach;
        private System.Windows.Forms.TextBox txtSDTKhach;
        private System.Windows.Forms.TextBox txtEmailKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.TextBox txtdonhangid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.DataGridView DataThongTinHoaDon;
        private System.Windows.Forms.Label txtTongHoaDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GroupQUANLI;
        private System.Windows.Forms.Button btnDanhChoQuanLy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnThemItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnChinhSuaFOOD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TênHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox groupMatKhauQuanLY;
        private System.Windows.Forms.Button btnHuyXacNhan;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnBack;
    }
}

