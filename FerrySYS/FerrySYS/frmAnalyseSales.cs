using Oracle.ManagedDataAccess.Client;
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
    public partial class frmAnalyseSales : Form
    {
        //Use Case ID 6: View Yearly Revenue  

        //main menu object reference
        frmMainMenu parent;

        DataSet yearsActive = new DataSet();

        public frmAnalyseSales()
        {
            InitializeComponent();
        }

        //the one argument constructor
        public frmAnalyseSales(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void frmAnalyseSales_Load(object sender, EventArgs e)
        {
            //Step 2
            yearsActive = Ticket.yearsAvailable();

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
                    //Alternate scenario 
                    MessageBox.Show("Unable to retrieve Ticket details. Sorry! Returning to Main Menu");
                    this.Close();
                    parent.Visible = true;
                }
            }
            else
            {
                //Alternate scenario
                MessageBox.Show("Unable to connect to the database. Returning to Main Menu");
                this.Close();
                parent.Visible = true;
                return;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboSelectYear.SelectedIndex != -1)
            {
                //Step 5
                DataSet chartData = analysisQuery(yearsActive.Tables[0].Rows[cboSelectYear.SelectedIndex][0].ToString());

                if (chartData != null)
                {
                    //Step 6
                    if (chartData.Tables[0].Rows.Count > 0)
                    {
                        string[] vehicles = new string[chartData.Tables[0].Rows.Count];
                        int[] amount = new int[vehicles.Length];

                        for (int i = 0; i < chartData.Tables["VehicleAnalysis"].Rows.Count; i++)
                        {
                            vehicles[i] = chartData.Tables[0].Rows[i][0].ToString();
                            amount[i] = int.Parse(chartData.Tables[0].Rows[i][1].ToString());
                        }

                        chtAnalyseSales.DataSource = chartData;
                        chtAnalyseSales.Visible = true;

                        chtAnalyseSales.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                        chtAnalyseSales.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                        chtAnalyseSales.Series[0].LegendText = "Amount of Tickets Purchased";
                        chtAnalyseSales.Series[0].Points.DataBindXY(vehicles, amount);
                        chtAnalyseSales.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                    }
                    else
                    {
                        MessageBox.Show("Unable to retrieve sales analysis details for year" + cboSelectYear.SelectedItem.ToString() + ". Sorry! Returning to Main Menu");
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
        //Step 8
            private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

       
        public static DataSet analysisQuery(String year)
        {
            //Step 6
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);

                String sqlQuery = "SELECT V.V_Description, COUNT(T.T_Code) " +
                    "FROM Tickets T JOIN Vehicle_Types V ON T.V_Code = V.V_Code " +
                    "WHERE T_Date LIKE '%" + year + "' " +
                    "GROUP BY V.V_Description ";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "VehicleAnalysis");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
