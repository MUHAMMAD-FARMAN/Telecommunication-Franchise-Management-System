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

namespace Telecommunication_Franchise_Management_System
{
    public partial class EditBalanceApprovalAmount : Form
    {
        private Worker worker;
        public EditBalanceApprovalAmount(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
           
        }

        private void Amounttxt_Load(object sender, EventArgs e)
        {
            ChangeAmounttxt.Text = worker.RequestedBalanceAmount.ToString();

        }

        private void ChangeAmounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeApprovalAmountCmd_Click(object sender, EventArgs e)
        {
            try
            {
            worker.RequestedBalanceAmount = int.Parse(ChangeAmounttxt.Text);
            if(worker.RequestedBalanceAmount < 0)
            {
                throw new Exception("Invalid Input");
            }
            if(worker.RequestedBalanceAmount > 5000)
            {
                throw new Exception("Too large value");
            }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
