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
    public partial class EmoneyAprovalAmountChangeForm : Form
    {
        private Worker worker;
        public EmoneyAprovalAmountChangeForm(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;   

        }

        private void EmoneyAprovalAmountChangeForm_Load(object sender, EventArgs e)
        {
            ChangeAmounttxt.Text = worker.RequestedEmoneyAmount.ToString();
        }

        private void ChangeApprovalAmountCmd_Click(object sender, EventArgs e)
        {
            worker.RequestedEmoneyAmount = int.Parse(ChangeAmounttxt.Text);
            this.Close();
        }
    }
}
