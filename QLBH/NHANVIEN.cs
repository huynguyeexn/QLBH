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
            
        }
        string chon = null;
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[e.RowIndex];
                chon = row.Cells[0].Value.ToString().Trim();

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
            catch
            {
                chon = null;
                bt_them_Click(sender, null);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_diachi.ResetText();
            txt_hoten.ResetText();
            txt_manv.ResetText();
            txt_mucluong.ResetText();
            txt_sdt.ResetText();
            cb_gioitinh.SelectedIndex = -1;
            cb_macv.SelectedIndex = -1;


            int index = dtgv.Rows.Count - 2;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv.Rows[index];
            string chon1 = row.Cells[0].Value.ToString();
            string Str1 = chon1.Substring(2);
            if (Convert.ToInt32(Str1) < 9)
            {
                Str1 = chon1.Substring(3);
                chon1 = chon1.Replace(Convert.ToInt32(Str1).ToString(), (Convert.ToInt32(Str1) + 1).ToString());
                txt_manv.Text = chon1.ToString();
            }
            else if (Convert.ToInt32(Str1) < 99)
            {
                Str1 = chon1.Substring(2);
                chon1 = chon1.Replace(Str1, (Convert.ToInt32(Str1) + 1).ToString());
                txt_manv.Text = chon1.ToString();
            }
            txt_hoten.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {

            if (txt_hoten.Text == "" || cb_gioitinh.Text == "" || cb_macv.Text  == "")
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int index = dtgv.Rows.Count - 2;
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv.Rows[index];
                string chon1 = row.Cells[0].Value.ToString();
                string s = "select * from NHANVIEN where MANV='" + chon1 + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themnv(txt_manv.Text, txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text , cb_macv.GetItemText(cb_macv.SelectedItem));
                    Loaddulieu();
                }
                else
                {
                    index = dtgv.Rows.Count - 2;
                    row = dtgv.Rows[index];
                    chon1 = row.Cells[0].Value.ToString();
                    string Str1 = chon1.Substring(2);
                    if (Convert.ToInt32(Str1) < 9)
                    {
                        Str1 = chon1.Substring(3);
                        chon1 = chon1.Replace(Convert.ToInt32(Str1).ToString(), (Convert.ToInt32(Str1) + 1).ToString());
                        kn.themnv(chon1.ToString(), txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text, cb_macv.GetItemText(cb_macv.SelectedItem));
                    }
                    else if (Convert.ToInt32(Str1) < 99)
                    {
                        Str1 = chon1.Substring(2);
                        chon1 = chon1.Replace(Str1, (Convert.ToInt32(Str1) + 1).ToString());
                        kn.themnv(chon1.ToString(), txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text, cb_macv.GetItemText(cb_macv.SelectedItem));
                    }
                    Loaddulieu();
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

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành" +
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
                    kn.suanv(txt_hoten.Text, cb_gioitinh.GetItemText(cb_gioitinh.SelectedItem), ngaysinh.Value.ToString("yyyy/MM/dd"), txt_diachi.Text, txt_sdt.Text, dateTimePicker2.Value.ToString("yyyy/MM/dd"), txt_mucluong.Text, cb_macv.GetItemText(cb_macv.SelectedItem), chon);
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
        private void cb_macv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cb_macv_DropDown(object sender, EventArgs e)
        {
            //cb_macv.SelectedIndex = -1;
            Loadcombobox();
        }
    }
}
