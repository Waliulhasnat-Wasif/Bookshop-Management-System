using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookshop
{
    public partial class AdminMenu2 : Form
    {
        public AdminMenu2()
        {
            InitializeComponent();
            GetUserRecords();
            ResetFormControls();
        }

        private void textBoxQnt_TextChanged(object sender, EventArgs e)
        {

        }

        UserClass u = new UserClass();

        private int userID;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        private void GetUserRecords()
        {
            DataTable dt = u.UserSelect();
            dataGridViewUserList.DataSource = dt;
        }
        private void ResetFormControls()
        {
            userID = 0;
            numericUpDownUID.Value = 0;
            textBoxUN.Clear();
            textBoxPW.Clear();
            textBoxAdress.Clear();
            numericUpDownPhone.Value = 0;
            textBoxEmail.Clear();
            comboBoxRole.SelectedIndex = -1;
            textBoxUN.Focus();
        }
        private bool IsUserIdExists(Int64 userId)
        {
            // Check if the UserID exists in the database
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTb WHERE UserID = @UserID", con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (numericUpDownUID.Value == 0 || textBoxUN.Text == "" || textBoxPW.Text == "" || textBoxAdress.Text == "" || numericUpDownPhone.Value == 0 || textBoxEmail.Text == "" || comboBoxRole.SelectedIndex == -1 || textBoxSecurityKey.Text == "")
            {
                MessageBox.Show("Missing Information. Please fill up them properly.", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    u.UserID = Convert.ToInt64(numericUpDownUID.Value);
                    if (!IsUserIdExists(u.UserID))
                    {
                        u.UserName = textBoxUN.Text;
                        u.UserPassword = textBoxPW.Text;
                        u.UserAddress = textBoxAdress.Text;
                        u.UserPhone = numericUpDownPhone.Value.ToString();
                        u.UserEmail = textBoxEmail.Text;
                        u.UserRole = comboBoxRole.SelectedItem.ToString();
                        u.SecurityKey = textBoxSecurityKey.Text;
                        u.InsertUser(u);
                        u.InsertUser2(u);
                        GetUserRecords();
                    }
                    else
                    {
                        MessageBox.Show("UserID already exists. Please choose a different UserID.", "Duplicate UserID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }   
        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewUserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                userID = int.Parse(dataGridViewUserList.Rows[row_index].Cells[0].Value.ToString());
                numericUpDownUID.Value = Convert.ToInt64(dataGridViewUserList.Rows[row_index].Cells[0].Value);
                textBoxUN.Text = dataGridViewUserList.Rows[row_index].Cells[1].Value.ToString();
                //textBoxPW.Text = dataGridViewUserList.Rows[row_index].Cells[2].Value.ToString();
                textBoxAdress.Text = dataGridViewUserList.Rows[row_index].Cells[2].Value.ToString();
                numericUpDownPhone.Value = Convert.ToInt64(dataGridViewUserList.Rows[row_index].Cells[3].Value);
                textBoxEmail.Text = dataGridViewUserList.Rows[row_index].Cells[4].Value.ToString();
                comboBoxRole.SelectedItem = dataGridViewUserList.Rows[row_index].Cells[5].Value.ToString();
                //textBoxSecurityKey.Text = dataGridViewUserList.Rows[row_index].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPlease click on the header of any row with content.");
                con.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (userID > 0)
            {
                try
                {
                    u.DeleteUser(u, userID);
                    u.DeleteUser2(u, userID);
                    GetUserRecords();
                    ResetFormControls();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select A User Record To Delete.", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panelBooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxBooks_Click(object sender, EventArgs e)
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

        private void panelBooks_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu();
            m.Show();
            this.Hide();
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
            AdminMenu3 m3 = new AdminMenu3();
            m3.Show();
            this.Hide();
        }

        private void pictureBoxDashboard_Click(object sender, EventArgs e)
        {
            AdminMenu3 m3 = new AdminMenu3();
            m3.Show();
            this.Hide();
        }

        private void panelDashboard_Click(object sender, EventArgs e)
        {
            AdminMenu3 m3 = new AdminMenu3();
            m3.Show();
            this.Hide();
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

        private void labelLogout_Click(object sender, EventArgs e)
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

        private void StatusButton_Click(object sender, EventArgs e)
        {
            UserStatus us = new UserStatus();
            us.Show();
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Search User Name";
            GetUserRecords();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * from UserTb where Name like '%" + textBoxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewUserList.DataSource = dt;
        }

        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        }
    }
}
