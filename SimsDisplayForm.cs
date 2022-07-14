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
using System.IO;

namespace Telecommunication_Franchise_Management_System
{
    public partial class SimsDisplayForm : Form
    {
        public SimsDisplayForm()
        {
            InitializeComponent();
        }

        private void SimsDisplayForm_Load(object sender, EventArgs e)
        {


            SimsGV.DataSource = SimsDL.SimsList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddSimForm();
            form.ShowDialog();
            SimsDL.storeAllDataIntoFile("Sims.txt");
            dataBind();
        }

        private void SimsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             sim SIm = (sim)SimsGV.CurrentRow.DataBoundItem;
            if (SimsGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                SimsDL.deletSimFromList(SIm);
                SimsDL.storeAllDataIntoFile("Sims.txt");
                dataBind();
            }
            else if (SimsGV.Columns["Edit"].Index == e.ColumnIndex)
            {
               Form myform = new EditSimData(SIm);
                myform.ShowDialog();
                SimsDL.storeAllDataIntoFile("Sims.txt");
                dataBind();
            }
        }
        public void dataBind()
        {
            SimsGV.DataSource = null;
            SimsGV.DataSource = SimsDL.SimsList;
            SimsGV.Refresh();
        }
    }
}
