using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telecommunication_Franchise_Management_System.DL;
using Telecommunication_Franchise_Management_System.BL;

namespace Telecommunication_Franchise_Management_System
{
    public partial class CustomerSimForm : Form
    {
        private Customer cust;
        public CustomerSimForm(Customer customer)
        {
            InitializeComponent();
            cust = customer;
        }

        private void CustomerSimForm_Load(object sender, EventArgs e)
        {
            CustomerSimGV.DataSource = cust.Sims;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new CustomerBuySimsForm();
            form.ShowDialog();
        }
    }
}
