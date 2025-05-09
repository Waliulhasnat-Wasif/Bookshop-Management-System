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

namespace Bookshop
{
    public partial class BookStatus : Form
    {
        public BookStatus()
        {
            InitializeComponent();
            GetBookStatusRecords();
        }
        private int bId;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        BookClass b = new BookClass();
        private void GetBookStatusRecords()
        {
            SqlCommand cmd = new SqlCommand("select * from BookTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            BookStatusGridView.DataSource = dt;
        }
        private void activeButton_Click(object sender, EventArgs e)
        {
            if (bId > 0)
            {
    
               // Update the status to 'Active' in the database
                b.UpdateBookStatus(bId, true);
                // Refresh the DataGridView to reflect the changes
                GetBookStatusRecords();
            }
            else
            {
                MessageBox.Show("Please select a book to activate.", "Select Book?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deactiveButton_Click(object sender, EventArgs e)
        {
            if (bId > 0)
            {

                // Update the status to 'Active' in the database
                b.UpdateBookStatus(bId, false);
                // Refresh the DataGridView to reflect the changes
                GetBookStatusRecords();
            }
            else
            {
                MessageBox.Show("Please select a book to deactivate.", "Select Book?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "          Search By Name";
            GetBookStatusRecords();
        }

        private void BookStatusGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            bId = int.Parse(BookStatusGridView.Rows[row_index].Cells[0].Value.ToString());
        }

        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * from BookTb where BookTitle like '%" + textBoxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStatusGridView.DataSource = dt;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu2 m2 = new AdminMenu2();
            m2.Show();
        }
    }
}
