using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace QLBH
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string s = "select * from DANGKY where USERNAME='" + txt_tendangnhap.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            string s1 = "select * from DANGKY where sodt='" + txt_sdt.Text + "'";
            DataTable dt1 = new DataTable();
            dt1 = kn.taobang(s1);
            string s2 = "select * from DANGKY where cmnd='" + txt_cmnd.Text + "'";
            DataTable dt2 = new DataTable();
            dt2 = kn.taobang(s2);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_tendangnhap.Clear();
                this.txt_matkhau.Clear();
                this.txt_nhaplaimatkhau.Clear();
                this.txt_tendangnhap.Focus();
            }
            else if (dt1.Rows.Count != 0)
            {
                MessageBox.Show("Số điện thoại đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_sdt.Focus();
            }
            else if (dt2.Rows.Count != 0)
            {
                MessageBox.Show("Số CMND đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_cmnd.Focus();
            }
            else if (txt_matkhau.Text == "" || txt_nhaplaimatkhau.Text == "" || txt_tendangnhap.Text == "" || txt_hoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các thông tin bắt buộc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_matkhau.Text != txt_nhaplaimatkhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không giống nhau", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                kn.themdk(txt_tendangnhap.Text, txt_matkhau.Text,txt_hoten.Text, txt_sdt.Text , dateTimePicker1.Value.ToString("yyyy/MM/dd"),txt_diachi.Text,txt_cmnd.Text);
                this.Close();
                MessageBox.Show("Bạn đã đăng ký thành công, hãy đăng nhập", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
           kn.connect();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void check_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hienmatkhau.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
                txt_nhaplaimatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
                txt_nhaplaimatkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
