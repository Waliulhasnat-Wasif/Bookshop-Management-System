using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bookshop
{
    internal class UserClass
    {
        public Int64 UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        //public string UserPhone { get; set; }
        private const int PhoneLength = 11; // Define the expected length of the phone number
        public string UserPhone
        {
            get => _userPhone;
            set
            {
                // Validate the length of the phone number
                if (value.Length == PhoneLength)
                {
                    _userPhone = value;
                }
                else
                {
                    throw new ArgumentException($"Phone number must be {PhoneLength} digits long.");
                }
            }
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");

        private string _userPhone; // Use a private field to store the phone number
        public string UserEmail { get; set; }
        public string UserRole { get; set; }
        public string SecurityKey { get; set; }

        public DataTable UserSelect()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select UserID, Name, Address, Phone, Email, Role, Status from UserTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable UserSelect2(int p)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from UserTb WHERE UserID = '"+p.ToString()+"'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public void InsertUser(UserClass u)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO UserTb VALUES (@UserID, @UserName, @UserPassword, @UserAddress, @UserPhone, @UserEmail, @UserRole, 'Inactive', @SecurityKey)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", u.UserID);
            cmd.Parameters.AddWithValue("@UserName", u.UserName);
            cmd.Parameters.AddWithValue("@UserPassword", u.UserPassword);
            cmd.Parameters.AddWithValue("@UserAddress", u.UserAddress);
            cmd.Parameters.AddWithValue("@UserPhone", u.UserPhone);
            cmd.Parameters.AddWithValue("@UserEmail", u.UserEmail);
            cmd.Parameters.AddWithValue("@UserRole", u.UserRole);            
            cmd.Parameters.AddWithValue("@SecurityKey", u.SecurityKey);            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New User Record has been Sucessfully Saved In The Database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InsertUser1(UserClass u)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO UserTb VALUES (@UserID, @UserName, @UserPassword, @UserAddress, @UserPhone, @UserEmail, @UserRole, 'Inactive', @SecurityKey)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", u.UserID);
            cmd.Parameters.AddWithValue("@UserName", u.UserName);
            cmd.Parameters.AddWithValue("@UserPassword", u.UserPassword);
            cmd.Parameters.AddWithValue("@UserAddress", u.UserAddress);
            cmd.Parameters.AddWithValue("@UserPhone", u.UserPhone);
            cmd.Parameters.AddWithValue("@UserEmail", u.UserEmail);
            cmd.Parameters.AddWithValue("@UserRole", u.UserRole);
            cmd.Parameters.AddWithValue("@SecurityKey", u.SecurityKey);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           //MessageBox.Show("New User Record has been Sucessfully Saved In The Database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InsertUser2(UserClass u)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Login VALUES (@UserID, @UserName, @UserPassword, @UserRole, @SecurityKey, 'Inactive')", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", u.UserID);
            cmd.Parameters.AddWithValue("@UserName", u.UserName);
            cmd.Parameters.AddWithValue("@UserPassword", u.UserPassword);            
            cmd.Parameters.AddWithValue("@UserRole", u.UserRole);
            cmd.Parameters.AddWithValue("@SecurityKey", u.SecurityKey);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("New User Record has been Sucessfully Saved In The Database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditUser2(UserClass u, int p)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Login SET ID = @User_ID, Name = @User_Name, Password = @User_Password, Role = @User_Role, SecurityKey = @SecurityKey WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@User_ID", u.UserID);
            cmd.Parameters.AddWithValue("@User_Name", u.UserName);
            cmd.Parameters.AddWithValue("@User_Password", u.UserPassword);           
            cmd.Parameters.AddWithValue("@User_Role", u.UserRole);
            cmd.Parameters.AddWithValue("@SecurityKey", u.SecurityKey);
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("User record has been updated Sucessfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditUser(UserClass u, int p)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE UserTb SET UserID = @User_ID, Name = @User_Name, Password = @User_Password, Address = @User_Address, Phone = @User_Phone, Email = @User_Email, Role = @User_Role, SecurityKey = @SecurityKey WHERE UserID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@User_ID", u.UserID);
            cmd.Parameters.AddWithValue("@User_Name", u.UserName);
            cmd.Parameters.AddWithValue("@User_Password", u.UserPassword);
            cmd.Parameters.AddWithValue("@User_Address", u.UserAddress);
            cmd.Parameters.AddWithValue("@User_Phone", u.UserPhone);
            cmd.Parameters.AddWithValue("@User_Email", u.UserEmail);
            cmd.Parameters.AddWithValue("@User_Role", u.UserRole);
            cmd.Parameters.AddWithValue("@SecurityKey", u.SecurityKey);
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User record has been updated Sucessfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteUser(UserClass u, int p)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM UserTb WHERE UserID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Record Deleted Sucessfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteUser2(UserClass u, int p)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM Login WHERE ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("User Record Deleted Sucessfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int RecognitionEdit(int p, string s)
        {
            string query = "Select * from Login where ID = '" + p.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string q = "SELECT SecurityKey FROM Login WHERE ID = '" + p.ToString() + "' and Status = 'Active'";
                SqlDataAdapter secureSda = new SqlDataAdapter(q, con);
                DataTable secureDt = new DataTable();
                secureSda.Fill(secureDt);
                if (secureDt.Rows.Count > 0)
                {
                    string userSecureKey = secureDt.Rows[0]["SecurityKey"].ToString();
                    if (userSecureKey.Equals(s))
                    {
                        con.Close();
                        return 1;
                    }
                    else
                    {
                        con.Close();
                        return -1;
                    }
                }
                else
                {
                    con.Close();
                    return -2;
                }
            }
            else
            {
                con.Close();
                return 0;
            }
        }
    }
}
