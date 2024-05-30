using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace FerrySYS
{
    public partial class frmAmendVehicleType : Form
    {
        //Use Case ID 02: Amend Vehicle Type

        //making an object reference to the main menu
        frmMainMenu parent;

        //for vehicle types
        private DataSet vehicles = new  DataSet();

        public frmAmendVehicleType()
        {
            InitializeComponent();
        }

        //contructor that takes main menu as an argument
        public frmAmendVehicleType(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmAmendVehicleType_Load(object sender, EventArgs e)
        {
            
            //Amend Vehicle Type: Step 2
            vehicles = VehicleType.getAvailableVehicleTypes();

            if (vehicles != null)
            {
                if (vehicles.Tables[0].Rows.Count > 0)
                {
                    //Amend Vehicle Type: Step 3
                    Utility.fillComboBox(vehicles, cboDescription, "Vehicle_Types", 1);
                }
                else
                {
                    //Amend Vehicle Type: Alternate Scenario: file contains no data
                    MessageBox.Show("No entries in the Vehicle Types file. There is nothing to amend. Sorry!");
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                //Amend Vehicle Type: Alternate Scenario: cannot read file
                MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                this.Close();
                parent.Visible = true;
            }

        }
        private void cboDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDescription.SelectedIndex != -1) {
                //Amend Vehicle Type: Step 5
                grpTypeDetails.Visible = true;

                txtCode.Text = vehicles.Tables[0].Rows[cboDescription.SelectedIndex][0].ToString();
                txtDescription.Text = vehicles.Tables[0].Rows[cboDescription.SelectedIndex][1].ToString();
                txtPrice.Text = vehicles.Tables[0].Rows[cboDescription.SelectedIndex][2].ToString();

            }
        }
        private void btnAmend_Click(object sender, EventArgs e)
        {
            //Amend Vehicle Type: Step 7
            if (VehicleType.validateVehicleInput(txtDescription.Text, txtCode.Text, txtPrice.Text))
            {
                //Amend Vehicle Type: Step 8
                VehicleType vehicleType = new VehicleType(txtCode.Text, txtDescription.Text, decimal.Parse(txtPrice.Text));
                if (vehicleType.amendVehicleType())
                {
                    MessageBox.Show("Vehicle Type\n" + $"Description: {txtDescription.Text}" + "\n" + $"Code: {txtCode.Text}\n" + $"Price: {txtPrice.Text}\nAmended Successfully.");
                    //Amend Vehicle Type: Step 11
                    grpTypeDetails.Visible = false;
                    cboDescription.SelectedIndex = -1;
                    vehicles = VehicleType.getAvailableVehicleTypes();
                    if (vehicles != null)
                    {
                        if (vehicles.Tables[0].Rows.Count > 0)
                        {
                            Utility.fillComboBox(vehicles, cboDescription, "Vehicle_Types", 1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                        this.Close();
                        parent.Visible = true;
                    }
                    
                }
                //Amend Vehicle Type: Alternate Scenario: cannot write to file 
                else
                {
                    MessageBox.Show("Unable to write to Vehicle Types file. Exiting to main menu");
                    this.Close();
                    parent.Visible = true;
                }
            }
            else {
                return;
            }

        }

        private void mnuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
