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
    public partial class AdminBalanceForm : Form
    {
        public AdminBalanceForm()
        {
            InitializeComponent();
        }

        private void AdminBalanceForm_Load(object sender, EventArgs e)
        {
            WorkerBalanceViewGV.DataSource = WorkerDL.WorkersList;
            WorkerBalanceViewGV.Columns["Password"].Visible = false;
         /*   WorkerBalanceViewGV.DataSource = WorkerDL.WorkersList.Select(c => new { c.Name, c.Balance }).ToList();*/
            WorkerBalanceViewGV.Columns["Role"].Visible = false;
            WorkerBalanceViewGV.Columns["Emoney"].Visible = false;
            WorkerBalanceViewGV.Columns["requestedEmoneyAmount"].Visible = false;


        }

        private void WorkerBalanceViewGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker worker = (Worker)WorkerBalanceViewGV.CurrentRow.DataBoundItem;
            if (WorkerBalanceViewGV.Columns["Approve"].Index == e.ColumnIndex)
            {
                worker.Balance = worker.Balance + worker.RequestedBalanceAmount; 
                dataBind();
            }
            else if (WorkerBalanceViewGV.Columns["Change"].Index == e.ColumnIndex)
            {
                EditBalanceApprovalAmount myform = new EditBalanceApprovalAmount(worker);
                myform.ShowDialog();
                WorkerDL.storeAllDataIntoFile("Workers.txt");
                dataBind();
            }
        }
        public void dataBind()
        {
            WorkerBalanceViewGV.DataSource = null;
            WorkerBalanceViewGV.DataSource = WorkerDL.WorkersList;
            WorkerBalanceViewGV.Refresh();

        }
    }
}
