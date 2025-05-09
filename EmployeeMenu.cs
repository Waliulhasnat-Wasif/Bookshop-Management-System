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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
            GetBillRecords();
            label_ID.Text = Login.UserID.ToString();
        }
        BillClass b = new BillClass();
        private int bill_ID;
        private int customer_ID;
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
            textBoxSecurityKey.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQnt.Value = 0;
            numericUpDownTotalAmount.Value = 0;
            numericUpDownCID.Value = 0;
            textBoxCN.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxSecurityKey.Text))
            {
                string s = textBoxSecurityKey.Text;               
                if (b.RecognitionEdit(Convert.ToInt32(numericUpDownCID.Value), s) == 1)
                {
                    if (textBoxCN.Text == "" || textBoxBN.Text == "" || numericUpDownPrice.Value == 0 || numericUpDownQnt.Value == 0 || numericUpDownCID.Value == 0 || numericUpDownCID.Value == 0 || numericUpDownTotalAmount.Value == 0)
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
                else if(b.RecognitionEdit(Convert.ToInt32(numericUpDownCID.Value), s) == -1)
                {
                    MessageBox.Show("Invalid Security key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(b.RecognitionEdit(Convert.ToInt32(numericUpDownCID.Value), s) == -2)
                {
                    MessageBox.Show("Your account is Inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Missing Security key", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewBillHistory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                bill_ID = int.Parse(dataGridViewBillHistory.Rows[row_index].Cells[0].Value.ToString());
                customer_ID = int.Parse(dataGridViewBillHistory.Rows[row_index].Cells[6].Value.ToString());
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxSecurityKey.Text))
            {
                string s = textBoxSecurityKey.Text;
                if (b.RecognitionEdit(customer_ID, s) == 1)
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
                else if (b.RecognitionEdit(customer_ID, s) == -1)
                {
                    MessageBox.Show("Invalid Security key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (b.RecognitionEdit(customer_ID, s) == -2)
                {
                    MessageBox.Show("Your account is Inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Missing Security key", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSecurityKey.Text))
            {
                string s = textBoxSecurityKey.Text;
                //customer_ID = numericUpDownCID.Value;
                if (b.RecognitionEdit(Convert.ToInt32(numericUpDownCID.Value), s) == 1)
                {
                    if (numericUpDownBill_ID.Value == 0 || textBoxCN.Text == "" || textBoxBN.Text == "" || numericUpDownPrice.Value == 0 || numericUpDownQnt.Value == 0 || numericUpDownCID.Value == 0 || numericUpDownCID.Value == 0 || numericUpDownTotalAmount.Value == 0)
                    {
                        MessageBox.Show("Missing Information. Please fill up them properly.", "Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
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
                }
                else if (b.RecognitionEdit(Convert.ToInt32(numericUpDownCID.Value), s) == -1)
                {
                    MessageBox.Show("Invalid Security key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (b.RecognitionEdit(Convert.ToInt32(numericUpDownCID.Value), s) == -2)
                {
                    MessageBox.Show("Your account is Inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Invalid User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Missing Security key", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBoxClose_Click_1(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelUserInfo_Click(object sender, EventArgs e)
        {
            EmployeeMenu2 employeeMenu2 = new EmployeeMenu2();
            employeeMenu2.Show();
            this.Close();
        }

        private void panelUserInfo_Click(object sender, EventArgs e)
        {
            EmployeeMenu2 employeeMenu2 = new EmployeeMenu2();
            employeeMenu2.Show();
            this.Close();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            EmployeeMenu2 employeeMenu2 = new EmployeeMenu2();
            employeeMenu2.Show();
            this.Close();
        }
    }
}
