using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace FerrySYS
{
    public partial class frmSellTicket : Form
    {
        //Use Case ID 05: Sell Ticket

        //menu object reference
        frmMainMenu parent;

        Ticket currentTicket = new Ticket();
        DataSet ports;
        DataSet vehicles;
        DataSet departures;

        public frmSellTicket()
        {
            InitializeComponent();
        }

        //constructor with argument
        public frmSellTicket(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void frmSellTicket_Load(object sender, EventArgs e)
        {
            //Step 2
            vehicles = VehicleType.getAvailableVehicleTypes();
            ports = Port.getPorts();

            //Step 3
            currentTicket.setCode(Ticket.getNextID());
            currentTicket.setDateAndTime(DateTime.Now);

            //Step 4
            if (vehicles != null)
            {
                if (vehicles.Tables[0].Rows.Count > 0)
                {
                    Utility.fillComboBox(vehicles, cboVehicleType, "Vehicle_Types", 1);
                }
                else
                {
                    MessageBox.Show("No entries in the Vehicle Types file. Please create a Vehicle Type for which to buy a ticket to continue.");
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Unable to read from the Vehicle Types file. Returning to Main Menu");
                this.Close();
                parent.Visible = true;
            }

            if (ports != null)
            {
                if (ports.Tables[0].Rows.Count > 0)
                {

                    Utility.fillComboBox(ports, cboPorts, "Prts", 1);
                }
                else
                {
                    MessageBox.Show("Unable to retrieve Port details. Sorry! Returning to Main Menu");
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                this.Close();
                parent.Visible = true;
                return;
            }

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cboVehicleType.SelectedIndex >= 0)
            {
                if (cboPorts.SelectedIndex >= 0)
                {
                    //Step 6
                    departures = Departure.getTimetable(cboPorts.SelectedItem.ToString());

                    //Step 7
                    if (departures != null)
                    {
                        if (departures.Tables[0].Rows.Count > 0)
                        {

                            int nextDepRow = -1;
                            for (int i = 0; i < departures.Tables[0].Rows.Count; i++)
                            {
                                if (DateTime.Now.Hour == Int32.Parse(departures.Tables[0].Rows[i][1].ToString().Substring(0, 2)))
                                {

                                    if (DateTime.Now.Minute < Int32.Parse(departures.Tables[0].Rows[i][1].ToString().Substring(3, 2)))
                                    {
                                        nextDepRow = i; break;
                                    }
                                }
                                else if (DateTime.Now.Hour < Int32.Parse(departures.Tables[0].Rows[i][1].ToString().Substring(0, 2)))
                                {
                                    nextDepRow = i; break;
                                }
                            }
                            if (nextDepRow == -1)
                            {
                                MessageBox.Show("No remaining Departures from this port today. Please try again tomorrow. Sorry!");
                                this.Close();
                                parent.Visible = true;
                            }
                            else
                            {
                                //Assign DepID, vehicle code, price to ticket, and display for review
                                currentTicket.setDepId(Int32.Parse(departures.Tables[0].Rows[nextDepRow][3].ToString()));
                                currentTicket.setVCode(vehicles.Tables[0].Rows[cboVehicleType.SelectedIndex][0].ToString());
                                currentTicket.setPrice(decimal.Parse(vehicles.Tables[0].Rows[cboVehicleType.SelectedIndex][2].ToString()));
                                dtpDepDate.Value = currentTicket.getDateAndTime();
                                txtDepTime.Text = departures.Tables[0].Rows[nextDepRow][1].ToString();
                                txtVehicleDescription.Text = cboVehicleType.SelectedItem.ToString();
                                txtPrice.Text = vehicles.Tables[0].Rows[cboVehicleType.SelectedIndex][2].ToString();

                                //Step 8
                                grpTicketInformation.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Departures file is empty, you cannot purchase a ticket. Please shcedule departures in order to proceed");
                            this.Close();
                            parent.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select the Departure Port");
                }
            }
            else
            {
                MessageBox.Show("Please select a Vehicle to travel");
            }
        }
        private void btnContinueToPayment_Click(object sender, EventArgs e)
        {
            //Step 10
            if (MessageBox.Show("On Receipt of Payment, press OK to Print Receipt", "Payment", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                //Step 12
                currentTicket.saveTicket();
                MessageBox.Show(String.Format("{0}\nOutbound: {1} Port\nDeparts at: {2}\nVehicle: {3}\nPrice: €{4:00.00}", 
                    currentTicket.getDateAndTime(), 
                    cboPorts.SelectedItem.ToString(),
                    txtDepTime.Text,
                    cboVehicleType.SelectedItem.ToString(),
                    currentTicket.getPrice()), "TICKET");
                currentTicket = new Ticket();
                currentTicket.setCode(Ticket.getNextID());
                cboVehicleType.SelectedIndex = -1;
                grpTicketInformation.Visible = false;

            }
            else {
                currentTicket = new Ticket();
                currentTicket.setCode(Ticket.getNextID());
                MessageBox.Show("Transaction Cancelled");
                cboVehicleType.SelectedIndex = -1;
                grpTicketInformation.Visible = false;
            }
        }
        
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
