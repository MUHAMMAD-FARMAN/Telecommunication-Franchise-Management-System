using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecommunication_Franchise_Management_System.DL;
using Telecommunication_Franchise_Management_System.BL;
using System.Windows.Forms;


namespace Telecommunication_Franchise_Management_System
{
    public partial class EditCustomerProfile : Form
    {
        public EditCustomerProfile()
        {
            InitializeComponent();
        }

        private void EditCustomerProfile_Load(object sender, EventArgs e)
        {
            Nametxt.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Name;
            Passwordtxt.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Password;
            Phonetxt.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].PhoneNum;
            Cnictxt.Text = CustomerDL.CustomerList[CustomerDL.CustomerIdx].Cnic;
        }

        private void EditProfileCmd_Click(object sender, EventArgs e)
        {
            Customer Updated = new Customer(Nametxt.Text,Passwordtxt.Text,Phonetxt.Text,Cnictxt.Text);
            CustomerDL.UpdateCustomerData(CustomerDL.CustomerList[CustomerDL.CustomerIdx], Updated);
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
