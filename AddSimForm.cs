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
    public partial class AddSimForm : Form
    {
        public AddSimForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackCmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWorkerCmd_Click(object sender, EventArgs e)
        {
            string Number = Numbertxt.Text;
            string price = Pricetxt.Text;

            int Price;

            if(price == "" || Number == "")
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            try
            {
                Price = int.Parse(price);
            }    
            catch(Exception)
            {
                MessageBox.Show("Price in Wrong Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Price < 0)
            {
                MessageBox.Show("Price Must be Greater than Zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sim Newsim = new sim(Number, TypeComboBox.SelectedItem.ToString(), Price);
            SimsDL.addSimIntoList(Newsim);
            this.Close();
          
        }

        private void AddSimForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

