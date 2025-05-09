using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class CustomerUserMenu : Form
    {
        public CustomerUserMenu()
        {            
            InitializeComponent();
            label_ID.Text = Login.UserID.ToString();
            GetBookRecords();
            ResetFormControls();
            
            //label_ID.Text = "abc";                                           
            // Initialize PrintDocument, PrintDialog, and PrintPreviewDialog
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();

            // Set PrintPage event handler
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        BookClass b = new BookClass();
        BillClass bill = new BillClass();
        private void ResetFormControls()
        {                        
            textBoxBN.Clear();            
            numericUpDownQnt.Value = 0;
            numericUpDownPrice.Value = 0;
            textBoxCN.Clear();
            textBoxCN.Focus();
        }
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private void GetBookRecords()
        {
            DataTable dt = b.BookSelect();
            dataGridViewBookList.DataSource = dt;
        }
        private void GetSelectedBookRecords()
        {
            b.BCtg = comboBoxFilterCtg.SelectedItem.ToString();
            DataTable dt = b.BookFilter(b);
            dataGridViewBookList.DataSource = dt;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBill_Click(object sender, EventArgs e)
        {

        }
        int key = 0, stock = 0;
        private void UpdateBookQnt()
        {
            int newQnt = stock - (int)numericUpDownQnt.Value;
            try
            {
                b.UpdateBookQuantity(b, key, newQnt);
                GetBookRecords();
            }
            catch(Exception ex)
            {
                
            }
        }
        private void dataGridViewBookList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                //bookID = int.Parse(dataGridViewBookList.Rows[row_index].Cells[0].Value.ToString());            
                textBoxBN.Text = dataGridViewBookList.Rows[row_index].Cells[1].Value.ToString();
                //textBoxQnt.Text = dataGridViewBookList.Rows[row_index].Cells[4].Value.ToString();                
                numericUpDownPrice.Value = Convert.ToInt64(dataGridViewBookList.Rows[row_index].Cells[5].Value);
                if (textBoxBN.Text == "")
                {
                    key = 0;
                    stock = 0;
                }
                else
                {
                    key = int.Parse(dataGridViewBookList.Rows[row_index].Cells[0].Value.ToString());
                    stock = int.Parse(dataGridViewBookList.Rows[row_index].Cells[4].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPlease click on the header of any row with content.");
                con.Close();
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void comboBoxFilterCtg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSelectedBookRecords();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetBookRecords();
            comboBoxFilterCtg.SelectedIndex = -1;
            textBoxSearch.Text = "Search Book Name";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }            
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookBill.Rows.Count > 0)
            {

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                //MessageBox.Show("No items in the bill to preview.", "Empty Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //int prodID, prodQty, prodPrice, total, pos = 60;
        //string prodName;
        int pos = 60;
        string prodID, prodName, prodPrice, prodQty, total;


        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }

        private void dataGridViewBookBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_ID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelUserInfo_Click(object sender, EventArgs e)
        {
            CustomerUserMenu2 menu2 = new CustomerUserMenu2();
            menu2.Show();
            this.Hide();
        }

        private void labelUserInfo_Click(object sender, EventArgs e)
        {
            CustomerUserMenu2 menu2 = new CustomerUserMenu2();
            menu2.Show();
            this.Hide();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            CustomerUserMenu2 menu2 = new CustomerUserMenu2();
            menu2.Show();
            this.Hide();
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
            dataGridViewBookList.DataSource = dt;
        }

        int grandTotal = 0;

        private void labelCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void buttonBillHistory_Click(object sender, EventArgs e)
        {
            BillHistory billH = new BillHistory();
            billH.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(400));
            e.Graphics.DrawString("Client Name", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80, pos));
            e.Graphics.DrawString("PRODUCT", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(200, pos));
            e.Graphics.DrawString("PRICE", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(440, pos));
            e.Graphics.DrawString("QUANTITY", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(600, pos));
            e.Graphics.DrawString("TOTAL", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(750, pos));

            foreach (DataGridViewRow row in dataGridViewBookBill.Rows)
            {
                prodID = Convert.ToString(row.Cells["Client_Name"].Value);
                prodName = "" + row.Cells["Book_Name"].Value;
                prodPrice = Convert.ToString(row.Cells["Book_Price"].Value);
                prodQty = Convert.ToString(row.Cells["Book_Quantity"].Value);
                total = Convert.ToString(row.Cells["Total_Amount"].Value);

                e.Graphics.DrawString("" + prodID, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(80, pos + 40));
                e.Graphics.DrawString("" + prodName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(160, pos + 40));
                e.Graphics.DrawString("" + prodPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(440, pos + 40));
                e.Graphics.DrawString("" + prodQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(600, pos + 40));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(750, pos + 40));

                pos += 20;
            }
            e.Graphics.DrawString("Grand Total: Tk" + grandTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(350, pos + 50));
            e.Graphics.DrawString("*************** Online BookStore **************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(250, pos + 85));
            //dataGridViewBookBill.Rows.Clear();
            //dataGridViewBookBill.Refresh();
            pos = 100;
            grandTotal = 0;

        }

        private void buttonAddBill_Click(object sender, EventArgs e)
        {
            if (textBoxBN.Text == "" && numericUpDownPrice.Value == 0 || numericUpDownQnt.Value == 0 || textBoxCN.Text =="")
            {
                MessageBox.Show("Please insert the All Information appropriately.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBoxBN.Text != null && numericUpDownPrice.Value != 0 && numericUpDownQnt.Value != 0 && textBoxCN.Text != null && numericUpDownQnt.Value > stock)
            {
                MessageBox.Show("Sorry Dear! Your selected book is out of stock!!", "Running Out!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {                
                int total = (int)numericUpDownQnt.Value * Convert.ToInt32(numericUpDownPrice.Value);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewBookBill);
                row.Cells[0].Value = textBoxCN.Text;               
                row.Cells[1].Value = textBoxBN.Text;
                row.Cells[2].Value = Convert.ToInt64(numericUpDownPrice.Value);
                row.Cells[3].Value = numericUpDownQnt.Value;               
                row.Cells[4].Value = total;
                dataGridViewBookBill.Rows.Add(row);               
                UpdateBookQnt();
                bill.ClientName = row.Cells[0].Value.ToString();
                bill.BookTitle = row.Cells[1].Value.ToString();
                bill.Price = Convert.ToInt64(row.Cells[2].Value);
                bill.Quantity = Convert.ToInt64(row.Cells[3].Value);
                bill.TotalAmount = Convert.ToInt64(row.Cells[4].Value);
                bill.CustomerId = int.Parse(label_ID.Text=Login.UserID.ToString());
                bill.AddBillHistory(bill);
                grandTotal = grandTotal + total;
                labelTotalAmount.Text = grandTotal.ToString() +" tk";
            }
        }
    }
}
