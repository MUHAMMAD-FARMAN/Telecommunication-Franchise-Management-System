using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Telecommunication_Franchise_Management_System.DL;

namespace Telecommunication_Franchise_Management_System
{
    public partial class CustomerMainForm : Form
    {
        private bool sidebarExpander = false;
        public CustomerMainForm()
        {
            InitializeComponent();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuIcon_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpander)
            {
                /* SideBarPnl.Width -= 10;
                 if (SideBarPnl.Width-- SideBarPnl.MinimunSize.Width ){

                 }*/
                SideBarPnl.Width -= 10;
                if (SideBarPnl.Width == SideBarPnl.MinimumSize.Width)
                {
                    sidebarExpander = false;
                    SideBarTimer.Stop();

                }
            }
            else
            {
                SideBarPnl.Width += 10;
                if (SideBarPnl.Width == SideBarPnl.MaximumSize.Width)
                {
                    sidebarExpander = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void MyProfileCmd_Click(object sender, EventArgs e)
        {
            Form form = new DisplayCustomerProfile();
            form.ShowDialog();
        }

        private void BalanceCmd_Click(object sender, EventArgs e)
        {
            Form form = new CustomerBalanceForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SideBarPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmoneyCmd_Click(object sender, EventArgs e)
        {
            Form form = new CustomerEmoneyForm();
            form.ShowDialog();
        }

        private void SimsCmd_Click(object sender, EventArgs e)
        {

            Form form = new CustomerSimForm(CustomerDL.CustomerList[CustomerDL.CustomerIdx]);
            form.ShowDialog();
        }

        private void ComlplainReportCmd_Click(object sender, EventArgs e)
        {
            Form form = new CustomerCareForm();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new LogInForm();
            form.ShowDialog();
        }
    }
    }

