namespace FerrySYS
{
    partial class frmDiscontinueVehicleType
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
            this.lblSelectDescription = new System.Windows.Forms.Label();
            this.cboDescription = new System.Windows.Forms.ComboBox();
            this.lblDiscontinueVehicleType = new System.Windows.Forms.Label();
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpVehicleDetails = new System.Windows.Forms.GroupBox();
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.grpVehicleDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectDescription
            // 
            this.lblSelectDescription.AutoSize = true;
            this.lblSelectDescription.Location = new System.Drawing.Point(164, 113);
            this.lblSelectDescription.Name = "lblSelectDescription";
            this.lblSelectDescription.Size = new System.Drawing.Size(158, 13);
            this.lblSelectDescription.TabIndex = 29;
            this.lblSelectDescription.Text = "Select Vehicle Type Description";
            // 
            // cboDescription
            // 
            this.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescription.FormattingEnabled = true;
            this.cboDescription.Location = new System.Drawing.Point(328, 110);
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(121, 21);
            this.cboDescription.TabIndex = 1;
            this.cboDescription.SelectedIndexChanged += new System.EventHandler(this.cboDescription_SelectedIndexChanged);
            // 
            // lblDiscontinueVehicleType
            // 
            this.lblDiscontinueVehicleType.AutoSize = true;
            this.lblDiscontinueVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscontinueVehicleType.Location = new System.Drawing.Point(163, 55);
            this.lblDiscontinueVehicleType.Name = "lblDiscontinueVehicleType";
            this.lblDiscontinueVehicleType.Size = new System.Drawing.Size(226, 24);
            this.lblDiscontinueVehicleType.TabIndex = 20;
            this.lblDiscontinueVehicleType.Text = "Discontinue Vehicle Type";
            // 
            // mnuBack
            // 
            this.mnuBack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBack.Size = new System.Drawing.Size(800, 24);
            this.mnuBack.TabIndex = 19;
            this.mnuBack.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpVehicleDetails
            // 
            this.grpVehicleDetails.Controls.Add(this.btnDiscontinue);
            this.grpVehicleDetails.Controls.Add(this.txtPrice);
            this.grpVehicleDetails.Controls.Add(this.lblPrice);
            this.grpVehicleDetails.Controls.Add(this.txtCode);
            this.grpVehicleDetails.Controls.Add(this.lblCode);
            this.grpVehicleDetails.Controls.Add(this.txtDescription);
            this.grpVehicleDetails.Controls.Add(this.lblDescription);
            this.grpVehicleDetails.Location = new System.Drawing.Point(167, 156);
            this.grpVehicleDetails.Name = "grpVehicleDetails";
            this.grpVehicleDetails.Size = new System.Drawing.Size(498, 204);
            this.grpVehicleDetails.TabIndex = 30;
            this.grpVehicleDetails.TabStop = false;
            this.grpVehicleDetails.Text = "Vehicle Type Details";
            this.grpVehicleDetails.Visible = false;
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.Location = new System.Drawing.Point(227, 163);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(75, 23);
            this.btnDiscontinue.TabIndex = 5;
            this.btnDiscontinue.Text = "Discontinue";
            this.btnDiscontinue.UseVisualStyleBackColor = true;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(319, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(101, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(103, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 13);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "Vehicle Type Price";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(319, 94);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(102, 97);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(211, 13);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "Vehicle Type Code (a 2 character identifier)";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(319, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(103, 58);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(199, 13);
            this.lblDescription.TabIndex = 28;
            this.lblDescription.Text = "Vehicle Type Description (e.g., Car, Van)";
            // 
            // frmDiscontinueVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpVehicleDetails);
            this.Controls.Add(this.lblSelectDescription);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.lblDiscontinueVehicleType);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmDiscontinueVehicleType";
            this.Text = "frmDiscontinueVehicleType";
            this.Load += new System.EventHandler(this.frmDiscontinueVehicleType_Load);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.grpVehicleDetails.ResumeLayout(false);
            this.grpVehicleDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDescription;
        private System.Windows.Forms.ComboBox cboDescription;
        private System.Windows.Forms.Label lblDiscontinueVehicleType;
        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpVehicleDetails;
        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}