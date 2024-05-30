using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Use Case ID 01 Create Vehicle Type

namespace FerrySYS
{
    public partial class frmCreateVehicleType : Form
    {
        //making an object reference to the main menu
        frmMainMenu parent;

        VehicleType vehicleType;
        private List<String> codes;

        public frmCreateVehicleType()
        {
            InitializeComponent();
        }

        //constructor that takes main menu as an argument
        public frmCreateVehicleType(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }


        //Create Vehicle Type: Step 2
        private void frmCreateVehicleType_Load(object sender, EventArgs e)
        {
            vehicleType = new VehicleType();
            //Step 5
            codes = VehicleType.getVehicleCodes();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create Vehicle Type: Step 6
            if (VehicleType.validateVehicleInput(txtDescription.Text, txtCode.Text.ToUpper(), txtPrice.Text, codes))
            {
                //Create Vehicle Type: Step 7
                vehicleType.setCode(txtCode.Text.ToUpper());
                vehicleType.setDescription(txtDescription.Text);
                vehicleType.setPrice(decimal.Parse(txtPrice.Text));

                if (vehicleType.addVehicleType())
                {
                    MessageBox.Show("Vehicle Type\n" + $"Description: {txtDescription.Text}" + "\n" + $"Code: {txtCode.Text}\n" + $"Price: {txtPrice.Text}\nSaved Successfully.");
                    codes = VehicleType.getVehicleCodes();
                    txtCode.Text = "";
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                }
                //Create Vehicle Type Alternate Scenario: System unable to write to the Vehicle Types file
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

    }
}
