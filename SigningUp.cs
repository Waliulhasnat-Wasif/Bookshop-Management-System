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
    public partial class SigningUp : Form
    {
        public SigningUp()
        {
            InitializeComponent();
        }
        UserClass u = new UserClass();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        private void labelPW_Click(object sender, EventArgs e)
        {

        }
        private void ResetFormControls()
        {            
            numericUpDownUID.Value = 0;
            textBoxUN.Clear();
            textBoxPW.Clear();
            textBoxAdress.Clear();
            numericUpDownPhone.Value = 0;
            textBoxEmail.Clear();
            comboBoxRole.SelectedIndex = -1;
            SecureTextBox.Text = " ";
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
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (numericUpDownUID.Value == 0 || textBoxUN.Text == "" || textBoxPW.Text == "" || textBoxAdress.Text == "" || numericUpDownUID.Value == 0|| textBoxEmail.Text == "" || comboBoxRole.SelectedIndex == -1 || SecureTextBox.Text == " ")
            {
                MessageBox.Show("Missing Information. Please fill up them properly.", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //u.UserID = int.Parse(numericUpDownUID.Value.ToString());
                    u.UserID = Convert.ToInt64(numericUpDownUID.Value);
                    //u.UserPhone = numericUpDownPhone.Value.ToString();

                    if (!IsUserIdExists(u.UserID))
                    {
                        u.UserName = textBoxUN.Text;
                        u.UserPassword = textBoxPW.Text;
                        u.UserAddress = textBoxAdress.Text;
                       // u.UserPhone = numericUpDownPhone.Value.ToString("00000000000");
                        if (numericUpDownPhone.Value.ToString().Length != 10)
                        {
                            phoneDigitLimitLabel.Text = "Provide a valid number!";
                            MessageBox.Show("Numbers must be about 11 digits!!");
                            return;
                        }
                        else
                        {
                            u.UserPhone = numericUpDownPhone.Value.ToString("00000000000");
                        }

                        //u.UserPhone = numericUpDownPhone.Value.ToString();
                        u.UserEmail = textBoxEmail.Text;
                        u.UserRole = comboBoxRole.SelectedItem.ToString();
                        u.SecurityKey = SecureTextBox.Text;

                    }
                    else
                    {
                        MessageBox.Show("UserID already exists. Please choose a different UserID.", "Duplicate UserID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    u.InsertUser1(u);
                    u.InsertUser2(u);
                    MessageBox.Show("Your account has been sucessfully created\nNow log in from the login page", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login l = new Login();
                    l.Show();
                    this.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to back to the login page?", "Back to the login page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
