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
    public partial class UserStatus : Form
    {
        public UserStatus()
        {
            InitializeComponent();
            GetuserStatusRecords();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        private void GetuserStatusRecords()
        {
            SqlCommand cmd = new SqlCommand("Select ID, Name, Role, Status from Login", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            userStatusGridView.DataSource = dt;
        }
        private void UpdateUserStatus(int userID, bool isActive)
        {
            // Update the status in the database
            string statusUpdateQuery = "UPDATE UserTb SET Status = @Status1 WHERE UserID = @UserID1";
            string statusUpdateQuery2 = "UPDATE Login SET Status = @Status2 WHERE ID = @UserID2";


            SqlCommand cmd = new SqlCommand(statusUpdateQuery, con);
            cmd.Parameters.AddWithValue("@Status1", isActive ? "Active" : "Inactive"); // 1 for 'Active', 0 for 'Inactive'
            cmd.Parameters.AddWithValue("@UserID1", userID);
            con.Open();
            cmd.ExecuteNonQuery();
            //con.Close();

            SqlCommand cmd2 = new SqlCommand(statusUpdateQuery2, con);
            cmd2.Parameters.AddWithValue("@Status2", isActive ? "Active" : "Inactive"); // 1 for 'Active', 0 for 'Inactive'
            cmd2.Parameters.AddWithValue("@UserID2", userID);
            //con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();

        }
        private void activeButton_Click(object sender, EventArgs e)
        {
            if (userStatusGridView.SelectedRows.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(userStatusGridView.SelectedRows[0].Cells["ID"].Value);

                // Update the status to 'Active' in the database
                UpdateUserStatus(selectedUserID, true);

                // Refresh the DataGridView to reflect the changes
                GetuserStatusRecords();
            }
            else
            {
                MessageBox.Show("Please select a user to activate.", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deactiveButton_Click(object sender, EventArgs e)
        {
            if (userStatusGridView.SelectedRows.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(userStatusGridView.SelectedRows[0].Cells["ID"].Value);

                // Update the status to 'Inactive' in the database
                UpdateUserStatus(selectedUserID, false);

                // Refresh the DataGridView to reflect the changes
                GetuserStatusRecords();
            }
            else
            {
                MessageBox.Show("Please select a user to deactivate.", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu2 m2 = new AdminMenu2();
            m2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Search By Name";
            GetuserStatusRecords();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select ID, Name, Role, Status from Login where Name like '%" + textBoxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            userStatusGridView.DataSource = dt;
        }

        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        }
    }
}
