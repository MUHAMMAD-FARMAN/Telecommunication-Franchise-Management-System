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
using Telecommunication_Franchise_Management_System.BL;

namespace Telecommunication_Franchise_Management_System
{
    public partial class CustomerCareForm : Form
    {
        public CustomerCareForm()
        {
            InitializeComponent();
        }

        private void SubmitCmd_Click(object sender, EventArgs e)
        {
            ComplainClass complain = new ComplainClass(ComplainTxt.Text);
            ComplainsDL.addComplainIntoList(complain);
            MessageBox.Show("Complain registered successfully");
            this.Close();
        }
    }
}
