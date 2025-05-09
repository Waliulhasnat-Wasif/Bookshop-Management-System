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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        private void resetPass_Click(object sender, EventArgs e)
        {
            string query = "Select * from Login where SecurityKey = '" + resetPassSecureKeyTextbox.Text + "' and Role = 'Customer'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string userKeyID = dt.Rows[0]["SecurityKey"].ToString();
                string userID = dt.Rows[0]["ID"].ToString();

                if (resetPassSecureKeyTextbox.Text.Equals(userKeyID))
                {
                    if (resetPassNewPass.Text == resetPassConfirmPass.Text)
                    {
                        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-OPF5EAS\\SQLEXPRESS;Initial Catalog=\"BookShop 3\";Integrated Security=True;Encrypt=False");
                        SqlCommand cmd = new SqlCommand("Update Login Set Password = '" + resetPassNewPass.Text + "' where SecurityKey = '" + resetPassSecureKeyTextbox.Text + "'", con);
                        SqlCommand cmd2 = new SqlCommand("Update UserTb Set Password = '" + resetPassNewPass.Text + "' where UserID = '" + userID + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Reset Successful!!");
                        Login log = new Login();
                        this.Hide();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show("New Password do not match");

                        //dynamicLabel.Text = "Wrong ID";
                    }
                }
                else
                {
                    // dynamicLabel.Text = "Wrong Key.";
                    labelMessage.Text = "Wrong Key";
                }
            }
            else
            {
                MessageBox.Show("Wrong ID");

                //dynamicLabel.Text = "This ID does not exist!!";
                labelMessage.Text = "This ID does not exist!!";
            }
        }

        private void cancelReset_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void resetPassSecureKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            //dynamicLabel.Text = "";
            labelMessage.Text = "";
        }

        private void resetPassNewPass_TextChanged(object sender, EventArgs e)
        {
            //dynamicLabel.Text = "";
            labelMessage.Text = "";
        }

        private void resetPassConfirmPass_TextChanged(object sender, EventArgs e)
        {
            // dynamicLabel.Text = "";
            labelMessage.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
