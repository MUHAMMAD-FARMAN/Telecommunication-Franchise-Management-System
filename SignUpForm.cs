using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telecommunication_Franchise_Management_System.BL;
using Telecommunication_Franchise_Management_System.DL;

namespace Telecommunication_Franchise_Management_System
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer(textBox1.Text , textBox4.Text , textBox2.Text , textBox3.Text);
            if (CustomerDL.CustomerExist(cust))
            {
                MessageBox.Show("User already exist");
            }
            else
            {

            CustomerDL.addCustomerIntoList(cust);
            this.Close();
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
