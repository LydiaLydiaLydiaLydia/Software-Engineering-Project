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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createVehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //we did this part in class :) 22/11/23
            this.Hide();
            frmCreateVehicleType nextForm = new frmCreateVehicleType(this);
            nextForm.Show();
        }

        private void amendVehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAmendVehicleType nextForm = new frmAmendVehicleType(this);
            nextForm.Show();
        }

        private void discontinueVehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscontinueVehicleType nextForm = new frmDiscontinueVehicleType(this);
            nextForm.Show();
        }

        private void scheduleDeparturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleDepartures nextForm = new frmScheduleDepartures(this);
            nextForm.Show();
        }

        private void sellTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSellTicket nextForm = new frmSellTicket(this);
            nextForm.Show();
        }

        private void viewYearlyRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewYearlyRevenue nextForm = new frmViewYearlyRevenue(this);
            nextForm.Show();
        }

        private void analyseSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalyseSales nextForm = new frmAnalyseSales(this);
            nextForm.Show();
        }
    }
}
