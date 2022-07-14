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

namespace Telecommunication_Franchise_Management_System
{
    public partial class CustomerBalanceForm : Form
    {
        public CustomerBalanceForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomerBalanceForm_Load(object sender, EventArgs e)
        {
            Balancelbl.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Balance.ToString();

        }

        private void Rechargelbl_Click(object sender, EventArgs e)
        {
            
            Form form = new CustomerRecharge();
            form.ShowDialog();
            this.Refresh();

        }
    }
}
