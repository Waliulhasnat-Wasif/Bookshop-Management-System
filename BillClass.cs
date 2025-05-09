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
    internal class BillClass
    {
        public Int64 CustomerId { get; set; }
        public string ClientName { get; set; }
        public string BookTitle { get; set; }
        public Int64 Price { get; set; }
        public Int64 Quantity { get; set; }
        public Int64 TotalAmount { get; set; }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");

        public DataTable ShowBillHistory(BillClass bill)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select Bill_ID, Client_Name, Books, Price, Quantity, Total_Amount from Customer_Bills where Customer_ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", bill.CustomerId);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable ShowAllBillHistory(BillClass bill)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Customer_Bills", con);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@ID", bill.CustomerId);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public void AddBillHistory(BillClass bill)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer_Bills (Client_Name, Books, Price, Quantity, Total_Amount, Customer_ID) VALUES (@CName, @Book_Name, @Book_Price, @Book_Quantity, @Total_Amount, @Customer_ID)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Cname", bill.ClientName);
            cmd.Parameters.AddWithValue("@Book_Name", bill.BookTitle);
            cmd.Parameters.AddWithValue("@Book_Price", bill.Price);
            cmd.Parameters.AddWithValue("@Book_Quantity", bill.Quantity);
            cmd.Parameters.AddWithValue("@Total_Amount", bill.TotalAmount);
            cmd.Parameters.AddWithValue("@Customer_ID", bill.CustomerId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("Your order has been successfully added to your bill history.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void AddBillHistory1(BillClass bill)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer_Bills (Client_Name, Books, Price, Quantity, Total_Amount, Customer_ID) VALUES (@CName, @Book_Name, @Book_Price, @Book_Quantity, @Total_Amount, @Customer_ID)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Cname", bill.ClientName);
            cmd.Parameters.AddWithValue("@Book_Name", bill.BookTitle);
            cmd.Parameters.AddWithValue("@Book_Price", bill.Price);
            cmd.Parameters.AddWithValue("@Book_Quantity", bill.Quantity);
            cmd.Parameters.AddWithValue("@Total_Amount", bill.TotalAmount);
            cmd.Parameters.AddWithValue("@Customer_ID", bill.CustomerId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have successfully added a bill in to your database.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteBillHistory(int p)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM Customer_Bills WHERE Bill_ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bill Record Deleted Sucessfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateBillHistory(BillClass bill, int p)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Customer_Bills SET Client_Name = @CName, Books = @Book_Name, Price = @Book_Price, Quantity = @Book_Quantity, Total_Amount = @Total_Amount, Customer_ID = @Customer_ID WHERE Bill_ID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Cname", bill.ClientName);
            cmd.Parameters.AddWithValue("@Book_Name", bill.BookTitle);
            cmd.Parameters.AddWithValue("@Book_Price", bill.Price);
            cmd.Parameters.AddWithValue("@Book_Quantity", bill.Quantity);
            cmd.Parameters.AddWithValue("@Total_Amount", bill.TotalAmount);
            cmd.Parameters.AddWithValue("@Customer_ID", bill.CustomerId);
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bill record has been updated Sucessfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int RecognitionEdit(int p, string s)
        {
            string query = "Select * from Login where ID = '"+ p.ToString() + "'";
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
                    string userSecureKey = secureDt.Rows[0]["SecurityKey"].ToString() ;
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
