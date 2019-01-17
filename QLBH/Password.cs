using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        string username;
        private void btn_dmk_Click(object sender, EventArgs e)
        {
            if (txt_xacnhanmk.Text != txt_mkmoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không giống nhau", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string s = "select * from dangky where username='" + username.Trim() + "'and password='" + txt_mkcu.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count != 0)
                {
                    kn.doimk(username, txt_mkmoi.Text);
                    this.Close();
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }
            }
        }

        private void Password_Load(object sender, EventArgs e)
        {
            kn.connect();
            Main form_main = new Main();
            username = form_main.getUsername();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hienmatkhau.Checked)
            {
                txt_mkcu.UseSystemPasswordChar = false;
                txt_mkmoi.UseSystemPasswordChar = false;
                txt_xacnhanmk.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mkcu.UseSystemPasswordChar = true;
                txt_mkmoi.UseSystemPasswordChar = true;
                txt_xacnhanmk.UseSystemPasswordChar = true;
            }
        }
    }
}
