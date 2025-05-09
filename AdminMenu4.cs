using System;
using System.Collections;
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
    public partial class AdminMenu4 : Form
    {
        public AdminMenu4()
        {
            InitializeComponent();
            GetBillRecords();
        }
        BillClass b = new BillClass();
        private int bill_ID;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1SIEM6\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True");
        private void GetBillRecords()
        {
            DataTable dt = b.ShowAllBillHistory(b);
            dataGridViewBillHistory.DataSource = dt;
        }
        private void ResetFormControls()
        {
            bill_ID = 0;
            numericUpDownBill_ID.Value = 0;
            textBoxCN.Clear();
            textBoxBN.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQnt.Value = 0;
            numericUpDownTotalAmount.Value = 0;
            numericUpDownCID.Value = 0;
            textBoxCN.Focus();
        }
        private void dataGridViewBillHistory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                bill_ID = int.Parse(dataGridViewBillHistory.Rows[row_index].Cells[0].Value.ToString());
                numericUpDownBill_ID.Value = Convert.ToInt32(dataGridViewBillHistory.Rows[row_index].Cells[0].Value);
                textBoxCN.Text = dataGridViewBillHistory.Rows[row_index].Cells[1].Value.ToString();
                textBoxBN.Text = dataGridViewBillHistory.Rows[row_index].Cells[2].Value.ToString();
                numericUpDownPrice.Value = Convert.ToInt32(dataGridViewBillHistory.Rows[row_index].Cells[3].Value);
                numericUpDownQnt.Value = Convert.ToInt32(dataGridViewBillHistory.Rows[row_index].Cells[4].Value);
                numericUpDownTotalAmount.Value = Convert.ToInt32(dataGridViewBillHistory.Rows[row_index].Cells[5].Value);
                numericUpDownCID.Value = Convert.ToInt32(dataGridViewBillHistory.Rows[row_index].Cells[6].Value);     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPlease click on the header of any row with content.");
                con.Close();
            }
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            AdminMenu3 m3 = new AdminMenu3();
            m3.Show();
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (numericUpDownBill_ID.Value == 0 || textBoxCN.Text == "" || textBoxBN.Text == "" || numericUpDownPrice.Value == 0 || numericUpDownQnt.Value == 0 || numericUpDownCID.Value == 0 || numericUpDownCID.Value == 0)
            {
                MessageBox.Show("Missing Information. Please fill up them properly.", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    b.ClientName = textBoxCN.Text;
                    b.BookTitle = textBoxBN.Text;
                    b.Price = Convert.ToInt32(numericUpDownPrice.Value);
                    b.Quantity = Convert.ToInt32(numericUpDownQnt.Value);
                    b.TotalAmount = Convert.ToInt32(numericUpDownTotalAmount.Value);
                    b.CustomerId = Convert.ToInt32(numericUpDownCID.Value);
                    b.AddBillHistory1(b);
                    GetBillRecords();
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
            if (bill_ID > 0)
            {
                try
                {
                    b.ClientName = textBoxCN.Text;
                    b.BookTitle = textBoxBN.Text;
                    b.Price = Convert.ToInt32(numericUpDownPrice.Value);
                    b.Quantity = Convert.ToInt32(numericUpDownQnt.Value);
                    b.TotalAmount = Convert.ToInt32(numericUpDownTotalAmount.Value);
                    b.CustomerId = Convert.ToInt32(numericUpDownCID.Value);
                    b.UpdateBillHistory(b, bill_ID);
                    GetBillRecords();
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
                MessageBox.Show("Please Select A User Information Row To Update the Information.", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (bill_ID > 0)
            {
                try
                {
                    b.DeleteBillHistory(bill_ID);
                    GetBillRecords();
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
                MessageBox.Show("Please Select A Bill Record To Delete.", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelDashboard_Click(object sender, EventArgs e)
        {
            AdminMenu3 m3 = new AdminMenu3();
            m3.Show();
            this.Hide();
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

        private void labelLogout_Click(object sender, EventArgs e)
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

        private void pictureBoxDashboard_Click(object sender, EventArgs e)
        {
            AdminMenu3 m3 = new AdminMenu3();
            m3.Show();
            this.Hide();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * from Customer_Bills where Client_Name like '%" + textBoxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewBillHistory.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            GetBillRecords();
        }
    }
}
