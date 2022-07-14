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
    public partial class DisplayWorkers : Form
    {
        public DisplayWorkers()
        {
            InitializeComponent();
        }


        private void WorkersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker worker = (Worker)WorkersGV.CurrentRow.DataBoundItem;
            if (WorkersGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                WorkerDL.deletWorkerFromList(worker);
                WorkerDL.storeAllDataIntoFile("Workers.txt");
                dataBind();
            }
            else if (WorkersGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditUserForm myform = new EditUserForm(worker);
                myform.ShowDialog();
                WorkerDL.storeAllDataIntoFile("Workers.txt");
                dataBind();
            }
        }

        private void DisplayWorkers_Load(object sender, EventArgs e)
        {


            WorkersGV.DataSource = WorkerDL.WorkersList;
        }
        public void dataBind()
        {
            WorkersGV.DataSource = null;
            WorkersGV.DataSource = WorkerDL.WorkersList;
            WorkersGV.Refresh();
        }

        private void NewWorkerCmd_Click(object sender, EventArgs e)
        {
            Form form = new AddWorkerForm();
            form.ShowDialog();
            WorkerDL.storeAllDataIntoFile("Workers.txt");
            dataBind();
            form.Close();
           
        }
    }
}
