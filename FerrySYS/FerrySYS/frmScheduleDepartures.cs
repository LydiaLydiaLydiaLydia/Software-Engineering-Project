using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FerrySYS
{
    public partial class frmScheduleDepartures : Form
    {
        //Use Case ID 04: Schedule Departures

        //main menu object reference
        frmMainMenu parent;

        //ports dataset
        DataSet ports = new DataSet();

        //is there a timetable
        DataSet timetable = new DataSet();

        public frmScheduleDepartures()
        {
            InitializeComponent();
            dtpFirstDeparture.Format = DateTimePickerFormat.Time;
            dtpFirstDeparture.ShowUpDown = true;
            dtpFirstDeparture.Width = 100;
            Controls.Add(dtpFirstDeparture);
        }

        //form constructor with argument
        public frmScheduleDepartures(frmMainMenu parent)
        {
            InitializeComponent();

            dtpFirstDeparture.Format = DateTimePickerFormat.Time;
            dtpFirstDeparture.ShowUpDown = true;
            dtpFirstDeparture.Width = 50;
            Controls.Add(dtpFirstDeparture);

            dtpDuration.Format = DateTimePickerFormat.Time;
            dtpDuration.ShowUpDown = true;
            dtpDuration.Width = 50;
            Controls.Add(dtpDuration);

            dtpEndBy.Format = DateTimePickerFormat.Time;
            dtpEndBy.Width = 50;
            dtpEndBy.ShowUpDown = true;
            Controls.Add(dtpEndBy);

            this.parent = parent;
        }

        private void frmScheduleDepartures_Load(object sender, EventArgs e)
        {
            //loading ports data set for use in combo box
            ports = Port.getPorts();

            //Use Case 04: Step 3
            timetable = Departure.getTimetable();

            if (ports != null)
            {
                if (ports.Tables[0].Rows.Count > 0)
                {

                    Utility.fillComboBox(ports, cboPort, "Prts", 1);
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

            if (timetable != null)
            {
                if (timetable.Tables[0].Rows.Count > 0)
                {
                    //display timetable
                    grdTimetable.AutoGenerateColumns = true;
                    grdTimetable.DataSource = timetable;
                    grdTimetable.DataMember = "Timetable";
                    lblTimetable.Visible = true;
                    grdTimetable.Visible = true;

                    //getting the substrings of the times and filling the dtps with them
                    DateTime firstDep = new DateTime(2023, 01, 01, Int32.Parse((grdTimetable.Rows[0].Cells[1].Value.ToString()).Substring(0, 2)),
                    Int32.Parse((grdTimetable.Rows[0].Cells[1].Value.ToString()).Substring(3, 2)), 00);
                    dtpFirstDeparture.Value = firstDep;

                    //get the dep time and arrival time of the first record
                    DateTime firstArr = new DateTime(2023, 01, 01, Int32.Parse((grdTimetable.Rows[0].Cells[2].Value.ToString()).Substring(0, 2)),
                    Int32.Parse((grdTimetable.Rows[0].Cells[2].Value.ToString()).Substring(3, 2)), 00);
                    TimeSpan jLength = firstArr.Subtract(firstDep);

                    dtpDuration.Value = new DateTime(2023, 01, 01, jLength.Hours, jLength.Minutes, jLength.Seconds);

                    //need to deal with what happens when there is no second departure
                    if (timetable.Tables[0].Rows.Count == 1)
                    {
                        dtpEndBy.Value = firstArr;
                    }
                    else
                    {
                        //find the last dep
                        dtpEndBy.Value = new DateTime(2023, 01, 01, Int32.Parse((grdTimetable.Rows[timetable.Tables[0].Rows.Count - 1].Cells[2].Value.ToString()).Substring(0, 2)),
                        Int32.Parse((grdTimetable.Rows[timetable.Tables[0].Rows.Count - 1].Cells[2].Value.ToString()).Substring(3, 2)), 00);
                    }
                    if (grdTimetable.Rows[0].Cells[0].Value.ToString().Equals(cboPort.Items[0].ToString()))
                    {
                        cboPort.SelectedIndex = 0;
                    }
                    else
                    {
                        cboPort.SelectedIndex = 1;
                    }
                }
                else
                {
                    //Use Case 04: Alternate Scenario, no departures exist
                    dtpFirstDeparture.Value = new DateTime(2023, 01, 01, 00, 00, 00);
                    dtpDuration.Value = new DateTime(2023, 01, 01, 0, 0, 0);
                    dtpEndBy.Value = new DateTime(2023, 01, 01, 0, 0, 0);

                    //display nothing in the timetable area
                    MessageBox.Show("Departures file is empty, no current timetable to display");
                }
            }
            else
            {
                MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                this.Close();
                parent.Visible = true;
            }

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //Business rule: There will be a buffer of 10 minutes between the scheduled arrival and departure
            TimeSpan hcBuffer = new TimeSpan(0, 10, 0);

            //Use Case 04: Step 5
            String startingPort = cboPort.Text;
            TimeSpan firstDep = dtpFirstDeparture.Value.TimeOfDay;

            //Chopping off the milliseconds so entry is exactly what the user entered
            int miliseconds = firstDep.Milliseconds;
            firstDep = firstDep.Subtract(new TimeSpan(0,0,miliseconds));

            TimeSpan journeyLength = dtpDuration.Value.TimeOfDay;
            miliseconds = journeyLength.Milliseconds;
            journeyLength = journeyLength.Subtract(new TimeSpan(0, 0, miliseconds));

            TimeSpan finishBy = dtpEndBy.Value.TimeOfDay;
            miliseconds = finishBy.Milliseconds;
            finishBy = finishBy.Subtract(new TimeSpan(0, 0, miliseconds));


            //VALIDATION
            if (cboPort.SelectedIndex == -1) {
                MessageBox.Show("Please select a Port");
                return;
            }
            if ((journeyLength.TotalMinutes <= 0) || (journeyLength.TotalMinutes >= (24*60))){
                MessageBox.Show("Journey Length must be greater that 00:00 and less than 24:00hrs");
                return;
            }
            if (finishBy.TotalMinutes < (firstDep.TotalMinutes + journeyLength.TotalMinutes) ){
                MessageBox.Show("End time must be greater than the time of the first departure plus the length of one journey");
                return;
            }

            //Use Case 04: Step 6
            //GENERATING TIMETABLE
            //Instantiating departures in a list while and putting them in a datatable for display in the UI
            DataTable newTim = new DataTable();
            newTim.Columns.Add("DEPARTURE_PORT");
            newTim.Columns.Add("DEPARTURE_TIME");
            newTim.Columns.Add("ARRIVAL_TIME");
            grdTimetable.DataSource = newTim;

            //First Departure Time and first Arrival Time
            TimeSpan DepTime = firstDep;
            TimeSpan ArrTime = DepTime.Add(journeyLength);
            
            int nextID = Departure.getNextID();
            int counter = 0;
            var DepList = new List<Departure>();
            while ((DepTime < finishBy) && (ArrTime <= finishBy))
            {
                DepList.Add(new Departure());
                DepList[counter].setId(nextID);
                DepList[counter].setDep_Time(new DateTime(2023, 01, 01, 00, 00, 00) + DepTime);
                DepList[counter].setArr_Time(new DateTime(2023, 01, 01, 00, 00, 00) + ArrTime);
                newTim.Rows.Add(startingPort, DepTime.ToString("t").Substring(0, 5), ArrTime.ToString("t").Substring(0, 5));

                if (startingPort.Equals("Mainland"))
                { 
                    DepList[counter].setDep_Port('M');
                    startingPort = "Island";
                }
                else if (startingPort.Equals("Island"))
                {
                    DepList[counter].setDep_Port('I');
                    startingPort = "Mainland";
                }
                DepTime = ArrTime.Add(hcBuffer);
                ArrTime = DepTime.Add(journeyLength);
                counter++;
                nextID++;
            }
            //Use Case 04: Step 7
            grdTimetable.Visible = true;
            lblTimetable.Visible = true;

            //Use Case 04: Step 8
            if (MessageBox.Show("Confirm new timetable", "New Timetable", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) {
                //Use Case 04: Step 10
                Departure.deactivateDepartures();

                //Use Case 04: Step 11
                for (int i = 0; i < DepList.Count; i++) {
                    DepList[i].scheduleDeparture();
                }

                //Use Case 04: Step 12
                MessageBox.Show("New Timetable has been generated!");

                //Use Case 04: Step 14
                timetable = Departure.getTimetable();
                grdTimetable.DataSource = timetable;
                grdTimetable.AutoGenerateColumns = true;
                grdTimetable.DataMember = "Timetable";
                grdTimetable.Visible = true;
            }

        }

       

        private void mnuBack_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void mnuItmBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
