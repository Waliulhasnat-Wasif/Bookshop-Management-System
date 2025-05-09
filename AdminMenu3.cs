using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class AdminMenu3 : Form
    {
        public AdminMenu3()
        {
            InitializeComponent();
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            string query = "select sum(Quantity) from BookTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStk.Text = dt.Rows[0][0].ToString();

            string query2 = "select sum(Total_Amount) from Customer_Bills";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Amount.Text = dt2.Rows[0][0].ToString();

            string query3 = "select Count(*) from UserTb";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            User.Text = dt3.Rows[0][0].ToString();
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void panelUser_Click(object sender, EventArgs e)
        {
            AdminMenu2 m2 = new AdminMenu2();
            m2.Show();
            this.Hide();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
            AdminMenu2 m2 = new AdminMenu2();
            m2.Show();
            this.Hide();
        }

        private void pictureBoxUsers_Click(object sender, EventArgs e)
        {
            AdminMenu2 m2 = new AdminMenu2();
            m2.Show();
            this.Hide();
        }

        private void panelBooks_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu();
            m.Show();
            this.Hide();
        }

        private void labelBooks_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu();
            m.Show();
            this.Hide();
        }

        private void pictureBoxBooks_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu();
            m.Show();
            this.Hide();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        private void panelLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabelBillHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminMenu4 a4 = new AdminMenu4();
            a4.Show();
            this.Close();
        }
    }
}
