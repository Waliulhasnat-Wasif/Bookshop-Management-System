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
    public partial class SupplierMenu : Form
    {
        private int bookID;
        public SupplierMenu()
        {
            InitializeComponent();
            GetBookRecords();
            ResetFormControls();
            label_ID.Text = Login.UserID.ToString();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");

        BookClass b = new BookClass();
        private void ResetFormControls()
        {
            bookID = 0;
            numericUpDownBookID.Value = 0;
            textBoxBN.Clear();
            textBoxAuthor.Clear();
            numericUpDownQnt.Value = 0;
            comboBoxCtg.SelectedIndex = -1;
            numericUpDownPrice.Value = 0;
            textBoxBN.Focus();
        }
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBN.Text == "" || textBoxAuthor.Text == "" || numericUpDownQnt.Value == 0 || comboBoxCtg.SelectedIndex == -1 || numericUpDownPrice.Value == 0 || numericUpDownBookID.Value == 0)
            {
                MessageBox.Show("Missing Information. Please fill up them properly.", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    b.BId = Convert.ToInt32(numericUpDownBookID.Value);
                    b.BName = textBoxBN.Text;
                    b.BAuthor = textBoxAuthor.Text;
                    b.BCtg = comboBoxCtg.SelectedItem.ToString();
                    b.BQnt = Convert.ToInt32(numericUpDownQnt.Value);
                    b.BPrice = Convert.ToInt32(numericUpDownPrice.Value);
                    b.InsertBook1(b);
                    GetBookRecords();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (b.Recognition(bookID) == 1)
            {
                if (bookID > 0)
                {
                    try
                    {
                        b.BId = Convert.ToInt32(numericUpDownBookID.Value);
                        b.BName = textBoxBN.Text;
                        b.BAuthor = textBoxAuthor.Text;
                        b.BCtg = comboBoxCtg.SelectedItem.ToString();
                        b.BQnt = Convert.ToInt32(numericUpDownQnt.Value);
                        b.BPrice = Convert.ToInt32(numericUpDownPrice.Value);
                        b.EditBook(b, bookID);
                        GetBookRecords();
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
                    MessageBox.Show("Please Select A Book Item Row To Update the Information.", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You aren't allowed to edit or modify the information of this book stock.", "Not Allowed!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {            
            comboBoxFilterCtg.SelectedIndex = -1;
            textBoxSearch.Text = "Search Book Name";
            GetBookRecords();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * from BookTb where BookTitle like '%" + textBoxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);         
            dataGridViewBookList.DataSource = dt;
        }

        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        }

        private void comboBoxFilterCtg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterCtg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSelectedBookRecords();
        }

        private void dataGridViewBookList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                bookID = int.Parse(dataGridViewBookList.Rows[row_index].Cells[0].Value.ToString());
                numericUpDownBookID.Value = Convert.ToInt32(dataGridViewBookList.Rows[row_index].Cells[0].Value);
                textBoxBN.Text = dataGridViewBookList.Rows[row_index].Cells[1].Value.ToString();
                textBoxAuthor.Text = dataGridViewBookList.Rows[row_index].Cells[2].Value.ToString();
                comboBoxCtg.SelectedItem = dataGridViewBookList.Rows[row_index].Cells[3].Value.ToString();
                numericUpDownQnt.Value = Convert.ToInt32(dataGridViewBookList.Rows[row_index].Cells[4].Value);
                numericUpDownPrice.Value = Convert.ToInt32(dataGridViewBookList.Rows[row_index].Cells[5].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPlease click on the header of any row with content.");
                con.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (b.Recognition(bookID) == 1)
            {
                if (bookID > 0)
                {
                    try
                    {
                        b.DeleteBook(b, bookID);
                        GetBookRecords();
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
                    MessageBox.Show("Please Select A Book Records To Delete.", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("You aren't allowed to delete the information of this book stock.", "Not Allowed!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelUserInfo_Click(object sender, EventArgs e)
        {
            SupplierMenu2 supplierMenu2 = new SupplierMenu2();
            supplierMenu2.Show();
            this.Hide();
        }

        private void labelUserInfo_Click(object sender, EventArgs e)
        {
            SupplierMenu2 supplierMenu2 = new SupplierMenu2();
            supplierMenu2.Show();
            this.Hide();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            SupplierMenu2 supplierMenu2 = new SupplierMenu2();
            supplierMenu2.Show();
            this.Hide();
        }
    }
}
