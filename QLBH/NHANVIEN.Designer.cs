﻿namespace QLBH
{
    partial class NHANVIEN
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
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_macv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mucluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(194, 147);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(177, 24);
            this.cb_gioitinh.TabIndex = 1;
            // 
            // ngaysinh
            // 
            this.ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinh.Location = new System.Drawing.Point(194, 177);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(177, 22);
            this.ngaysinh.TabIndex = 2;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(103, 471);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 8;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(589, 471);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 14;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(508, 471);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 13;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(427, 471);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 12;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(346, 471);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 11;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(265, 471);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 10;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(184, 471);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 9;
            this.bt_them.Text = "Mới";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(21, 271);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(742, 179);
            this.dtgv.TabIndex = 66;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(507, 91);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(177, 22);
            this.txt_sdt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "SĐT";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(194, 204);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(177, 22);
            this.txt_diachi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Địa chỉ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(84, 147);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 17);
            this.label.TabIndex = 47;
            this.label.Tag = "";
            this.label.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(194, 119);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(177, 22);
            this.txt_hoten.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Họ Tên";
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(194, 91);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(177, 22);
            this.txt_manv.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(174, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 45;
            this.label9.Tag = "";
            this.label9.Text = "Mã chức vụ";
            // 
            // cb_macv
            // 
            this.cb_macv.FormattingEnabled = true;
            this.cb_macv.Location = new System.Drawing.Point(507, 175);
            this.cb_macv.Name = "cb_macv";
            this.cb_macv.Size = new System.Drawing.Size(179, 24);
            this.cb_macv.TabIndex = 7;
            this.cb_macv.DropDown += new System.EventHandler(this.cb_macv_DropDown);
            this.cb_macv.SelectedIndexChanged += new System.EventHandler(this.cb_macv_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ngày vào làm";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(507, 119);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 45;
            this.label8.Tag = "";
            this.label8.Text = "Mức lương";
            // 
            // txt_mucluong
            // 
            this.txt_mucluong.Location = new System.Drawing.Point(507, 147);
            this.txt_mucluong.Name = "txt_mucluong";
            this.txt_mucluong.Size = new System.Drawing.Size(177, 22);
            this.txt_mucluong.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(304, 17);
            this.label10.TabIndex = 45;
            this.label10.Tag = "";
            this.label10.Text = "* mã nhân viên sẽ tự động tăng khi bạn lưu mới";
            // 
            // NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 550);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.cb_macv);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_mucluong);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "NHANVIEN";
            this.Text = "NHANVIEN";
            this.Load += new System.EventHandler(this.NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_macv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mucluong;
        private System.Windows.Forms.Label label10;
    }
}