using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telecommunication_Franchise_Management_System.DL;
using System.Windows.Forms;

namespace Telecommunication_Franchise_Management_System
{
    public partial class DisplayComplainReport : Form
    {
        public DisplayComplainReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayComplainReport_Load(object sender, EventArgs e)
        {



            ComplainGV.DataSource = ComplainsDL.ComplainsList;
        }
    }
}
