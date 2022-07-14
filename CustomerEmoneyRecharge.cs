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
    public partial class CustomerEmoneyRecharge : Form
    {
        public CustomerEmoneyRecharge()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustomerDL.CustomerList[CustomerDL.CustomerIdx].Password == Passwordtxt.Text)
            {
                CustomerDL.CustomerList[CustomerDL.CustomerIdx].Emoney += int.Parse(Amounttxt.Text);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
