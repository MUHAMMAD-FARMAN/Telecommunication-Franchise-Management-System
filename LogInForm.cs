using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Telecommunication_Franchise_Management_System.BL;
using Telecommunication_Franchise_Management_System.DL;

namespace Telecommunication_Franchise_Management_System
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        { 
            InitializeComponent();
        } 

            string path = "UsersData.txt";
        private void LogInForm_Load(object sender, EventArgs e)
        {
            MUserDL.readDataFromFile(path);
            CustomerDL.LoadCustomersFromFile("Customers.txt");
            SimsDL.LoadSimsFromFile("Sims.txt");
            WorkerDL.LoadWorkersFromFile("Workers.txt");
            ComplainsDL.AddComplainsIntoList("Complains.txt");


           
            
        }

       

      
        string LoginRole = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginRole == "Admin")
            {
                MUser logInUser = new MUser(Nametxt.Text, Passwordtxt.Text);
                logInUser = MUserDL.SignIn(logInUser);
                if (logInUser != null)
                {
                    this.Hide();
                    Form form = new AdminMainForm();
                    form.ShowDialog();
                }
                else
                {
                    label3.Visible = true;

                }

            }
            else if(LoginRole == "Customer")
            {
                Customer logInCust = new Customer(Nametxt.Text, Passwordtxt.Text);
                logInCust = CustomerDL.SignIn(logInCust);
                if (logInCust != null )
                {
                    this.Hide();
                    Form form = new CustomerMainForm();
                    form.ShowDialog();

                }
                else
                {
                    label3.Visible = true;

                }

            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginRole = "Admin";
            pictureBox3.BackColor = Color.Green;
            pictureBox5.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginRole = "Worker";
            pictureBox4.BackColor = Color.Green;
            pictureBox3.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginRole = "Customer";
            pictureBox5.BackColor = Color.Green;
            pictureBox4.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new SignUpForm();
            pictureBox5.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            Nametxt.Text = "";
            Passwordtxt.Text = "";
            label3.Visible = false;
            form.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
