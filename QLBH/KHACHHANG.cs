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

        #region function
        public void Loaddulieu()
        {
            string sql = "Select * from KHACHHANG";
            dtgv.DataSource = kn.taobang(sql);
        }
        void xoa_lb()
        {
            lb_diachi.ResetText();
            lb_makh.ResetText();
            lb_sdt.ResetText();
            lb_tenkh.ResetText();
        }

        // ẩn các button
        void an_btn()
        {
            bt_luu.Visible = false;
            bt_huy.Visible = false;
            bt_xoa.Visible = false;
            bt_sua.Visible = false;
            bt_them.Visible = false;

        }

        // ẩn các textbox
        void an_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Visible = false;
        }

        // hiện các textbox lên
        void hien_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Visible = true;
        }

        // xoá text trong các textbox
        void reset_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        // hiện thông báo với text được truyền vào
        private void thongbao(string a)
        {
            lb_thongbao.Text = a;
            Timer t1 = new Timer();
            t1.Interval = 3000; // tạm dừng 3000 = 3 second
            t1.Tick += (s, e) =>
            {
                lb_thongbao.ResetText();
                t1.Stop();
            };
            t1.Start();
        }


        #endregion

        private void bt_luu_Click(object sender, EventArgs e)
        {

            if (sua == true) // được gọi lên từ nút sửa
            {
                if (txt_makh.Text == "")
                {
                    thongbao("Mã khác hàng không được để trống");
                    txt_makh.Focus();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMã khách hàng: " + txt_makh.Text +
                        "\nTên khách hàng: " + txt_tenkh.Text +
                        "\nĐịa chỉ: " + txt_diachi.Text +
                        "\nSĐT: " + txt_sdt.Text, "Chú ý", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        kn.suakh(chon, txt_makh.Text, txt_tenkh.Text, txt_diachi.Text, txt_sdt.Text);
                        Loaddulieu();
                        an_txt();
                        an_btn();
                        bt_them.Visible = true;
                        thongbao("Đã lưu");
                        sua = false;

                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }
            }
            else
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
                        Loaddulieu();
                        an_txt();
                        an_btn();
                        bt_them.Visible = true;
                        thongbao("Đã lưu");
                        sua = false;
                    }
                    else
                    {
                        MessageBox.Show("Mã KHÁCH HÀNG đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            an_btn();
            hien_txt();
            xoa_lb();
            reset_txt();

            bt_huy.Visible = true;
            bt_luu.Visible = true;

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
                    an_btn();
                    an_txt();
                    xoa_lb();
                    bt_them.Visible = true;
                    thongbao("Đã xoá");
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

        int vitri = -1;         // lấy ra vị trí dòng được chọn trong DataGridView.
        string chon = null;     // lấy ra mã nhân viên của dòng được chọn.
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                vitri = e.RowIndex; // gán vị trí dòng đang chọn vào biến "vitri".
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString().Trim(); // gán mã nhân viên vào biến "chon".
                if (chon == "")
                {
                    chon = null;

                    xoa_lb();

                    bt_sua.Visible = false;
                    bt_xoa.Visible = false;
                }
                else if (bt_luu.Visible == true)
                {
                    xoa_lb();

                    // hiện dữ liệu vào các textbox
                    txt_makh.Text = row.Cells[0].Value.ToString();
                    txt_tenkh.Text = row.Cells[1].Value.ToString();
                    txt_diachi.Text = row.Cells[2].Value.ToString();
                    txt_sdt.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    an_txt();

                    // Hiện dữ liệu vào các label
                    lb_makh.Text = row.Cells[0].Value.ToString();
                    lb_tenkh.Text = row.Cells[1].Value.ToString();
                    lb_diachi.Text = row.Cells[2].Value.ToString();
                    lb_sdt.Text = row.Cells[3].Value.ToString();

                    bt_sua.Visible = true;
                    bt_xoa.Visible = true;
                }
            }
            catch
            {
                chon = null;
                xoa_lb();
                an_btn();
                bt_them.Visible = true;
            }
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();

            lb_thongbao.Text = "";      // cho thông báo bằng rỗng.
            an_btn();                   // ẩn các button.
            bt_them.Visible = true;     // hiện button thêm.
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        Boolean sua = false;
        private void bt_sua_Click(object sender, EventArgs e)
        {
            sua = true; // gán true cho biến "sua" để tiếp tục làm việc trong nút lưu
            xoa_lb();
            hien_txt();
            an_btn();
            bt_huy.Visible = true;
            bt_luu.Visible = true;

            int index = vitri;

            // hiện dữ liệu vào các textbox
            txt_makh.Text = dtgv.Rows[index].Cells[0].Value.ToString();
            txt_tenkh.Text = dtgv.Rows[index].Cells[1].Value.ToString();
            txt_diachi.Text = dtgv.Rows[index].Cells[2].Value.ToString();
            txt_sdt.Text = dtgv.Rows[index].Cells[3].Value.ToString();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            an_txt();
            reset_txt();
            an_btn();
            bt_them.Visible = true;
        }
    }
}
