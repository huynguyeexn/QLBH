namespace QLBH
{
    partial class SANPHAM
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
            this.cb_dvt = new System.Windows.Forms.ComboBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_inds = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nuocsx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_dvt
            // 
            this.cb_dvt.Items.AddRange(new object[] {
            "Cây",
            "Quyển",
            "Hộp",
            "Thùng"});
            this.cb_dvt.Location = new System.Drawing.Point(202, 142);
            this.cb_dvt.Name = "cb_dvt";
            this.cb_dvt.Size = new System.Drawing.Size(177, 24);
            this.cb_dvt.TabIndex = 68;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(111, 415);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 33);
            this.bt_luu.TabIndex = 75;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(597, 415);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 33);
            this.bt_thoat.TabIndex = 81;
            this.bt_thoat.TabStop = false;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_inds
            // 
            this.bt_inds.Location = new System.Drawing.Point(516, 415);
            this.bt_inds.Name = "bt_inds";
            this.bt_inds.Size = new System.Drawing.Size(75, 33);
            this.bt_inds.TabIndex = 80;
            this.bt_inds.TabStop = false;
            this.bt_inds.Text = "In DS";
            this.bt_inds.UseVisualStyleBackColor = true;
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(435, 415);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 33);
            this.bt_huy.TabIndex = 79;
            this.bt_huy.TabStop = false;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(354, 415);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 33);
            this.bt_sua.TabIndex = 78;
            this.bt_sua.TabStop = false;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(273, 415);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 33);
            this.bt_xoa.TabIndex = 77;
            this.bt_xoa.TabStop = false;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(192, 415);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 33);
            this.bt_them.TabIndex = 76;
            this.bt_them.Text = "Mới";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(29, 215);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(742, 179);
            this.dtgv.TabIndex = 94;
            this.dtgv.TabStop = false;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(516, 114);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(177, 22);
            this.txt_dongia.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "Đơn giá";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(92, 142);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 17);
            this.label.TabIndex = 90;
            this.label.Tag = "";
            this.label.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Nước sản xuất";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(202, 114);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(177, 22);
            this.txt_tensp.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(202, 86);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(177, 22);
            this.txt_masp.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(182, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 29);
            this.label6.TabIndex = 82;
            this.label6.Text = "CẬP NHẬT THÔNG TIN SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "Mã sản phẩm";
            // 
            // cb_nuocsx
            // 
            this.cb_nuocsx.FormattingEnabled = true;
            this.cb_nuocsx.Location = new System.Drawing.Point(516, 78);
            this.cb_nuocsx.Name = "cb_nuocsx";
            this.cb_nuocsx.Size = new System.Drawing.Size(177, 24);
            this.cb_nuocsx.TabIndex = 95;
            // 
            // SANPHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.cb_nuocsx);
            this.Controls.Add(this.cb_dvt);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_inds);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "SANPHAM";
            this.Text = "SANPHAM";
            this.Load += new System.EventHandler(this.SANPHAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_dvt;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_inds;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nuocsx;
    }
}