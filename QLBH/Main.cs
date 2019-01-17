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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Connecting kn = new Connecting();
        SqlConnection con;
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NHANVIEN"] == null)
            {
                new NHANVIEN().Show();
            }
        }
        public static string username = null;
        public void User(string u)
        {
            username = u;
        }
        public string getUsername()
        {
            return username;
        }
        public void Main_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            string u="";
            SqlCommand cmd = new SqlCommand("select * from DANGKY where USERNAME='" + username + "'or SODT ='" + username + "' or CMND='" + username + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    u = dr.GetString(2);
                }
                catch
                {
                    u = dr.GetString(0);
                }

            }
            con.Close();
            usernameToolStripMenuItem.Text = "Xin chào! " + u;
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["User_About"] == null)
            {
                new User_About().Show();
            }
        }
        Boolean dangxuat = false;
        public void hiengiaodien()
        {
            Login gd = new Login();
            gd.ShowDialog();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Thread th = new Thread(new ThreadStart(hiengiaodien));
                th.Start();
                dangxuat = true;
                this.Close();
            }
        }

        public void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangxuat == false)
            {
               DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        e.Cancel = false;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
            }
            
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Signup"] == null)
            {
                new Signup().Show();
            }
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Password"] == null)
            {
                new UpdateUser().Show();
            }
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Password"] == null)
            {
                new Password().Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void giớiThiệuVềỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms[""] == null)
            //{
            //    new ().Show();
            //}
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHUCVU"] == null)
            {
                new CHUCVU().Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KHACHHANG"] == null)
            {
                new KHACHHANG().Show();
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SANPHAM"] == null)
            {
                new SANPHAM().Show();
            }
        }
    }
}
