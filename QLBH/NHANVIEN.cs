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
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        SqlConnection con;
        public void load()
        {
            Loadcombobox();
        }
        public void Loaddulieu()
        {
            string sql = "Select * from NHANVIEN";
            dtgv.DataSource = kn.taobang(sql);
        }
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
        void an_btn()
        {
            bt_luu.Visible = false;
            bt_huy.Visible = false;
            bt_xoa.Visible = false;
            bt_sua.Visible = false;
            bt_them.Visible = false;
            
        }
        void an_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Visible = false;
            foreach (ComboBox ComboBox in Controls.OfType<ComboBox>())
                ComboBox.Visible = false;
            foreach (DateTimePicker DateTimePicker in Controls.OfType<DateTimePicker>())
                DateTimePicker.Visible = false;
        }
        void hien_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Visible = true;
            foreach (ComboBox ComboBox in Controls.OfType<ComboBox>())
                ComboBox.Visible = true;
            foreach (DateTimePicker DateTimePicker in Controls.OfType<DateTimePicker>())
                DateTimePicker.Visible = true;
        }
        void reset_txt()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
            foreach (ComboBox ComboBox in Controls.OfType<ComboBox>())
                ComboBox.SelectedIndex = -1;
            foreach (DateTimePicker DateTimePicker in Controls.OfType<DateTimePicker>())
                DateTimePicker.Value = DateTime.Now;
        }
        public void Loadcombobox()
        {
            try
            {
                con = kn.ketnoi;
                con.Open();
            }
            catch{ }
            SqlCommand cn = new SqlCommand("Select macv, tencv from chucvu", con);
            SqlDataAdapter ad = new SqlDataAdapter(cn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "chucvu");
            cb_macv.DataSource = ds.Tables[0];
            cb_macv.DisplayMember = "macv";
            cb_macv.ValueMember = "macv";
            cb_macv.SelectedIndex = -1;
        }
        public void NHANVIEN_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Loaddulieu();
            Loadcombobox();
            lb_thongbao.Text = "";

            

            bt_luu.Visible = false;

            bt_sua.Visible = false;

            bt_xoa.Visible = false;

            bt_huy.Visible = false;

            txt_sdt.Focus();
            
        }
        private void thongbao(string a)
        {
            lb_thongbao.Text = a;
            Timer t1 = new Timer();

            t1.Interval = 3000;

            t1.Tick += (s, e) =>
            {
                lb_thongbao.ResetText();
                t1.Stop();
            };

            t1.Start();
        }
        void tickhandle(object sender, EventArgs e)
        {

        }
        int vitri = -1;
        string chon = null;
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                vitri = e.RowIndex;
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString().Trim();

                if (bt_luu.Visible == true)
                {
                    xoa_lb();
                    txt_manv.Text = row.Cells[0].Value.ToString().Trim();

                    txt_hoten.Text = row.Cells[1].Value.ToString().Trim();
                    if (row.Cells[2].Value.ToString().Trim() == "Nam")
                    {
                        cb_gioitinh.SelectedIndex = 0;
                    }
                    else
                    {
                        cb_gioitinh.SelectedIndex = 1;
                    }

                    string dateInput = row.Cells[3].Value.ToString().Trim();
                    DateTime dt = DateTime.Parse(dateInput); ngaysinh.Value = dt;

                    txt_diachi.Text = row.Cells[4].Value.ToString().Trim();
                    txt_sdt.Text = row.Cells[5].Value.ToString().Trim();

                    string dateInput1 = row.Cells[6].Value.ToString().Trim();
                    DateTime dt1 = DateTime.Parse(dateInput1); dateTimePicker2.Value = dt1;

                    txt_mucluong.Text = row.Cells[7].Value.ToString().Trim();
                    cb_macv.SelectedValue = row.Cells[8].Value.ToString().Trim();
                }
                else
                {
                    an_txt();
                    lb_manv.Text = row.Cells[0].Value.ToString().Trim();

                    lb_hoten.Text = row.Cells[1].Value.ToString().Trim();
                
                    lb_gioitinh.Text = row.Cells[2].Value.ToString().Trim();

                    DateTime dateAndTime = DateTime.Parse(row.Cells[3].Value.ToString());
                    lb_ngaysinh.Text = dateAndTime.ToString("dd/MM/yyyy");

                    lb_diachi.Text = row.Cells[4].Value.ToString().Trim();

                    lb_sdt.Text = row.Cells[5].Value.ToString().Trim();


                    dateAndTime = DateTime.Parse(row.Cells[6].Value.ToString());
                    lb_ngayvaolam.Text = dateAndTime.ToString("dd/MM/yyyy");


                    lb_mucluong.Text = row.Cells[7].Value.ToString().Trim();
                    lb_chucvu.Text = row.Cells[8].Value.ToString().Trim();
                    bt_sua.Visible = true;
                    bt_xoa.Visible = true;
                }
                
                

                
            }
            catch
            {
                chon = null;

                lb_chucvu.ResetText();
                lb_diachi.ResetText();
                lb_gioitinh.ResetText();
                lb_hoten.ResetText();
                lb_manv.ResetText();
                lb_mucluong.ResetText();
                lb_ngaysinh.ResetText();
                lb_ngayvaolam.ResetText();
                lb_sdt.ResetText();

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
            if (sua==true)
            {
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
                        , "Chú ý", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        kn.suanv(txt_manv.Text,txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text, cb_macv.GetItemText(cb_macv.SelectedItem), chon);
                        Loaddulieu();
                        an_txt();
                        bt_sua.Visible = false;
                        bt_luu.Visible = false;
                        bt_huy.Visible = false;
                        bt_xoa.Visible = false;
                        bt_them.Visible = true;
                        thongbao("Đã lưu");
                    sua = false;
                }
                    else if (result == DialogResult.No)
                    {

                    }
            }
            else
            {
                    if (txt_hoten.Text == "" || cb_gioitinh.Text == "" || cb_macv.Text  == "")
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
                DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        kn.xoanv(chon);
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhân viên đang được sử dụng ở bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    bt_them_Click(sender, e);
                    Loaddulieu();
                    an_btn();
                    an_txt();
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

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        Boolean sua = false;
        private void bt_sua_Click(object sender, EventArgs e)
        {
            sua = true;
            xoa_lb();
            hien_txt();
            an_btn();
            bt_huy.Visible = true;
            bt_luu.Visible = true;

            int index = vitri;

            txt_manv.Text = dtgv.Rows[index].Cells[0].Value.ToString().Trim();

            txt_hoten.Text = dtgv.Rows[index].Cells[1].Value.ToString().Trim();
            if (dtgv.Rows[index].Cells[2].Value.ToString().Trim() == "Nam")
            {
                cb_gioitinh.SelectedIndex = 0;
            }
            else
            {
                cb_gioitinh.SelectedIndex = 1;
            }

            string dateInput = dtgv.Rows[index].Cells[3].Value.ToString().Trim();
            DateTime dt = DateTime.Parse(dateInput); ngaysinh.Value = dt;

            txt_diachi.Text = dtgv.Rows[index].Cells[4].Value.ToString().Trim();
            txt_sdt.Text = dtgv.Rows[index].Cells[5].Value.ToString().Trim();

            string dateInput1 = dtgv.Rows[index].Cells[6].Value.ToString().Trim();
            DateTime dt1 = DateTime.Parse(dateInput1); dateTimePicker2.Value = dt1;

            txt_mucluong.Text = dtgv.Rows[index].Cells[7].Value.ToString().Trim();
            cb_macv.SelectedValue = dtgv.Rows[index].Cells[8].Value.ToString().Trim();

            
        }
        private void cb_macv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cb_macv_DropDown(object sender, EventArgs e)
        {
            //cb_macv.SelectedIndex = -1;
            Loadcombobox();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Visible = false;
            bt_luu.Visible = false;
            an_txt();
            bt_them.Visible = true;
        }
    }
}
