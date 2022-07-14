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
    public partial class CustomerBuySimsForm : Form
    {
        public CustomerBuySimsForm()
        {
            InitializeComponent();
        }

        private void CustomerSimGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sim SiM = (sim)CustomerSimGV.CurrentRow.DataBoundItem;
            if (CustomerSimGV.Columns["Buy"].Index == e.ColumnIndex)
            {
                if(SiM.Price < CustomerDL.CustomerList[CustomerDL.CustomerIdx].Emoney)
                {
                    CustomerDL.CustomerList[CustomerDL.CustomerIdx].Emoney -= SiM.Price;
                    CustomerDL.CustomerList[CustomerDL.CustomerIdx].Sims.Add(SiM);
                }
            }


        }
    }
}
