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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        Connecting kn = new Connecting();
        private void btn_dangky_Click(object sender, EventArgs e)
        {

            string s = "select * from DANGKY where USERNAME='" + username.Trim() + "' and  password='"+txt_password.Text+"'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);

            if (txt_hoten.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các thông tin bắt buộc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dt.Rows.Count != 0)
                {
                    kn.updatetk(username.Trim(), txt_hoten.Text, txt_sdt.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_cmnd.Text);
                    this.Close();
                    MessageBox.Show("Bạn đã cập nhật thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_password.Focus();
                }
            }
        }
        string username = null;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            kn.connect();
            Main form_main = new Main();
            username = form_main.getUsername();
        }
    }
}
