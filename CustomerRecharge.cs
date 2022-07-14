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
    public partial class CustomerRecharge : Form
    {
        public CustomerRecharge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (CustomerDL.CustomerList[CustomerDL.CustomerIdx].Password == Passwordtxt.Text)
                {
                    if (int.Parse(Amounttxt.Text) <= CustomerDL.CustomerList[CustomerDL.CustomerIdx].Emoney)
                    {
                        CustomerDL.CustomerList[CustomerDL.CustomerIdx].Balance += int.Parse(Amounttxt.Text);
                        CustomerDL.CustomerList[CustomerDL.CustomerIdx].Emoney -= int.Parse(Amounttxt.Text);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            if(CustomerDL.CustomerList[CustomerDL.CustomerIdx].Balance < 0 || CustomerDL.CustomerList[CustomerDL.CustomerIdx].Balance > 5000)
            {
                throw new Exception("Invalid input");
            } 
            this.Close();
        }

        private void Amounttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
