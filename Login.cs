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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookshop
{
    public partial class Login : Form
    {
        private Timer passTimer;
        public Login()
        {
            InitializeComponent();
            passTimer = new Timer();
            passTimer.Interval = 1000;
            passTimer.Tick += PasswordVisibilityTimer_Tick;
        }       

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        public static int UserID;
        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }        
        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ID.Text == "" || textBox_PW.Text == "")
                {
                    MessageBox.Show("Missing Information. Please fill up them properly.", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "Select * from Login where ID = '" + textBox_ID.Text.ToString() + "' and Password ='" + textBox_PW.Text.ToString() + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string q = "SELECT Role FROM Login WHERE ID = '" + textBox_ID.Text + "' AND Password = '" + textBox_PW.Text + "' and Status = 'Active'";
                        SqlDataAdapter roleSda = new SqlDataAdapter(q, con);
                        DataTable roleDt = new DataTable();
                        roleSda.Fill(roleDt);
                        if (roleDt.Rows.Count > 0)
                        {
                            string userRole = roleDt.Rows[0]["Role"].ToString();
                            if (userRole.Equals("Admin"))
                            {
                                AdminMenu ad = new AdminMenu();
                                ad.Show();
                                this.Hide();
                            }
                            else if (userRole.Equals("Customer"))
                            {
                                CustomerUserMenu cu = new CustomerUserMenu();
                                cu.Show();
                                this.Hide();
                                UserID = Convert.ToInt32(textBox_ID.Text);
                            }
                            else if (userRole.Equals("Employee"))
                            {
                                EmployeeMenu m = new EmployeeMenu();
                                m.Show();
                                this.Hide();
                                UserID = Convert.ToInt32(textBox_ID.Text);
                            }
                            else if (userRole.Equals("Supplier"))
                            {
                                SupplierMenu s = new SupplierMenu();
                                s.Show();
                                this.Hide();
                                UserID = Convert.ToInt32(textBox_ID.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your account is deactivated!!\nActivate your account to log in", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials!!\nTry Again.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Invalid ID Input!!\nTry Again in accurate formate.", "Attention!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label_UserID_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_ClearPW_Click(object sender, EventArgs e)
        {
            textBox_PW.Clear();
            textBox_PW.Focus();
        }

        private void button_ClearID_Click_1(object sender, EventArgs e)
        {
            textBox_ID.Clear();
            textBox_ID.Focus();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SigningUp s = new SigningUp();
            s.Show();
            this.Hide();
        }
        private void ShowPassword()
        {
            showPasspictureBox.Hide();
            hidePasspictureBox.Show();
            textBox_PW.UseSystemPasswordChar = false;
        }

        private void HidePassword()
        {
            hidePasspictureBox.Hide();
            showPasspictureBox.Show();
            textBox_PW.UseSystemPasswordChar = true;
        }

        private void PasswordVisibilityTimer_Tick(object sender, EventArgs e)
        {
            // Password hide after the timer interval
            HidePassword();
        }

        private void hidePasspictureBox_Click(object sender, EventArgs e)
        {

            //PictureBox pb = new PictureBox();
            //this.Controls.Add(pb);
            //pb.Click += new System.EventHandler(showPasspictureBox_Click);
           
        }

        private void showPasspictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_PW_TextChanged(object sender, EventArgs e)
        {
            HidePassword();
        }

        private void showPasspictureBox_Click_1(object sender, EventArgs e)
        {
            ShowPassword();
            passTimer.Start();
        }

        private void hidePasspictureBox_Click_1(object sender, EventArgs e)
        {
            HidePassword();
            passTimer.Stop();
        }

        private void forgotPassLabel_Click(object sender, EventArgs e)
        {
            ResetPassword sc = new ResetPassword();
            this.Hide();
            sc.Show();
        }
    }
}
