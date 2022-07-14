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
    public partial class AdminEmoneyForm : Form
    {
        public AdminEmoneyForm()
        {
            InitializeComponent();
        }

        private void AdminEmoneyForm_Load(object sender, EventArgs e)
        {


            AdminEmoneyGV.DataSource = WorkerDL.WorkersList;
            AdminEmoneyGV.Columns["Password"].Visible = false;
            AdminEmoneyGV.Columns["Role"].Visible = false;
            AdminEmoneyGV.Columns["Balance"].Visible = false;
            AdminEmoneyGV.Columns["requestedBalanceAmount"].Visible = false;



        }

        private void AdminEmoneyGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker worker = (Worker)AdminEmoneyGV.CurrentRow.DataBoundItem;
            if (AdminEmoneyGV.Columns["Approve"].Index == e.ColumnIndex)
            {
                worker.Emoney = worker.Emoney + worker.RequestedEmoneyAmount;
                dataBind();
            }
            else if (AdminEmoneyGV.Columns["Change"].Index == e.ColumnIndex)
            {
                EmoneyAprovalAmountChangeForm myform = new EmoneyAprovalAmountChangeForm(worker);
                myform.ShowDialog();
                WorkerDL.storeAllDataIntoFile("Workers.txt");
                dataBind();
            }
        }
        public void dataBind()
        {
            AdminEmoneyGV.DataSource = null;
            AdminEmoneyGV.DataSource = WorkerDL.WorkersList;
            AdminEmoneyGV.Refresh();
        }
    }
}
