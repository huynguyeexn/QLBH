namespace QLBH
{
    partial class Password
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_xacnhanmk = new System.Windows.Forms.TextBox();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dmk = new System.Windows.Forms.Button();
            this.check_hienmatkhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(104, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đổi mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txt_xacnhanmk
            // 
            this.txt_xacnhanmk.Location = new System.Drawing.Point(162, 125);
            this.txt_xacnhanmk.Name = "txt_xacnhanmk";
            this.txt_xacnhanmk.Size = new System.Drawing.Size(163, 22);
            this.txt_xacnhanmk.TabIndex = 3;
            this.txt_xacnhanmk.UseSystemPasswordChar = true;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(162, 97);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Size = new System.Drawing.Size(163, 22);
            this.txt_mkmoi.TabIndex = 2;
            this.txt_mkmoi.UseSystemPasswordChar = true;
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Location = new System.Drawing.Point(162, 69);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.Size = new System.Drawing.Size(163, 22);
            this.txt_mkcu.TabIndex = 1;
            this.txt_mkcu.UseSystemPasswordChar = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(206, 201);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dmk
            // 
            this.btn_dmk.Location = new System.Drawing.Point(51, 201);
            this.btn_dmk.Name = "btn_dmk";
            this.btn_dmk.Size = new System.Drawing.Size(136, 23);
            this.btn_dmk.TabIndex = 4;
            this.btn_dmk.Text = "Đổi mật khẩu";
            this.btn_dmk.UseVisualStyleBackColor = true;
            this.btn_dmk.Click += new System.EventHandler(this.btn_dmk_Click);
            // 
            // check_hienmatkhau
            // 
            this.check_hienmatkhau.AutoSize = true;
            this.check_hienmatkhau.Location = new System.Drawing.Point(111, 162);
            this.check_hienmatkhau.Name = "check_hienmatkhau";
            this.check_hienmatkhau.Size = new System.Drawing.Size(121, 21);
            this.check_hienmatkhau.TabIndex = 12;
            this.check_hienmatkhau.TabStop = false;
            this.check_hienmatkhau.Text = "Hiện mật khẩu";
            this.check_hienmatkhau.UseVisualStyleBackColor = false;
            this.check_hienmatkhau.CheckedChanged += new System.EventHandler(this.check_hienmatkhau_CheckedChanged);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 251);
            this.Controls.Add(this.check_hienmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_xacnhanmk);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dmk);
            this.Name = "Password";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_xacnhanmk;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.TextBox txt_mkcu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dmk;
        private System.Windows.Forms.CheckBox check_hienmatkhau;
    }
}