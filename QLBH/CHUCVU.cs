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

        #region function

        // load dữ liệu vào DataGridView
        public void Loaddulieu()
        {
            string sql = "Select * from CHUCVU";
            dtgv.DataSource = kn.taobang(sql);
        }

        // xoá text của label
        void xoa_lb()
        {
            lb_macv.ResetText();
            lb_tencv.ResetText();
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
            txt_macv.Visible = false;
            txt_tencv.Visible = false;
        }

        // hiện các textbox
        void hien_txt()
        {
            txt_macv.Visible = true;
            txt_tencv.Visible = true;
        }

        //xoá text trong các textbox
        void reset_txt()
        {
            txt_tencv.ResetText();
            txt_macv.ResetText();
        }
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
                
                if (txt_macv.Text == ""  || txt_tencv.Text == "")
                {
                    thongbao("Mã chức vụ và tên chức vụ không được để trống");
                    txt_macv.Focus();
                }
                else
                {
                    // thực hiện chức năng sửa dữ liệu
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMã chức vụ: " + txt_macv.Text +
                        "\nTên chức vụ: " + txt_tencv.Text, "Chú ý", MessageBoxButtons.YesNo); // thông báo xác nhận YES/NO
                    if (result == DialogResult.Yes) // nếu xác nhận là YES
                    {
                        // sửa dữ liệu
                        kn.suacv(chon, txt_macv.Text, txt_tencv.Text);
                        Loaddulieu();
                        new NHANVIEN().load();
                        an_txt();
                        an_btn();
                        bt_them.Visible = true;
                        thongbao("Đã lưu");
                        sua = false;
                    }
                    else if (result == DialogResult.No) // nếu xác nhận là NO
                    {
                        // bảng xác nhận sẽ tắt
                    }
                }
            }
            else
            {
                if (txt_macv.Text == "" || txt_tencv.Text == "")
                {
                    MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                   
                    string s = "select * from CHUCVU where MACV='" + txt_macv.Text + "'";
                    DataTable dt = new DataTable();
                    dt = kn.taobang(s);
                    if (dt.Rows.Count == 0)
                    {
                        kn.themcv(txt_macv.Text, txt_tencv.Text);
                        Loaddulieu();
                        new NHANVIEN().load();
                        an_txt();
                        an_btn();
                        bt_them.Visible = true;
                        thongbao("Đã lưu");
                    }
                    else
                    {
                        MessageBox.Show("Mã CHỨC VỤ đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void CHUCVU_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();

            lb_thongbao.Text = "";      // cho thông báo bằng rỗng.
            an_btn();                   // ẩn các button.
            bt_them.Visible = true;     // hiện button thêm.
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                // thông báo xắc nhận xoá YES/NO
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) // xác nhận xoá là YES
                {
                    try
                    {
                        kn.xoacv(chon);
                        new NHANVIEN().load();
                        an_btn();
                        an_txt();
                        xoa_lb();
                        bt_them.Visible = true;
                        thongbao("Đã xoá");
                    }
                    catch
                    {
                        MessageBox.Show("Mã chức vụ đang được sử dụng ở bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Loaddulieu();
                }
                else if (result == DialogResult.No) // xác nhận xoá là YES
                {
                    // tắt bảng xác nhận
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
                    txt_macv.Text = row.Cells[0].Value.ToString();
                    txt_tencv.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    an_txt();

                    // Hiện dữ liệu vào các label
                    lb_macv.Text = row.Cells[0].Value.ToString();
                    lb_tencv.Text = row.Cells[1].Value.ToString();

                    bt_sua.Visible = true;
                    bt_xoa.Visible = true;
                }
            }
            catch
            {
                chon = null;

                xoa_lb();

                bt_sua.Visible = false;
                bt_xoa.Visible = false;
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            an_btn();
            hien_txt();
            xoa_lb();
            reset_txt();

            bt_huy.Visible = true;
            bt_luu.Visible = true;

            txt_macv.Focus();
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

            // hiện dữ liệu lên các text box...
            txt_macv.Text = dtgv.Rows[index].Cells[0].Value.ToString();
            txt_tencv.Text = dtgv.Rows[index].Cells[1].Value.ToString();
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
