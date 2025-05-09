using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class BillHistory : Form
    {
        public BillHistory()
        {
            InitializeComponent();
            label_ID.Text = Login.UserID.ToString();
            GetBillRecords();
        }
        BillClass b = new BillClass();
        private void GetBillRecords()
        {
            b.CustomerId = Login.UserID;
            DataTable dt = b.ShowBillHistory(b);
            dataGridViewBillHistory.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
