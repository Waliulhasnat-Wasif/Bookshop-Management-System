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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();

        }
        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 5;
            MyProgress.Value = startPos;
            PercentageLbl.Text = startPos + "%";
            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            
        }

        private void Loading_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
