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
    public partial class CustomerEmoneyForm : Form
    {
        public CustomerEmoneyForm()
        {
            InitializeComponent();
        }

        private void Rechargelbl_Click(object sender, EventArgs e)
        {
            Form form = new CustomerEmoneyRecharge();
            form.ShowDialog();
        }

        private void CustomerEmoneyForm_Load(object sender, EventArgs e)
        {
            Balancelbl.Text = (CustomerDL.CustomerList[CustomerDL.CustomerIdx].Emoney).ToString();
        }
    }
}
