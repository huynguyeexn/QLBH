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
    public partial class SANPHAM : Form
    {
        public SANPHAM()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        public void Loaddulieu()
        {
            string sql = "Select * from SANPHAM";
            dtgv.DataSource = kn.taobang(sql);
        }
        public void Loadnuocsx()
        {
          
           cb_nuocsx.Items.Add("Ả Rập Xê Út");
           cb_nuocsx.Items.Add("Afghanistan");
           cb_nuocsx.Items.Add("Ai Cập");
           cb_nuocsx.Items.Add("Albania");
           cb_nuocsx.Items.Add("Algeria");
           cb_nuocsx.Items.Add("Ấn Độ");
           cb_nuocsx.Items.Add("Andorra");
           cb_nuocsx.Items.Add("Angola");
           cb_nuocsx.Items.Add("Anguilla");
           cb_nuocsx.Items.Add("Anh");
           cb_nuocsx.Items.Add("Antigua và Barbuda");
           cb_nuocsx.Items.Add("Antilles thuộc Hà Lan");
           cb_nuocsx.Items.Add("Áo");
           cb_nuocsx.Items.Add("Argentina");
           cb_nuocsx.Items.Add("Armenia");
           cb_nuocsx.Items.Add("Aruba");
           cb_nuocsx.Items.Add("Azerbaijan");
           cb_nuocsx.Items.Add("Ba Lan");
           cb_nuocsx.Items.Add("Bahamas");
           cb_nuocsx.Items.Add("Bahrain");
           cb_nuocsx.Items.Add("Bangladesh");
           cb_nuocsx.Items.Add("Barbados");
           cb_nuocsx.Items.Add("﻿Belarus");
           cb_nuocsx.Items.Add("Belize");
           cb_nuocsx.Items.Add("Bénin");
           cb_nuocsx.Items.Add("Bermuda");
           cb_nuocsx.Items.Add("Bhutan");
           cb_nuocsx.Items.Add("Bỉ");
           cb_nuocsx.Items.Add("Bờ Biển Ngà");
           cb_nuocsx.Items.Add("Bồ Đào Nha");
           cb_nuocsx.Items.Add("Bolivia");
           cb_nuocsx.Items.Add("Bonaire");
           cb_nuocsx.Items.Add("Bosnia và Herzegovina");
           cb_nuocsx.Items.Add("Botswana");
           cb_nuocsx.Items.Add("Brazil");
           cb_nuocsx.Items.Add("Brunei");
           cb_nuocsx.Items.Add("Bulgaria");
           cb_nuocsx.Items.Add("Burkina Faso");
           cb_nuocsx.Items.Add("Burundi");
           cb_nuocsx.Items.Add("Các tiểu vương quốc Ả Rập Thống nhất");
           cb_nuocsx.Items.Add("Cameroon");
           cb_nuocsx.Items.Add("Campuchia");
           cb_nuocsx.Items.Add("Canada");
           cb_nuocsx.Items.Add("Cape Verde");
           cb_nuocsx.Items.Add("Chad");
           cb_nuocsx.Items.Add("Chile");
           cb_nuocsx.Items.Add("Colombia");
           cb_nuocsx.Items.Add("Comoros");
           cb_nuocsx.Items.Add("Cộng hòa Congo");
           cb_nuocsx.Items.Add("Cộng hòa dân chủ Congo");
           cb_nuocsx.Items.Add("Cộng hòa Dominican");
           cb_nuocsx.Items.Add("Cộng hòa Séc");
           cb_nuocsx.Items.Add("Cộng hòa Trung Phi");
           cb_nuocsx.Items.Add("Costa Rica");
           cb_nuocsx.Items.Add("Croatia");
           cb_nuocsx.Items.Add("Cuba");
           cb_nuocsx.Items.Add("Djibouti");
           cb_nuocsx.Items.Add("Dominica");
           cb_nuocsx.Items.Add("Đài Loan");
           cb_nuocsx.Items.Add("Đan Mạch");
           cb_nuocsx.Items.Add("Đông Timor");
           cb_nuocsx.Items.Add("Đức");
           cb_nuocsx.Items.Add("Ecuador");
           cb_nuocsx.Items.Add("El Salvador");
           cb_nuocsx.Items.Add("Eritrea");
           cb_nuocsx.Items.Add("﻿Estonia");
           cb_nuocsx.Items.Add("Ethiopia");
           cb_nuocsx.Items.Add("Fiji");
           cb_nuocsx.Items.Add("Gabon");
           cb_nuocsx.Items.Add("Gambia");
           cb_nuocsx.Items.Add("Georgia");
           cb_nuocsx.Items.Add("Ghana");
           cb_nuocsx.Items.Add("Grenada");
           cb_nuocsx.Items.Add("Guadeloupe");
           cb_nuocsx.Items.Add("Guam");
           cb_nuocsx.Items.Add("Guatemala");
           cb_nuocsx.Items.Add("Guiana thuộc Pháp");
           cb_nuocsx.Items.Add("Guinea");
           cb_nuocsx.Items.Add("Guinea Xích đạo");
           cb_nuocsx.Items.Add("Guinea-Bissau");
           cb_nuocsx.Items.Add("Guyana");
           cb_nuocsx.Items.Add("Hà Lan");
           cb_nuocsx.Items.Add("Haiti");
           cb_nuocsx.Items.Add("Hàn Quốc");
           cb_nuocsx.Items.Add("Hoa Kỳ");
           cb_nuocsx.Items.Add("Honduras");
           cb_nuocsx.Items.Add("Hungary");
           cb_nuocsx.Items.Add("Hy Lạp");
           cb_nuocsx.Items.Add("Iceland");
           cb_nuocsx.Items.Add("Indonesia");
           cb_nuocsx.Items.Add("Iran");
           cb_nuocsx.Items.Add("Iraq");
           cb_nuocsx.Items.Add("Ireland");
           cb_nuocsx.Items.Add("Israel");
           cb_nuocsx.Items.Add("Jamaica");
           cb_nuocsx.Items.Add("Jordan");
           cb_nuocsx.Items.Add("Kazakhstan");
           cb_nuocsx.Items.Add("Kenya");
           cb_nuocsx.Items.Add("Kiribati");
           cb_nuocsx.Items.Add("Kuwait");
           cb_nuocsx.Items.Add("Kyrgyzstan");
           cb_nuocsx.Items.Add("Lào");
           cb_nuocsx.Items.Add("Latvia");
           cb_nuocsx.Items.Add("Lesotho");
           cb_nuocsx.Items.Add("Liban");
           cb_nuocsx.Items.Add("Liberia");
           cb_nuocsx.Items.Add("Libya");
           cb_nuocsx.Items.Add("Liechtenstein");
           cb_nuocsx.Items.Add("Liên bang Micronesia");
           cb_nuocsx.Items.Add("Lithuania");
           cb_nuocsx.Items.Add("Luxembourg");
           cb_nuocsx.Items.Add("Ma-rốc");
           cb_nuocsx.Items.Add("Macedonia");
           cb_nuocsx.Items.Add("Madagascar");
           cb_nuocsx.Items.Add("Malawi");
           cb_nuocsx.Items.Add("Malaysia");
           cb_nuocsx.Items.Add("Maldives");
           cb_nuocsx.Items.Add("Mali");
           cb_nuocsx.Items.Add("Malta");
           cb_nuocsx.Items.Add("Martinique");
           cb_nuocsx.Items.Add("Mauritania");
           cb_nuocsx.Items.Add("Mauritius");
           cb_nuocsx.Items.Add("Mexico");
           cb_nuocsx.Items.Add("﻿Moldova");
           cb_nuocsx.Items.Add("Monaco");
           cb_nuocsx.Items.Add("Mông Cổ");
           cb_nuocsx.Items.Add("Montenegro");
           cb_nuocsx.Items.Add("Montserrat");
           cb_nuocsx.Items.Add("Mozambique");
           cb_nuocsx.Items.Add("Myanmar");
           cb_nuocsx.Items.Add("Na Uy");
           cb_nuocsx.Items.Add("Nam Phi");
           cb_nuocsx.Items.Add("Nam Sudan");
           cb_nuocsx.Items.Add("Namibia");
           cb_nuocsx.Items.Add("Nauru");
           cb_nuocsx.Items.Add("Nepal");
           cb_nuocsx.Items.Add("New Caledonia");
           cb_nuocsx.Items.Add("New Zealand");
           cb_nuocsx.Items.Add("Nga");
           cb_nuocsx.Items.Add("Nhật Bản");
           cb_nuocsx.Items.Add("Nicaragua");
           cb_nuocsx.Items.Add("Niger");
           cb_nuocsx.Items.Add("Nigeria");
           cb_nuocsx.Items.Add("Oman");
           cb_nuocsx.Items.Add("Pakistan");
           cb_nuocsx.Items.Add("Palau");
           cb_nuocsx.Items.Add("Palestine");
           cb_nuocsx.Items.Add("Panama");
           cb_nuocsx.Items.Add("Papua New Guinea");
           cb_nuocsx.Items.Add("Paraguay");
           cb_nuocsx.Items.Add("Peru");
           cb_nuocsx.Items.Add("Phần Lan");
           cb_nuocsx.Items.Add("Pháp");
           cb_nuocsx.Items.Add("Philippines");
           cb_nuocsx.Items.Add("Pitcairn");
           cb_nuocsx.Items.Add("Polynesia thuộc Pháp");
           cb_nuocsx.Items.Add("Puerto Rico");
           cb_nuocsx.Items.Add("Qatar");
           cb_nuocsx.Items.Add("Quần đảo Bắc Mariana");
           cb_nuocsx.Items.Add("Quần đảo Cayman");
           cb_nuocsx.Items.Add("Quần đảo Falkland");
           cb_nuocsx.Items.Add("Quần đảo Marshall");
           cb_nuocsx.Items.Add("Quần đảo Nam Georgia và Nam Sandwich");
           cb_nuocsx.Items.Add("Quần đảo Solomon");
           cb_nuocsx.Items.Add("Quần đảo Turks và Caicos");
           cb_nuocsx.Items.Add("Quần đảo Virgin thuộc Anh");
           cb_nuocsx.Items.Add("Quần đảo Virgin thuộc Mỹ");
           cb_nuocsx.Items.Add("Réunion (Pháp)");
           cb_nuocsx.Items.Add("Romania");
           cb_nuocsx.Items.Add("Rwanda");
           cb_nuocsx.Items.Add("Saint Helena");
           cb_nuocsx.Items.Add("Saint Kitts và Nevis");
           cb_nuocsx.Items.Add("Saint Lucia");
           cb_nuocsx.Items.Add("Saint Martin");
           cb_nuocsx.Items.Add("Saint Pierre và Miquelon");
           cb_nuocsx.Items.Add("Saint Vincent và Grenadines");
           cb_nuocsx.Items.Add("Saint-Barthélemy");
           cb_nuocsx.Items.Add("Samoa");
           cb_nuocsx.Items.Add("Samoa thuộc Mỹ");
           cb_nuocsx.Items.Add("San Marino");
           cb_nuocsx.Items.Add("São Tomé và Príncipe");
           cb_nuocsx.Items.Add("Senegal");
           cb_nuocsx.Items.Add("Serbia");
           cb_nuocsx.Items.Add("Seychelles");
           cb_nuocsx.Items.Add("Sierra Leone");
           cb_nuocsx.Items.Add("Singapore");
           cb_nuocsx.Items.Add("Sint Maarten");
           cb_nuocsx.Items.Add("Síp");
           cb_nuocsx.Items.Add("Slovakia");
           cb_nuocsx.Items.Add("Slovenia");
           cb_nuocsx.Items.Add("Somalia");
           cb_nuocsx.Items.Add("Sri Lanka");
           cb_nuocsx.Items.Add("Sudan");
           cb_nuocsx.Items.Add("Suriname");
           cb_nuocsx.Items.Add("Swaziland");
           cb_nuocsx.Items.Add("Syria");
           cb_nuocsx.Items.Add("Tajikistan");
           cb_nuocsx.Items.Add("Tanzania");
           cb_nuocsx.Items.Add("Tây Ban Nha");
           cb_nuocsx.Items.Add("Tây Sahara");
           cb_nuocsx.Items.Add("Thái Lan");
           cb_nuocsx.Items.Add("Thành Vatican");
           cb_nuocsx.Items.Add("Thổ Nhĩ Kỳ");
           cb_nuocsx.Items.Add("Thụy Điển");
           cb_nuocsx.Items.Add("Thụy Sĩ");
           cb_nuocsx.Items.Add("Togo");
           cb_nuocsx.Items.Add("Tonga");
           cb_nuocsx.Items.Add("Triều Tiên");
           cb_nuocsx.Items.Add("Trinidad và Tobago");
           cb_nuocsx.Items.Add("Trung Quốc");
           cb_nuocsx.Items.Add("Tunisia");
           cb_nuocsx.Items.Add("Turkmenistan");
           cb_nuocsx.Items.Add("Tuvalu");
           cb_nuocsx.Items.Add("Úc");
           cb_nuocsx.Items.Add("Uganda");
           cb_nuocsx.Items.Add("Ukraine");
           cb_nuocsx.Items.Add("Uruguay");
           cb_nuocsx.Items.Add("Uzbekistan");
           cb_nuocsx.Items.Add("Vanuatu");
           cb_nuocsx.Items.Add("Venezuela");
           cb_nuocsx.Items.Add("Việt Nam");
           cb_nuocsx.Items.Add("Ý");
           cb_nuocsx.Items.Add("Yemen");
           cb_nuocsx.Items.Add("Zambia");
           cb_nuocsx.Items.Add("Zimbabwe");
        }
        private void SANPHAM_Load(object sender, EventArgs e)
        {
            kn.connect();
            Loaddulieu();
            Loadnuocsx();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_dongia.Text == "" || txt_masp.Text == "" || txt_tensp.Text == "" || cb_dvt.Text == "" || cb_nuocsx.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập vào không được để trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string s = "select * from SANPHAM where MASP='" + txt_masp.Text + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.themsp(txt_masp.Text, txt_tensp.Text,cb_dvt.GetItemText(cb_dvt.SelectedItem), cb_nuocsx.GetItemText(cb_nuocsx.SelectedItem),txt_dongia.Text);
                    Loaddulieu();
                }
                else
                {
                    MessageBox.Show("Mã CHỨC VỤ đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
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
                        MessageBox.Show(chon);
                        kn.xoasp(chon);
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
                chon = row.Cells[0].Value.ToString().Trim();
                txt_masp.Text = row.Cells[0].Value.ToString().Trim();
                txt_tensp.Text = row.Cells[1].Value.ToString().Trim();

                cb_dvt.SelectedIndex = cb_dvt.FindString(row.Cells[2].Value.ToString().Trim());
                
                cb_nuocsx.SelectedIndex = cb_nuocsx.FindString(row.Cells[3].Value.ToString().Trim());

                txt_dongia.Text = row.Cells[4].Value.ToString().Trim();
            }
            catch
            {
                chon = null;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_dongia.ResetText();
            txt_masp.ResetText();
            txt_tensp.ResetText();
            cb_dvt.SelectedIndex = -1;
            cb_nuocsx.SelectedIndex = -1;
            txt_masp.Focus();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (chon != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thành \nMã sản phẩm: " + txt_masp.Text +
                    "\nTên sản phẩm: " + txt_tensp.Text+
                    "\nĐơn vị tính: " + cb_dvt.Text +
                    "\nNước sản xuất: " + cb_nuocsx.Text +
                    "\nĐơn giá: " + txt_dongia.Text, "Chú ý", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kn.suasp(chon, txt_masp.Text, txt_tensp.Text, cb_dvt.GetItemText(cb_dvt.SelectedItem), cb_nuocsx.GetItemText(cb_nuocsx.SelectedItem), txt_dongia.Text);
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
