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
    public partial class DisplayCustomerProfile : Form
    {
        public DisplayCustomerProfile()
        {
            InitializeComponent();
        }

        private void DisplayCustomerProfile_Load(object sender, EventArgs e)
        {
            Namelbl.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Name;
            Passwordlbl.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Password;
            PhoneNumlbl.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].PhoneNum;
            Cniclbl.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Cnic;




        }

        private void EditProfileCmd_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form = new EditCustomerProfile();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
            this.Refresh();

        }

        private void Cniclbl_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumlbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Passwordlbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Namelbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
