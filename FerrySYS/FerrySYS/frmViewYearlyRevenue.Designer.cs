namespace FerrySYS
{
    partial class frmViewYearlyRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.chtRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(800, 24);
            this.mnuBack.TabIndex = 0;
            this.mnuBack.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Location = new System.Drawing.Point(12, 79);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(71, 13);
            this.lblSelectYear.TabIndex = 1;
            this.lblSelectYear.Text = "Select a Year";
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectYear.FormattingEnabled = true;
            this.cboSelectYear.Location = new System.Drawing.Point(89, 76);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(121, 21);
            this.cboSelectYear.TabIndex = 1;
            this.cboSelectYear.SelectedIndexChanged += new System.EventHandler(this.cboSelectYear_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(303, 41);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(191, 24);
            this.lblRevenue.TabIndex = 6;
            this.lblRevenue.Text = "View Yearly Revenue";
            // 
            // chtRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRevenue.Legends.Add(legend1);
            this.chtRevenue.Location = new System.Drawing.Point(58, 108);
            this.chtRevenue.Name = "chtRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRevenue.Series.Add(series1);
            this.chtRevenue.Size = new System.Drawing.Size(683, 300);
            this.chtRevenue.TabIndex = 7;
            this.chtRevenue.Text = "chart1";
            this.chtRevenue.Visible = false;
            // 
            // frmViewYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chtRevenue);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboSelectYear);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.mnuBack);
            this.MainMenuStrip = this.mnuBack;
            this.Name = "frmViewYearlyRevenue";
            this.Text = "FerrySYS | Administration | View Yearly Revenue";
            this.Load += new System.EventHandler(this.frmViewYearlyRevenue_Load);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.ComboBox cboSelectYear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenue;
    }
}