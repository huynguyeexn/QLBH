namespace QLBH
{
    partial class KHACHHANG
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
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(52, 367);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 65;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(539, 367);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 62;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(458, 367);
            this.bt_inds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 61;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(378, 367);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 60;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(296, 367);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 59;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(215, 367);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 58;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(134, 367);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 63;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(42, 162);
            this.dtgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(597, 178);
            this.dtgv.TabIndex = 64;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(152, 67);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(177, 22);
            this.txt_tenkh.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên khách hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(152, 39);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(177, 22);
            this.txt_makh.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(152, 96);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(177, 22);
            this.txt_diachi.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(152, 124);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(177, 22);
            this.txt_sdt.TabIndex = 57;
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "KHACHHANG";
            this.Text = "KHACHHANG";
            this.Load += new System.EventHandler(this.KHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sdt;
    }
}