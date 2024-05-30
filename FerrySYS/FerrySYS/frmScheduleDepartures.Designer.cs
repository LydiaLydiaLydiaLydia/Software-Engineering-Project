namespace FerrySYS
{
    partial class frmScheduleDepartures
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
            this.components = new System.ComponentModel.Container();
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lblStartingTime = new System.Windows.Forms.Label();
            this.dtpFirstDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dtpDuration = new System.Windows.Forms.DateTimePicker();
            this.dtpEndBy = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTimetable = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.grdTimetable = new System.Windows.Forms.DataGridView();
            this.mnuBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuBack.Size = new System.Drawing.Size(800, 24);
            this.mnuBack.TabIndex = 0;
            this.mnuBack.Text = "menuStrip1";
            this.mnuBack.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuBack_ItemClicked);
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(44, 20);
            this.mnuItemBack.Text = "Back";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(27, 139);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(68, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Starting Port:";
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(146, 136);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 1;
            // 
            // lblStartingTime
            // 
            this.lblStartingTime.AutoSize = true;
            this.lblStartingTime.Location = new System.Drawing.Point(16, 191);
            this.lblStartingTime.Name = "lblStartingTime";
            this.lblStartingTime.Size = new System.Drawing.Size(79, 13);
            this.lblStartingTime.TabIndex = 3;
            this.lblStartingTime.Text = "First Departure:";
            // 
            // dtpFirstDeparture
            // 
            this.dtpFirstDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFirstDeparture.Location = new System.Drawing.Point(146, 184);
            this.dtpFirstDeparture.Name = "dtpFirstDeparture";
            this.dtpFirstDeparture.Size = new System.Drawing.Size(200, 20);
            this.dtpFirstDeparture.TabIndex = 2;
            this.dtpFirstDeparture.TabStop = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 246);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(83, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Journey Length:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(51, 297);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(44, 13);
            this.lblFinish.TabIndex = 7;
            this.lblFinish.Text = "End By:";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(133, 347);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(122, 23);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Generate Timetable";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dtpDuration
            // 
            this.dtpDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDuration.Location = new System.Drawing.Point(146, 239);
            this.dtpDuration.Name = "dtpDuration";
            this.dtpDuration.Size = new System.Drawing.Size(200, 20);
            this.dtpDuration.TabIndex = 3;
            this.dtpDuration.TabStop = false;
            // 
            // dtpEndBy
            // 
            this.dtpEndBy.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndBy.Location = new System.Drawing.Point(146, 297);
            this.dtpEndBy.Name = "dtpEndBy";
            this.dtpEndBy.Size = new System.Drawing.Size(200, 20);
            this.dtpEndBy.TabIndex = 4;
            this.dtpEndBy.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTimetable
            // 
            this.lblTimetable.AutoSize = true;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.Location = new System.Drawing.Point(543, 37);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(93, 24);
            this.lblTimetable.TabIndex = 15;
            this.lblTimetable.Text = "Timetable";
            this.lblTimetable.Visible = false;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(15, 71);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(193, 24);
            this.lblSchedule.TabIndex = 16;
            this.lblSchedule.Text = "Schedule Departures:";
            // 
            // grdTimetable
            // 
            this.grdTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTimetable.Location = new System.Drawing.Point(401, 83);
            this.grdTimetable.Name = "grdTimetable";
            this.grdTimetable.ReadOnly = true;
            this.grdTimetable.RowHeadersWidth = 51;
            this.grdTimetable.Size = new System.Drawing.Size(378, 335);
            this.grdTimetable.TabIndex = 17;
            this.grdTimetable.Visible = false;
            // 
            // frmScheduleDepartures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdTimetable);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblTimetable);
            this.Controls.Add(this.dtpEndBy);
            this.Controls.Add(this.dtpDuration);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpFirstDeparture);
            this.Controls.Add(this.lblStartingTime);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.mnuBack);
            this.MainMenuStrip = this.mnuBack;
            this.Name = "frmScheduleDepartures";
            this.Text = "Departures | Schedule Departures";
            this.Load += new System.EventHandler(this.frmScheduleDepartures_Load);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuItmBack;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label lblStartingTime;
        private System.Windows.Forms.DateTimePicker dtpFirstDeparture;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DateTimePicker dtpDuration;
        private System.Windows.Forms.DateTimePicker dtpEndBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTimetable;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.DataGridView grdTimetable;
    }
}