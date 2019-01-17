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
    public partial class User_About : Form
    {
        Connecting kn = new Connecting();
        SqlConnection con;
        string username;
        public User_About()
        {
            InitializeComponent();
        }
        public void Loadlb()
        {
       
            SqlCommand cmd = new SqlCommand("select * from DANGKY where USERNAME='" + username + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    lb_user.Text = dr.GetString(0);
                    lb_hoten.Text = dr.GetString(2);
                    lb_sdt.Text = dr.GetString(3);
                    lb_ngaysinh.Text = dr.GetString(4);
                    lb_diachi.Text = dr.GetString(5);
                    lb_cmnd.Text = dr.GetString(6);
                }
                catch
                {
                }

            }
        }
        private void User_About_Load(object sender, EventArgs e)
        {
            con = kn.ketnoi;
            con.Open();
            Main form_main = new Main();
            username = form_main.getUsername();

            Loadlb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UpdateUser().Show();
        }
    }
}
