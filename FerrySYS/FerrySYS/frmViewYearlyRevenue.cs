using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FerrySYS
{
    public partial class frmViewYearlyRevenue : Form
    {
        //main menu object reference
        frmMainMenu parent;

        //years for combo box
        DataSet yearsActive = new DataSet();

        public frmViewYearlyRevenue()
        {
            InitializeComponent();
        }

        //one argument constructor
        public frmViewYearlyRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectYear.SelectedIndex != -1) {
                DataSet chartData = Ticket.viewRevenue(yearsActive.Tables[0].Rows[cboSelectYear.SelectedIndex][0].ToString());
                string[] months = new string[12];
                decimal[] revenue = new decimal[12];

                if (chartData != null)
                {
                    if (chartData.Tables[0].Rows.Count > 0)
                    {
                        int monthsAvail = 0;
                        for (int i = 0; i < chartData.Tables["Revenue"].Rows.Count; i++)
                        {
                            months[i] = chartData.Tables[0].Rows[i][0].ToString().Substring(3,3);
                            revenue[i] = decimal.Parse(chartData.Tables[0].Rows[i][1].ToString());

                            monthsAvail++;
                        }
                        while (monthsAvail < months.Length)
                        {
                            months[monthsAvail] = "N/A";
                            revenue[monthsAvail] = 0;
                            monthsAvail++;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Unable to retrieve revenue details for year" + cboSelectYear.SelectedItem.ToString() + ". Sorry! Returning to Main Menu");
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

                chtRevenue.DataSource = chartData;
                chtRevenue.Visible = true;

                chtRevenue.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtRevenue.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtRevenue.Series[0].LegendText = "Income in €";
                chtRevenue.Series[0].Points.DataBindXY(months, revenue);
                chtRevenue.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C";
                chtRevenue.ChartAreas["ChartArea1"].AxisX.Interval = 1;



            }
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmViewYearlyRevenue_Load(object sender, EventArgs e)
        {
            //get years we've been active
            yearsActive = Ticket.yearsAvailable();

            //put them in the combo box for selection
            if (yearsActive != null)
            {
                if (yearsActive.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < yearsActive.Tables["Years"].Rows.Count; i++)
                    {
                        cboSelectYear.Items.Add("20" + yearsActive.Tables[0].Rows[i][0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Unable to retrieve Ticket details. Sorry! Returning to Main Menu");
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
    }
}
