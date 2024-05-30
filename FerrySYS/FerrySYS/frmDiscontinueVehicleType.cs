using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrySYS
{
    public partial class frmDiscontinueVehicleType : Form
    {
        //Use Case ID 03: Discontinue Vehicle Type 

        //making an object reference to the main menu
        frmMainMenu parent;
        private DataSet vehicles;

        public frmDiscontinueVehicleType()
        {
            InitializeComponent();
        }
        public frmDiscontinueVehicleType(frmMainMenu parent) {
            InitializeComponent();
            this.parent = parent;
        }
        private void frmDiscontinueVehicleType_Load(object sender, EventArgs e)
        {
            vehicles = VehicleType.getAvailableVehicleTypes();

            if (vehicles != null)
            {
                if (vehicles.Tables[0].Rows.Count > 0)
                {
                    //Use Case 03 Step 3
                    Utility.fillComboBox(vehicles, cboDescription, "Vehicle_Types", 1);
                }
                else
                {
                    MessageBox.Show("No entries in the Vehicle Types file. There is nothing to discontinue. Sorry!");
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                this.Close();
                parent.Visible = true;
            }

        }

        private void cboDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDescription.SelectedIndex != -1) {
                grpVehicleDetails.Visible = true;
                //Use Case 03: Step 5
                txtCode.Text = vehicles.Tables[0].Rows[cboDescription.SelectedIndex][0].ToString();
                txtDescription.Text = vehicles.Tables[0].Rows[cboDescription.SelectedIndex][1].ToString();
                txtPrice.Text = vehicles.Tables[0].Rows[cboDescription.SelectedIndex][2].ToString();
            }
            
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            //Use Case 03: Step 7
            VehicleType vehicleType = new VehicleType(txtCode.Text, txtDescription.Text, decimal.Parse(txtPrice.Text));
            vehicleType.setStatus('U');

            //Use Case 03: Step 8
            if (vehicleType.amendVehicleType())
            {
                //Use Case 03: Step 9
                MessageBox.Show("Vehicle Type\n" + $"Description: {txtDescription.Text}" + "\n" + $"Code: {txtCode.Text}\n" + $"Price: {txtPrice.Text}\nDiscontinued Successfully.");

                //Use Case 03: Step 11
                grpVehicleDetails.Visible = false;
                cboDescription.SelectedIndex = -1;
                vehicles = VehicleType.getAvailableVehicleTypes();
                if (vehicles != null)
                {
                    if (vehicles.Tables[0].Rows.Count > 0)
                    {
                        Utility.fillComboBox(vehicles, cboDescription, "Vehicle_Types", 1);
                    }
                    else
                    {
                        MessageBox.Show("No entries left in the Vehicle Types file. There is nothing to discontinue. Sorry!");
                        this.Close();
                        parent.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                    this.Close();
                    parent.Visible = true;
                }
                
            }
            //Alternate Scenario: cannot write to file 
            else
            {
                MessageBox.Show("Unable to write to Vehicle Types file. Exiting to main menu");
                this.Close();
                parent.Visible = true;
            }

            
            

        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
    
}
