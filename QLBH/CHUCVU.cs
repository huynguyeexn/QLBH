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

namespace QLBH
{
    public partial class CHUCVU : Form
    {
        public CHUCVU()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        public void Loaddulieu()
        {
            string sql = "Select * from CHUCVU";
            dtgv.DataSource = kn.taobang(sql);
        }

          
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_macv.Text == "" || txt_tencv.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bt_them.Enabled = false;
                string s = "select * from CHUCVU where MACV='" + txt_macv.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themcv(txt_macv.Text, txt_tencv.Text);
                    txt_macv.ResetText();
                    txt_tencv.ResetText();
                    txt_macv.Focus();
                    Loaddulieu();
                    new NHANVIEN().load();
                }
                else
                {
                    MessageBox.Show("Mã CHỨC VỤ đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void CHUCVU_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();
        
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        kn.xoacv(chon);
                        new NHANVIEN().load();
                    }
                    catch
                    {
                        MessageBox.Show("Mã chức vụ đang được sử dụng ở bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Loaddulieu();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        string chon;
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString();
                txt_macv.Text = row.Cells[0].Value.ToString();
                txt_tencv.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Loaddulieu();
            txt_macv.ResetText();
            txt_tencv.ResetText();
            this.bt_huy.Enabled = true;
            this.bt_luu.Enabled = true;
            this.bt_them.Enabled = true;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMã chức vụ: " + txt_macv.Text +
                    "\nTên chức vụ: " + txt_tencv.Text, "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suacv(chon, txt_macv.Text, txt_tencv.Text);
                    Loaddulieu();
                    new NHANVIEN().load();
                }
                else if (result == DialogResult.No)
                {

                }

            }
            else
            {
                MessageBox.Show("Hãy chọn dòng cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
