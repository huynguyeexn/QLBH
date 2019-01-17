using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace QLBH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        SqlConnection con;
        public void hiengiaodien()
        {
            Main gd = new Main();
            gd.ShowDialog();
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string s = "select * from DANGKY where USERNAME='"+ txt_tendangnhap.Text + "'or SODT ='"+txt_tendangnhap.Text+"' or CMND='"+ txt_tendangnhap.Text + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            string s1 = "select * from DANGKY where password='" + txt_matkhau.Text + "'";
            DataTable dt1 = new DataTable();
            dt1 = kn.taobang(s1);
            if (dt.Rows.Count != 0 && dt1.Rows.Count != 0)
            {
                Main form_main = new Main();
                form_main.User(txt_tendangnhap.Text);
                Thread th = new Thread(new ThreadStart(hiengiaodien));
                th.Start();
                this.Close();
            }
            else
            {

                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_tendangnhap.Clear();
                this.txt_matkhau.Clear();
                this.txt_tendangnhap.Focus();
            }
        }

        private void check_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hienmatkhau.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_tendangnhap.Focus();
            con = kn.ketnoi;
            con.Open();
}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().Show();
        }

        private void txt_tendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }

        private void btn_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }

        private void btn_thoat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dangnhap_Click(sender, e);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
