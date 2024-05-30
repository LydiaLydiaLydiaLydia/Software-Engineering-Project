namespace FerrySYS
{
    partial class frmAmendVehicleType
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
            this.lblAmendVehicleType = new System.Windows.Forms.Label();
            this.cboDescription = new System.Windows.Forms.ComboBox();
            this.lblSelectDescription = new System.Windows.Forms.Label();
            this.grpTypeDetails = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAmend = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTypeDetails.SuspendLayout();
            this.mnuBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmendVehicleType
            // 
            this.lblAmendVehicleType.AutoSize = true;
            this.lblAmendVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendVehicleType.Location = new System.Drawing.Point(159, 24);
            this.lblAmendVehicleType.Name = "lblAmendVehicleType";
            this.lblAmendVehicleType.Size = new System.Drawing.Size(189, 24);
            this.lblAmendVehicleType.TabIndex = 9;
            this.lblAmendVehicleType.Text = "Amend Vehicle Type";
            // 
            // cboDescription
            // 
            this.cboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescription.FormattingEnabled = true;
            this.cboDescription.Location = new System.Drawing.Point(324, 76);
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(121, 21);
            this.cboDescription.TabIndex = 1;
            this.cboDescription.SelectedIndexChanged += new System.EventHandler(this.cboDescription_SelectedIndexChanged);
            // 
            // lblSelectDescription
            // 
            this.lblSelectDescription.AutoSize = true;
            this.lblSelectDescription.Location = new System.Drawing.Point(160, 79);
            this.lblSelectDescription.Name = "lblSelectDescription";
            this.lblSelectDescription.Size = new System.Drawing.Size(158, 13);
            this.lblSelectDescription.TabIndex = 18;
            this.lblSelectDescription.Text = "Select Vehicle Type Description";
            // 
            // grpTypeDetails
            // 
            this.grpTypeDetails.Controls.Add(this.txtCode);
            this.grpTypeDetails.Controls.Add(this.lblCode);
            this.grpTypeDetails.Controls.Add(this.btnAmend);
            this.grpTypeDetails.Controls.Add(this.txtPrice);
            this.grpTypeDetails.Controls.Add(this.lblPrice);
            this.grpTypeDetails.Controls.Add(this.txtDescription);
            this.grpTypeDetails.Controls.Add(this.lblDescription);
            this.grpTypeDetails.Location = new System.Drawing.Point(163, 117);
            this.grpTypeDetails.Name = "grpTypeDetails";
            this.grpTypeDetails.Size = new System.Drawing.Size(497, 261);
            this.grpTypeDetails.TabIndex = 19;
            this.grpTypeDetails.TabStop = false;
            this.grpTypeDetails.Text = "Vehicle Type Details";
            this.grpTypeDetails.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(299, 56);
            this.txtCode.MaxLength = 2;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 23;
            this.txtCode.Text = "VN";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(82, 59);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(100, 13);
            this.lblCode.TabIndex = 22;
            this.lblCode.Text = "Vehicle Type Code ";
            // 
            // btnAmend
            // 
            this.btnAmend.Location = new System.Drawing.Point(207, 208);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(75, 23);
            this.btnAmend.TabIndex = 4;
            this.btnAmend.Text = "Amend";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(298, 150);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(101, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "30.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(82, 153);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 13);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Vehicle Type Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(298, 106);
            this.txtDescription.MaxLength = 25;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Van";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(82, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(199, 13);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Vehicle Type Description (e.g., Car, Van)";
            // 
            // mnuBack
            // 
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(800, 24);
            this.mnuBack.TabIndex = 20;
            this.mnuBack.Text = "mnuBack";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(44, 20);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.mnuItemBack_Click);
            // 
            // frmAmendVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuBack);
            this.Controls.Add(this.grpTypeDetails);
            this.Controls.Add(this.lblSelectDescription);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.lblAmendVehicleType);
            this.Name = "frmAmendVehicleType";
            this.Text = "Vehicle Types | Amend Vehicle Type";
            this.Load += new System.EventHandler(this.frmAmendVehicleType_Load);
            this.grpTypeDetails.ResumeLayout(false);
            this.grpTypeDetails.PerformLayout();
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblAmendVehicleType;
        private System.Windows.Forms.ComboBox cboDescription;
        private System.Windows.Forms.Label lblSelectDescription;
        private System.Windows.Forms.GroupBox grpTypeDetails;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
    }
}