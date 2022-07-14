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
    public partial class AddWorkerForm : Form
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddWorkerCmd_Click(object sender, EventArgs e)
        {
            string Name = Nametxt.Text;
            string Password = Passwordtxt.Text;
            string Phone = Phonetxt.Text;
            string Cnic = Cnictxt.Text;

            if(Name == "" || Password == "" || Phone == "" || Cnic == "")
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Worker worker = new Worker(Nametxt.Text, Passwordtxt.Text, Phonetxt.Text, Cnictxt.Text);
            WorkerDL.addWorkerIntoList(worker);
            this.Close();
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackCmd_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cnictxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
