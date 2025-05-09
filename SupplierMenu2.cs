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
    public partial class SupplierMenu2 : Form
    {
        public SupplierMenu2()
        {
            InitializeComponent();
            GetUserRecords();
            ResetFormControls();
            label_ID.Text = Login.UserID.ToString();
        }
        UserClass u = new UserClass();

        private int userID;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        private void GetUserRecords()
        {
            DataTable dt = u.UserSelect2(Login.UserID);
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelUserInfo_Click(object sender, EventArgs e)
        {
            SupplierMenu s = new SupplierMenu();
            s.Show();
            this.Close();
        }

        private void panelUserInfo_Click(object sender, EventArgs e)
        {
            SupplierMenu s = new SupplierMenu();
            s.Show();
            this.Close();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            SupplierMenu s = new SupplierMenu();
            s.Show();
            this.Close();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (userID > 0)
            {

                try
                {
                    u.UserID = Convert.ToInt64(numericUpDownUID.Value);
                    u.UserName = textBoxUN.Text;
                    u.UserPassword = textBoxPW.Text;
                    u.UserAddress = textBoxAdress.Text;
                    u.UserPhone = numericUpDownPhone.Value.ToString();
                    u.UserEmail = textBoxEmail.Text;
                    u.UserRole = comboBoxRole.SelectedItem.ToString();
                    u.SecurityKey = textBoxSecurityKey.Text;
                    u.EditUser(u, userID);
                    u.EditUser2(u, userID);
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
                MessageBox.Show("Please Select Your User Information To Update the Information.", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void dataGridViewUserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                userID = int.Parse(dataGridViewUserList.Rows[row_index].Cells[0].Value.ToString());
                numericUpDownUID.Value = Convert.ToInt64(dataGridViewUserList.Rows[row_index].Cells[0].Value);
                textBoxUN.Text = dataGridViewUserList.Rows[row_index].Cells[1].Value.ToString();
                textBoxPW.Text = dataGridViewUserList.Rows[row_index].Cells[2].Value.ToString();
                textBoxAdress.Text = dataGridViewUserList.Rows[row_index].Cells[3].Value.ToString();
                numericUpDownPhone.Value = Convert.ToInt64(dataGridViewUserList.Rows[row_index].Cells[4].Value);
                textBoxEmail.Text = dataGridViewUserList.Rows[row_index].Cells[5].Value.ToString();
                comboBoxRole.SelectedItem = dataGridViewUserList.Rows[row_index].Cells[6].Value.ToString();
                textBoxSecurityKey.Text = dataGridViewUserList.Rows[row_index].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPlease click on the header of any row with content.");
                con.Close();
            }
        }
    }
}
