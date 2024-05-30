namespace FerrySYS
{
    partial class frmSellTicket
    {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblSellTicket = new System.Windows.Forms.Label();
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.grpTicketInformation = new System.Windows.Forms.GroupBox();
            this.txtDepTime = new System.Windows.Forms.TextBox();
            this.btnContinueToPayment = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.lblVehicleDescription = new System.Windows.Forms.Label();
            this.lblDep_Time = new System.Windows.Forms.Label();
            this.dtpDepDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpTicketInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(211, 78);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(105, 13);
            this.lblVehicleType.TabIndex = 1;
            this.lblVehicleType.Text = "Select Vehicle Type:";
            // 
            // lblSellTicket
            // 
            this.lblSellTicket.AutoSize = true;
            this.lblSellTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellTicket.Location = new System.Drawing.Point(190, 36);
            this.lblSellTicket.Name = "lblSellTicket";
            this.lblSellTicket.Size = new System.Drawing.Size(96, 24);
            this.lblSellTicket.TabIndex = 2;
            this.lblSellTicket.Text = "Sell Ticket";
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Location = new System.Drawing.Point(322, 75);
            this.cboVehicleType.Name = "cboVehicleType";
            this.cboVehicleType.Size = new System.Drawing.Size(121, 21);
            this.cboVehicleType.TabIndex = 1;
            // 
            // grpTicketInformation
            // 
            this.grpTicketInformation.Controls.Add(this.txtDepTime);
            this.grpTicketInformation.Controls.Add(this.btnContinueToPayment);
            this.grpTicketInformation.Controls.Add(this.txtPrice);
            this.grpTicketInformation.Controls.Add(this.lblPrice);
            this.grpTicketInformation.Controls.Add(this.txtVehicleDescription);
            this.grpTicketInformation.Controls.Add(this.lblVehicleDescription);
            this.grpTicketInformation.Controls.Add(this.lblDep_Time);
            this.grpTicketInformation.Controls.Add(this.dtpDepDate);
            this.grpTicketInformation.Controls.Add(this.label1);
            this.grpTicketInformation.Location = new System.Drawing.Point(194, 186);
            this.grpTicketInformation.Name = "grpTicketInformation";
            this.grpTicketInformation.Size = new System.Drawing.Size(369, 252);
            this.grpTicketInformation.TabIndex = 4;
            this.grpTicketInformation.TabStop = false;
            this.grpTicketInformation.Text = "Ticket Information";
            this.grpTicketInformation.Visible = false;
            // 
            // txtDepTime
            // 
            this.txtDepTime.Enabled = false;
            this.txtDepTime.Location = new System.Drawing.Point(118, 69);
            this.txtDepTime.Name = "txtDepTime";
            this.txtDepTime.Size = new System.Drawing.Size(100, 20);
            this.txtDepTime.TabIndex = 5;
            // 
            // btnContinueToPayment
            // 
            this.btnContinueToPayment.Location = new System.Drawing.Point(128, 199);
            this.btnContinueToPayment.Name = "btnContinueToPayment";
            this.btnContinueToPayment.Size = new System.Drawing.Size(80, 36);
            this.btnContinueToPayment.TabIndex = 8;
            this.btnContinueToPayment.Text = "Continue To Payment";
            this.btnContinueToPayment.UseVisualStyleBackColor = true;
            this.btnContinueToPayment.Click += new System.EventHandler(this.btnContinueToPayment_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(118, 147);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // txtVehicleDescription
            // 
            this.txtVehicleDescription.Enabled = false;
            this.txtVehicleDescription.Location = new System.Drawing.Point(118, 106);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleDescription.TabIndex = 6;
            // 
            // lblVehicleDescription
            // 
            this.lblVehicleDescription.AutoSize = true;
            this.lblVehicleDescription.Location = new System.Drawing.Point(19, 109);
            this.lblVehicleDescription.Name = "lblVehicleDescription";
            this.lblVehicleDescription.Size = new System.Drawing.Size(72, 13);
            this.lblVehicleDescription.TabIndex = 11;
            this.lblVehicleDescription.Text = "Vehicle Type:";
            // 
            // lblDep_Time
            // 
            this.lblDep_Time.AutoSize = true;
            this.lblDep_Time.Location = new System.Drawing.Point(19, 73);
            this.lblDep_Time.Name = "lblDep_Time";
            this.lblDep_Time.Size = new System.Drawing.Size(83, 13);
            this.lblDep_Time.TabIndex = 7;
            this.lblDep_Time.Text = "Departure Time:";
            // 
            // dtpDepDate
            // 
            this.dtpDepDate.Enabled = false;
            this.dtpDepDate.Location = new System.Drawing.Point(76, 32);
            this.dtpDepDate.Name = "dtpDepDate";
            this.dtpDepDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(211, 109);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(79, 13);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Departure Port:";
            // 
            // cboPorts
            // 
            this.cboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(322, 106);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(302, 137);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(139, 30);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Next Departure";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.grpTicketInformation);
            this.Controls.Add(this.cboVehicleType);
            this.Controls.Add(this.lblSellTicket);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblPort);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSellTicket";
            this.Text = "FerrySYS | Tickets | Sell Ticket";
            this.Load += new System.EventHandler(this.frmSellTicket_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpTicketInformation.ResumeLayout(false);
            this.grpTicketInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblSellTicket;
        private System.Windows.Forms.ComboBox cboVehicleType;
        private System.Windows.Forms.GroupBox grpTicketInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDepDate;
        private System.Windows.Forms.Label lblDep_Time;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtVehicleDescription;
        private System.Windows.Forms.Label lblVehicleDescription;
        private System.Windows.Forms.Button btnContinueToPayment;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtDepTime;
    }
}