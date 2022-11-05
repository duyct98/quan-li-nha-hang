namespace CUAHANG
{
    partial class CUAHANG
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
            this.homePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btbThucUong = new System.Windows.Forms.Button();
            this.btnAnVat = new System.Windows.Forms.Button();
            this.btnMonAnChinh = new System.Windows.Forms.Button();
            this.btnRuouBia = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.orderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.AutoScroll = true;
            this.homePanel.Controls.Add(this.btnThemMon);
            this.homePanel.Location = new System.Drawing.Point(21, 100);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(697, 474);
            this.homePanel.TabIndex = 0;
            // 
            // btbThucUong
            // 
            this.btbThucUong.Location = new System.Drawing.Point(30, 78);
            this.btbThucUong.Name = "btbThucUong";
            this.btbThucUong.Size = new System.Drawing.Size(75, 23);
            this.btbThucUong.TabIndex = 1;
            this.btbThucUong.Text = "button1";
            this.btbThucUong.UseVisualStyleBackColor = true;
            this.btbThucUong.Click += new System.EventHandler(this.btbThucUong_Click);
            // 
            // btnAnVat
            // 
            this.btnAnVat.Location = new System.Drawing.Point(164, 82);
            this.btnAnVat.Name = "btnAnVat";
            this.btnAnVat.Size = new System.Drawing.Size(75, 23);
            this.btnAnVat.TabIndex = 2;
            this.btnAnVat.Text = "button2";
            this.btnAnVat.UseVisualStyleBackColor = true;
            this.btnAnVat.Click += new System.EventHandler(this.btnAnVat_Click);
            // 
            // btnMonAnChinh
            // 
            this.btnMonAnChinh.Location = new System.Drawing.Point(301, 78);
            this.btnMonAnChinh.Name = "btnMonAnChinh";
            this.btnMonAnChinh.Size = new System.Drawing.Size(75, 23);
            this.btnMonAnChinh.TabIndex = 3;
            this.btnMonAnChinh.Text = "button3";
            this.btnMonAnChinh.UseVisualStyleBackColor = true;
            this.btnMonAnChinh.Click += new System.EventHandler(this.btnMonAnChinh_Click);
            // 
            // btnRuouBia
            // 
            this.btnRuouBia.Location = new System.Drawing.Point(428, 78);
            this.btnRuouBia.Name = "btnRuouBia";
            this.btnRuouBia.Size = new System.Drawing.Size(75, 23);
            this.btnRuouBia.TabIndex = 4;
            this.btnRuouBia.Text = "button4";
            this.btnRuouBia.UseVisualStyleBackColor = true;
            this.btnRuouBia.Click += new System.EventHandler(this.btnRuouBia_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(3, 3);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(91, 196);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "button1";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderPanel
            // 
            this.orderPanel.AutoScroll = true;
            this.orderPanel.Location = new System.Drawing.Point(724, 100);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(530, 473);
            this.orderPanel.TabIndex = 5;
            // 
            // CUAHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 611);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.btnRuouBia);
            this.Controls.Add(this.btnMonAnChinh);
            this.Controls.Add(this.btnAnVat);
            this.Controls.Add(this.btbThucUong);
            this.Controls.Add(this.homePanel);
            this.Name = "CUAHANG";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CUAHANG_Load);
            this.homePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel homePanel;
        private System.Windows.Forms.Button btbThucUong;
        private System.Windows.Forms.Button btnAnVat;
        private System.Windows.Forms.Button btnMonAnChinh;
        private System.Windows.Forms.Button btnRuouBia;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.FlowLayoutPanel orderPanel;
    }
}

