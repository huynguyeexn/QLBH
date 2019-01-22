namespace QLBH
{
    partial class HOADON
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
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_makh = new System.Windows.Forms.Label();
            this.lb_sohd = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.cb_makh = new System.Windows.Forms.ComboBox();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sohd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ngaylaphd = new System.Windows.Forms.DateTimePicker();
            this.lb_ngaylaphd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(507, 84);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(12, 17);
            this.lb_manv.TabIndex = 120;
            this.lb_manv.Text = " ";
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Location = new System.Drawing.Point(199, 112);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(12, 17);
            this.lb_makh.TabIndex = 119;
            this.lb_makh.Text = " ";
            // 
            // lb_sohd
            // 
            this.lb_sohd.AutoSize = true;
            this.lb_sohd.Location = new System.Drawing.Point(199, 84);
            this.lb_sohd.Name = "lb_sohd";
            this.lb_sohd.Size = new System.Drawing.Size(12, 17);
            this.lb_sohd.TabIndex = 118;
            this.lb_sohd.Text = " ";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao.Location = new System.Drawing.Point(348, 146);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(110, 20);
            this.lb_thongbao.TabIndex = 117;
            this.lb_thongbao.Text = "lb_thongbao";
            // 
            // cb_makh
            // 
            this.cb_makh.FormattingEnabled = true;
            this.cb_makh.Location = new System.Drawing.Point(202, 109);
            this.cb_makh.Name = "cb_makh";
            this.cb_makh.Size = new System.Drawing.Size(177, 24);
            this.cb_makh.TabIndex = 116;
            this.cb_makh.Visible = false;
            // 
            // cb_manv
            // 
            this.cb_manv.Items.AddRange(new object[] {
            "Cây",
            "Quyển",
            "Hộp",
            "Thùng"});
            this.cb_manv.Location = new System.Drawing.Point(510, 81);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(177, 24);
            this.cb_manv.TabIndex = 99;
            this.cb_manv.Visible = false;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(322, 383);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 101;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(403, 436);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 107;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(322, 436);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 106;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.LightCoral;
            this.bt_huy.ForeColor = System.Drawing.Color.Black;
            this.bt_huy.Location = new System.Drawing.Point(403, 383);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 105;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(282, 383);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 104;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.LightCoral;
            this.bt_xoa.Location = new System.Drawing.Point(444, 383);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 103;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(363, 383);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 102;
            this.bt_them.Text = "Mới";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(29, 183);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(742, 179);
            this.dtgv.TabIndex = 115;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(400, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 17);
            this.label.TabIndex = 112;
            this.label.Tag = "";
            this.label.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 111;
            this.label4.Text = "Ngày lập HĐ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Mã khách hàng:";
            // 
            // txt_sohd
            // 
            this.txt_sohd.Location = new System.Drawing.Point(202, 84);
            this.txt_sohd.Name = "txt_sohd";
            this.txt_sohd.Size = new System.Drawing.Size(177, 22);
            this.txt_sohd.TabIndex = 109;
            this.txt_sohd.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(182, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 29);
            this.label6.TabIndex = 108;
            this.label6.Text = "CẬP NHẬT THÔNG TIN HOÁ ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "Số hoá đơn:";
            // 
            // ngaylaphd
            // 
            this.ngaylaphd.CustomFormat = "dd/MM/yyyy";
            this.ngaylaphd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaylaphd.Location = new System.Drawing.Point(510, 111);
            this.ngaylaphd.Name = "ngaylaphd";
            this.ngaylaphd.Size = new System.Drawing.Size(177, 22);
            this.ngaylaphd.TabIndex = 122;
            this.ngaylaphd.Visible = false;
            // 
            // lb_ngaylaphd
            // 
            this.lb_ngaylaphd.AutoSize = true;
            this.lb_ngaylaphd.Location = new System.Drawing.Point(507, 112);
            this.lb_ngaylaphd.Name = "lb_ngaylaphd";
            this.lb_ngaylaphd.Size = new System.Drawing.Size(12, 17);
            this.lb_ngaylaphd.TabIndex = 123;
            this.lb_ngaylaphd.Text = " ";
            // 
            // HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lb_ngaylaphd);
            this.Controls.Add(this.ngaylaphd);
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.lb_makh);
            this.Controls.Add(this.lb_sohd);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.cb_makh);
            this.Controls.Add(this.cb_manv);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sohd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "HOADON";
            this.Text = "HOADON";
            this.Load += new System.EventHandler(this.HOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.Label lb_sohd;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.ComboBox cb_makh;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sohd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ngaylaphd;
        private System.Windows.Forms.Label lb_ngaylaphd;
    }
}