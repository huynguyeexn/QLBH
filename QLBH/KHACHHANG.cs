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
    public partial class KHACHHANG : Form
    {
        public KHACHHANG()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        public void Loaddulieu()
        {
            string sql = "Select * from KHACHHANG";
            dtgv.DataSource = kn.taobang(sql);
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txt_tenkh.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string s = "select * from KHACHHANG where MAKH='" + txt_makh.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themkh(txt_makh.Text, txt_tenkh.Text, txt_diachi.Text, txt_sdt.Text);
                    txt_makh.ResetText();
                    txt_diachi.ResetText();
                    txt_sdt.ResetText();
                    txt_tenkh.ResetText();
                    txt_makh.Focus();
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Mã KHÁCH HÀNG đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_diachi.ResetText();
            txt_makh.ResetText();
            txt_sdt.ResetText();
            txt_tenkh.ResetText();
            txt_makh.Focus();
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
                        kn.xoakh(chon);

                    }
                    catch
                    {
                        MessageBox.Show("Mã KHÁCH HÀNG đang được sử dụng ở bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txt_makh.Text = row.Cells[0].Value.ToString();
                txt_tenkh.Text = row.Cells[1].Value.ToString();
                txt_diachi.Text = row.Cells[2].Value.ToString();
                txt_sdt.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                chon = null;
            }
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMã khách hàng: " + txt_makh.Text +
                    "\nTên khách hàng: " + txt_tenkh.Text +
                    "\nĐịa chỉ: " + txt_diachi.Text +
                    "\nSĐT: " + txt_sdt.Text, "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suakh(chon, txt_makh.Text, txt_tenkh.Text, txt_diachi.Text, txt_sdt.Text);
                    Loaddulieu();
                    

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
