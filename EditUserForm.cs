using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecommunication_Franchise_Management_System.BL;
using Telecommunication_Franchise_Management_System.DL;
using System.Windows.Forms;

namespace Telecommunication_Franchise_Management_System
{
    public partial class EditUserForm : Form
    {
        private Worker PreviousData;
        public EditUserForm(Worker PreviousData)
        { 
            InitializeComponent();
            this.PreviousData = PreviousData;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            Nametxt.Text = PreviousData.Name;
            Passwordtxt.Text = PreviousData.Password;
            Phonetxt.Text = PreviousData.PhoneNum;
            cnictxt.Text = PreviousData.Cnic;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Updatecmd_Click(object sender, EventArgs e)
        {
            Worker updated = new Worker(Nametxt.Text, Passwordtxt.Text, Phonetxt.Text ,cnictxt.Text);
            WorkerDL.EditWorkerFromList(PreviousData, updated);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
