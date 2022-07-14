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
    public partial class AdminMainForm : Form
    {
        bool sidebarExpander;
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            

        }

        private void HomeCmd_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                if(SideBarPnl.Width == SideBarPnl.MinimumSize.Width)
                {
                    sidebarExpander = false;
                    SideBarTimer.Stop();

                }
            }
            else
            {
                SideBarPnl.Width += 10;
                if(SideBarPnl.Width == SideBarPnl.MaximumSize.Width)
                {
                    sidebarExpander = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void Workers_Click(object sender, EventArgs e)
        {
            Form form = new DisplayWorkers();
            form.ShowDialog();
        }

        private void BalanceCmd_Click(object sender, EventArgs e)
        {
            Form form = new AdminBalanceForm();
            form.ShowDialog();
        }

       

        private void EmoneyCmd_Click(object sender, EventArgs e)
        {
            Form form = new AdminEmoneyForm();
            form.ShowDialog();

        }

        private void AminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void SimsCmd_Click(object sender, EventArgs e)
        {

            Form simsDisplayform = new SimsDisplayForm();
            simsDisplayform.ShowDialog();

        }

        private void ComlplainReportCmd_Click(object sender, EventArgs e)
        {
            Form form = new DisplayComplainReport();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new LogInForm();
            form.FormClosed += (s, args) => form.Close();
                
            form.ShowDialog();
           
        }
    }
}
