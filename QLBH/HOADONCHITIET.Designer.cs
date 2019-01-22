namespace QLBH
{
    partial class HOADONCHITIET
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
            this.lb_soluong = new System.Windows.Forms.Label();
            this.lb_masp = new System.Windows.Forms.Label();
            this.lb_sohd = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.cb_masp = new System.Windows.Forms.ComboBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cb_sohd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Location = new System.Drawing.Point(503, 74);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(12, 17);
            this.lb_soluong.TabIndex = 143;
            this.lb_soluong.Text = " ";
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.Location = new System.Drawing.Point(199, 102);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(12, 17);
            this.lb_masp.TabIndex = 142;
            this.lb_masp.Text = " ";
            // 
            // lb_sohd
            // 
            this.lb_sohd.AutoSize = true;
            this.lb_sohd.Location = new System.Drawing.Point(199, 74);
            this.lb_sohd.Name = "lb_sohd";
            this.lb_sohd.Size = new System.Drawing.Size(12, 17);
            this.lb_sohd.TabIndex = 141;
            this.lb_sohd.Text = " ";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao.Location = new System.Drawing.Point(348, 136);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(110, 20);
            this.lb_thongbao.TabIndex = 140;
            this.lb_thongbao.Text = "lb_thongbao";
            // 
            // cb_masp
            // 
            this.cb_masp.FormattingEnabled = true;
            this.cb_masp.Location = new System.Drawing.Point(202, 99);
            this.cb_masp.Name = "cb_masp";
            this.cb_masp.Size = new System.Drawing.Size(177, 24);
            this.cb_masp.TabIndex = 139;
            this.cb_masp.Visible = false;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(322, 373);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 125;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(403, 426);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 131;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(322, 426);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 130;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.LightCoral;
            this.bt_huy.ForeColor = System.Drawing.Color.Black;
            this.bt_huy.Location = new System.Drawing.Point(403, 373);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 129;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(282, 373);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 128;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.LightCoral;
            this.bt_xoa.Location = new System.Drawing.Point(444, 373);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 127;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(363, 373);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 126;
            this.bt_them.Text = "Mới";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(29, 173);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(742, 179);
            this.dtgv.TabIndex = 138;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(400, 74);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 17);
            this.label.TabIndex = 136;
            this.label.Tag = "";
            this.label.Text = "Sô lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 134;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(135, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 29);
            this.label6.TabIndex = 132;
            this.label6.Text = "CẬP NHẬT THÔNG TIN HOÁ ĐƠN CHI TIẾT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 137;
            this.label2.Text = "Số hoá đơn:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(503, 72);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(177, 22);
            this.txt_soluong.TabIndex = 145;
            this.txt_soluong.Visible = false;
            // 
            // cb_sohd
            // 
            this.cb_sohd.FormattingEnabled = true;
            this.cb_sohd.Location = new System.Drawing.Point(202, 71);
            this.cb_sohd.Name = "cb_sohd";
            this.cb_sohd.Size = new System.Drawing.Size(177, 24);
            this.cb_sohd.TabIndex = 139;
            this.cb_sohd.Visible = false;
            // 
            // HOADONCHITIET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.lb_soluong);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.lb_masp);
            this.Controls.Add(this.lb_sohd);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.cb_sohd);
            this.Controls.Add(this.cb_masp);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "HOADONCHITIET";
            this.Text = "HOADONCHITIET";
            this.Load += new System.EventHandler(this.HOADONCHITIET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label lb_masp;
        private System.Windows.Forms.Label lb_sohd;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.ComboBox cb_masp;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ComboBox cb_sohd;
    }
}