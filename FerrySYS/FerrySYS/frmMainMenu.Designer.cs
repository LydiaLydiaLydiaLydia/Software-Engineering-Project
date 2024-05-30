//to connect to the database
using Oracle.ManagedDataAccess.Client;

namespace FerrySYS
{
    partial class frmMainMenu
    {
        //database stuff
        OracleConnection conn = new OracleConnection(DBConnect.oraDB);

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createVehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendVehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinueVehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDeparturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewYearlyRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsToolStripMenuItem,
            this.departuresToolStripMenuItem,
            this.ticketsToolStripMenuItem1,
            this.administrationToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            this.mnuMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createVehicleTypeToolStripMenuItem,
            this.amendVehicleTypeToolStripMenuItem,
            this.discontinueVehicleTypeToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.ticketsToolStripMenuItem.Text = "Vehicle Types";
            // 
            // createVehicleTypeToolStripMenuItem
            // 
            this.createVehicleTypeToolStripMenuItem.Name = "createVehicleTypeToolStripMenuItem";
            this.createVehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.createVehicleTypeToolStripMenuItem.Text = "Create Vehicle Type";
            this.createVehicleTypeToolStripMenuItem.Click += new System.EventHandler(this.createVehicleTypeToolStripMenuItem_Click);
            // 
            // amendVehicleTypeToolStripMenuItem
            // 
            this.amendVehicleTypeToolStripMenuItem.Name = "amendVehicleTypeToolStripMenuItem";
            this.amendVehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.amendVehicleTypeToolStripMenuItem.Text = "Amend Vehicle Type";
            this.amendVehicleTypeToolStripMenuItem.Click += new System.EventHandler(this.amendVehicleTypeToolStripMenuItem_Click);
            // 
            // discontinueVehicleTypeToolStripMenuItem
            // 
            this.discontinueVehicleTypeToolStripMenuItem.Name = "discontinueVehicleTypeToolStripMenuItem";
            this.discontinueVehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.discontinueVehicleTypeToolStripMenuItem.Text = "Discontinue Vehicle Type";
            this.discontinueVehicleTypeToolStripMenuItem.Click += new System.EventHandler(this.discontinueVehicleTypeToolStripMenuItem_Click);
            // 
            // departuresToolStripMenuItem
            // 
            this.departuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleDeparturesToolStripMenuItem});
            this.departuresToolStripMenuItem.Name = "departuresToolStripMenuItem";
            this.departuresToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.departuresToolStripMenuItem.Text = "Departures";
            // 
            // scheduleDeparturesToolStripMenuItem
            // 
            this.scheduleDeparturesToolStripMenuItem.Name = "scheduleDeparturesToolStripMenuItem";
            this.scheduleDeparturesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.scheduleDeparturesToolStripMenuItem.Text = "Schedule Departures";
            this.scheduleDeparturesToolStripMenuItem.Click += new System.EventHandler(this.scheduleDeparturesToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem1
            // 
            this.ticketsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellTicketToolStripMenuItem});
            this.ticketsToolStripMenuItem1.Name = "ticketsToolStripMenuItem1";
            this.ticketsToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.ticketsToolStripMenuItem1.Text = "Tickets";
            // 
            // sellTicketToolStripMenuItem
            // 
            this.sellTicketToolStripMenuItem.Name = "sellTicketToolStripMenuItem";
            this.sellTicketToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sellTicketToolStripMenuItem.Text = "Sell Ticket";
            this.sellTicketToolStripMenuItem.Click += new System.EventHandler(this.sellTicketToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewYearlyRevenueToolStripMenuItem,
            this.analyseSalesToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // viewYearlyRevenueToolStripMenuItem
            // 
            this.viewYearlyRevenueToolStripMenuItem.Name = "viewYearlyRevenueToolStripMenuItem";
            this.viewYearlyRevenueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewYearlyRevenueToolStripMenuItem.Text = "View Yearly Revenue";
            this.viewYearlyRevenueToolStripMenuItem.Click += new System.EventHandler(this.viewYearlyRevenueToolStripMenuItem_Click);
            // 
            // analyseSalesToolStripMenuItem
            // 
            this.analyseSalesToolStripMenuItem.Name = "analyseSalesToolStripMenuItem";
            this.analyseSalesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.analyseSalesToolStripMenuItem.Text = "Analyse Sales";
            this.analyseSalesToolStripMenuItem.Click += new System.EventHandler(this.analyseSalesToolStripMenuItem_Click);
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenu.Image")));
            this.picMainMenu.Location = new System.Drawing.Point(0, 27);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(800, 423);
            this.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMainMenu.TabIndex = 1;
            this.picMainMenu.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "FerrySYS";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createVehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendVehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinueVehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDeparturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sellTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewYearlyRevenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseSalesToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMainMenu;
    }
}

