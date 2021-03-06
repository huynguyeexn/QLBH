﻿using System;
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
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        SqlConnection con;

        #region function

        // hàm được gọi từ form khác để cập nhật lại combobox
        public void load()
        {
            Loadcombobox();
        }

        // load dữ liệu lên combobox
        public void Loadcombobox()
        {
            try
            {
                con = kn.ketnoi;
                con.Open();
            }
            catch { }
            SqlCommand cn = new SqlCommand("Select macv, tencv from chucvu", con);
            SqlDataAdapter ad = new SqlDataAdapter(cn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "chucvu");
            cb_macv.DataSource = ds.Tables[0];
            cb_macv.DisplayMember = "macv";
            cb_macv.ValueMember = "macv";
            cb_macv.SelectedIndex = -1;
        }

        // load dữ liệu vào DataGridView
        public void Loaddulieu()
        {
            string sql = "Select * from NHANVIEN";
            dtgv.DataSource = kn.taobang(sql);
        }

        // xoá text các label
        void xoa_lb()
        {
            lb_chucvu.ResetText();
            lb_diachi.ResetText();
            lb_gioitinh.ResetText();
            lb_hoten.ResetText();
            lb_manv.ResetText();
            lb_mucluong.ResetText();
            lb_ngaysinh.ResetText();
            lb_ngayvaolam.ResetText();
            lb_sdt.ResetText();
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
            foreach (ComboBox ComboBox in Controls.OfType<ComboBox>())
                ComboBox.Visible = false;
            foreach (DateTimePicker DateTimePicker in Controls.OfType<DateTimePicker>())
                DateTimePicker.Visible = false;
        }

        // hiện các textbox lên
        void hien_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Visible = true;
            foreach (ComboBox ComboBox in Controls.OfType<ComboBox>())
                ComboBox.Visible = true;
            foreach (DateTimePicker DateTimePicker in Controls.OfType<DateTimePicker>())
                DateTimePicker.Visible = true;
        }

        // xoá text trong các textbox
        void reset_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
            foreach (ComboBox ComboBox in Controls.OfType<ComboBox>())
                ComboBox.SelectedIndex = -1;
            foreach (DateTimePicker DateTimePicker in Controls.OfType<DateTimePicker>())
                DateTimePicker.Value = DateTime.Now;
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

        // code khi load dữ liệu
        public void NHANVIEN_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loaddulieu();
            Loadcombobox();

            lb_thongbao.Text = "";      // cho thông báo bằng rỗng.
            an_btn();                   // ẩn các button.
            bt_them.Visible = true;     // hiện button thêm.
            
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
                    txt_manv.Text = row.Cells[0].Value.ToString().Trim();
                    txt_hoten.Text = row.Cells[1].Value.ToString().Trim();
                    cb_gioitinh.SelectedItem = row.Cells[2].Value.ToString().Trim();
                    ngaysinh.Value = DateTime.Parse(row.Cells[3].Value.ToString().Trim());
                    txt_diachi.Text = row.Cells[4].Value.ToString().Trim();
                    txt_sdt.Text = row.Cells[5].Value.ToString().Trim();
                    dateTimePicker2.Value = DateTime.Parse(row.Cells[6].Value.ToString().Trim());
                    txt_mucluong.Text = row.Cells[7].Value.ToString().Trim();
                    cb_macv.SelectedValue = row.Cells[8].Value.ToString().Trim();
                }
                else
                {
                    an_txt();

                    // Hiện dữ liệu vào các label
                    lb_manv.Text = row.Cells[0].Value.ToString().Trim();
                    lb_hoten.Text = row.Cells[1].Value.ToString().Trim();
                    lb_gioitinh.Text = row.Cells[2].Value.ToString().Trim();
                    lb_ngaysinh.Text = DateTime.Parse(row.Cells[3].Value.ToString()).ToString("dd/MM/yyyy");
                    lb_diachi.Text = row.Cells[4].Value.ToString().Trim();
                    lb_sdt.Text = row.Cells[5].Value.ToString().Trim();
                    lb_ngayvaolam.Text = DateTime.Parse(row.Cells[6].Value.ToString()).ToString("dd/MM/yyyy");
                    lb_mucluong.Text = row.Cells[7].Value.ToString().Trim();
                    lb_chucvu.Text = row.Cells[8].Value.ToString().Trim();

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

        private void bt_them_Click(object sender, EventArgs e)
        {
            an_btn();
            hien_txt();
            xoa_lb();
            reset_txt();
            
            bt_huy.Visible = true;
            bt_luu.Visible = true;

            txt_manv.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (sua==true) // được gọi lên từ nút sửa
            {
                if (txt_manv.Text == "")
                {
                    thongbao("Mã nhân viên không được để trống");
                    txt_manv.Focus();
                }
                else
                {
                    // thực hiện chức năng sửa dữ liệu
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thành" +
                        "\nMÃ NHÂN VIÊN:  " + txt_manv.Text +
                        "\nHỌ TÊN:  " + txt_hoten.Text +
                        "\nGIỚI TÍNH:  " + cb_gioitinh.Text +
                        "\nNGÀY SINH:  " + ngaysinh.Value.ToString("dd/MM/yyyy") +
                        "\nĐỊA CHỈ: " + txt_diachi.Text +
                        "\nSỐ ĐIỆN THOẠI:  " + txt_sdt.Text +
                        "\nNGÀY VÀO LÀM:  " + dateTimePicker2.Value.ToString("dd/MM/yyyy") +
                        "\nMỨC LƯƠNG:  " + txt_mucluong.Text +
                        "\nCHỨC VỤ:  " + cb_macv.SelectedValue.ToString()
                        , "Chú ý", MessageBoxButtons.YesNo); // thông báo xác nhận YES/NO

                    if (result == DialogResult.Yes) // nếu xác nhận là YES
                    {
                        // sửa dữ liệu
                        kn.suanv(txt_manv.Text, txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text, cb_macv.GetItemText(cb_macv.SelectedItem), chon);
                        Loaddulieu();
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
                if (txt_manv.Text == "" || txt_hoten.Text == "")
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string s = "select * from NHANVIEN where MANV='" + txt_manv.Text + "'";
                    DataTable dt = new DataTable();
                    dt = kn.taobang(s);
                    if (dt.Rows.Count == 0)
                    {
                        kn.themnv(txt_manv.Text, txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text , cb_macv.GetItemText(cb_macv.SelectedItem));
                        Loaddulieu();
                        an_txt();
                        an_btn();
                        bt_them.Visible = true;
                        thongbao("Đã lưu");
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
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
                        kn.xoanv(chon);
                        bt_them_Click(sender, e);
                        Loaddulieu();
                        an_btn();
                        an_txt();
                        xoa_lb();
                        bt_them.Visible = true;
                        thongbao("Đã xoá");
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhân viên đang được sử dụng ở bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

            // hiện dữ liệu lên các text box...
            txt_manv.Text = dtgv.Rows[index].Cells[0].Value.ToString().Trim();
            txt_hoten.Text = dtgv.Rows[index].Cells[1].Value.ToString().Trim();
            cb_gioitinh.SelectedItem = dtgv.Rows[index].Cells[2].Value.ToString().Trim();
            thongbao(dtgv.Rows[index].Cells[2].Value.ToString().Trim());
            ngaysinh.Value = DateTime.Parse(dtgv.Rows[index].Cells[3].Value.ToString().Trim());
            txt_diachi.Text = dtgv.Rows[index].Cells[4].Value.ToString().Trim();
            txt_sdt.Text = dtgv.Rows[index].Cells[5].Value.ToString().Trim();
            dateTimePicker2.Value = DateTime.Parse(dtgv.Rows[index].Cells[6].Value.ToString().Trim());
            txt_mucluong.Text = dtgv.Rows[index].Cells[7].Value.ToString().Trim();
            cb_macv.SelectedValue = dtgv.Rows[index].Cells[8].Value.ToString().Trim();

            
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
