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
    public partial class EditSimData : Form
    {
        private sim Sim;
        private sim UpdatedData;
        public EditSimData(sim s)
        {
            InitializeComponent();
            Sim = s;
        }

        private void EditSimData_Load(object sender, EventArgs e)
        {
            Numbertxt.Text = Sim.Number;
            TypeComboBox.SelectedItem = Sim.Type;
            Pricetxt.Text = Sim.Price.ToString();

        }

        private void UpdateSimCmd_Click(object sender, EventArgs e)
        {
            try
            {   
                if(int.Parse(Pricetxt.Text) < 0)
                {
                    throw new Exception("Invalid Input"); 
                }

                if(Numbertxt.Text != "" && TypeComboBox.SelectedItem.ToString() != null && Pricetxt.Text != "")
                {
                    UpdatedData = new sim(Numbertxt.Text, TypeComboBox.SelectedItem.ToString(), int.Parse(Pricetxt.Text));
                    SimsDL.UpdateSimData(Sim, UpdatedData);
                    this.Close();
                }

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BackCmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
