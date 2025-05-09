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
    internal class BookClass
    {
        public string BName { get; set; }
        public int BId { get; set; }
        public string BAuthor { get; set; }
        public int BQnt { get; set; }
        public string BCtg { get; set; }
        public int BPrice { get; set; }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        public DataTable BookSelect()
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from BookTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

        public DataTable BookFilter(BookClass b)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from BookTb where Category = @Book_Category", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Book_Category", b.BCtg);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

        public void InsertBook(BookClass b)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO BookTb VALUES (@Book_ID, @Book_Name, @Book_AuthorName, @Book_Category, @Book_Quantity, @Book_Price, 'Active')", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Book_ID", b.BId);
            cmd.Parameters.AddWithValue("@Book_Name", b.BName);
            cmd.Parameters.AddWithValue("@Book_AuthorName", b.BAuthor);
            cmd.Parameters.AddWithValue("@Book_Category", b.BCtg);
            cmd.Parameters.AddWithValue("@Book_Quantity", b.BQnt);
            cmd.Parameters.AddWithValue("@Book_Price", b.BPrice);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Book Record has been Sucessfully Saved In The Database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InsertBook1(BookClass b)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO BookTb VALUES (@Book_ID, @Book_Name, @Book_AuthorName, @Book_Category, @Book_Quantity, @Book_Price, 'Inactive')", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Book_ID", b.BId);
            cmd.Parameters.AddWithValue("@Book_Name", b.BName);
            cmd.Parameters.AddWithValue("@Book_AuthorName", b.BAuthor);
            cmd.Parameters.AddWithValue("@Book_Category", b.BCtg);
            cmd.Parameters.AddWithValue("@Book_Quantity", b.BQnt);
            cmd.Parameters.AddWithValue("@Book_Price", b.BPrice);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Book Record has been Sucessfully Saved In The Database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteBook(BookClass b, int p)
        {
           // SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM BookTb WHERE BookID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book Record Deleted Sucessfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditBook(BookClass b, int p)
        {
           // SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE BookTb SET BookID = @Book_ID, BookTitle = @Book_Title, AuthorName = @Author_Name, Category = @Book_Category, Quantity = @Book_Quantity, Price = @Book_Price WHERE BookID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Book_ID", b.BId);
            cmd.Parameters.AddWithValue("@Book_Title", b.BName);
            cmd.Parameters.AddWithValue("@Author_Name", b.BAuthor);
            cmd.Parameters.AddWithValue("@Book_Category", b.BCtg);
            cmd.Parameters.AddWithValue("@Book_Quantity", b.BQnt);
            cmd.Parameters.AddWithValue("@Book_Price", b.BPrice);
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book record has been updated Sucessfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateBookQuantity(BookClass b, int p, int k)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE BookTb SET Quantity = @Book_Quantity WHERE BookID = @ID", con);
            cmd.CommandType = CommandType.Text;           
            cmd.Parameters.AddWithValue("@Book_Quantity", k);   
            cmd.Parameters.AddWithValue("@ID", p);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your order has been successfully added to your bill history.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int Recognition(int p)
        {
            string q = "SELECT Status FROM BookTb WHERE BookID = '" + p.ToString() + "'";
            SqlDataAdapter statusSda = new SqlDataAdapter(q, con);
            DataTable Dt = new DataTable();
            statusSda.Fill(Dt);
            string bookStatus = Dt.Rows[0]["Status"].ToString();
            if (bookStatus == "Inactive")
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
        public void UpdateBookStatus(int BookID, bool isActive)
        {
            // Update the status in the database
            string statusUpdateQuery = "UPDATE BookTb SET Status = @status WHERE BookID = @bookID";
            SqlCommand cmd = new SqlCommand(statusUpdateQuery, con);
            cmd.Parameters.AddWithValue("@status", isActive ? "Active" : "Inactive"); // 1 for 'Active', 0 for 'Inactive'
            cmd.Parameters.AddWithValue("@bookID", BookID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
