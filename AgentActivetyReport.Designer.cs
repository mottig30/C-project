namespace JavierS

{
    partial class AgentActivetyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentActivetyReport));
            this.AgentActivity = new System.Windows.Forms.Label();
            this.AgentNameCmobo = new System.Windows.Forms.ComboBox();
            this.AgentName = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.AgentTitle = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.LogeOUTButt = new System.Windows.Forms.LinkLabel();
            this.workerName = new System.Windows.Forms.Label();
            this.generateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalRevlabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentActivity
            // 
            this.AgentActivity.AutoSize = true;
            this.AgentActivity.BackColor = System.Drawing.Color.Transparent;
            this.AgentActivity.Font = new System.Drawing.Font("Calibri", 36.35643F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgentActivity.Location = new System.Drawing.Point(243, 47);
            this.AgentActivity.Name = "AgentActivity";
            this.AgentActivity.Size = new System.Drawing.Size(470, 63);
            this.AgentActivity.TabIndex = 0;
            this.AgentActivity.Text = "Agent Activity Report";
            this.AgentActivity.Click += new System.EventHandler(this.AgentActivity_Click);
            // 
            // AgentNameCmobo
            // 
            this.AgentNameCmobo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgentNameCmobo.FormattingEnabled = true;
            this.AgentNameCmobo.Location = new System.Drawing.Point(185, 248);
            this.AgentNameCmobo.Name = "AgentNameCmobo";
            this.AgentNameCmobo.Size = new System.Drawing.Size(121, 21);
            this.AgentNameCmobo.TabIndex = 1;
            this.AgentNameCmobo.SelectedIndexChanged += new System.EventHandler(this.AgentNameCmobo_SelectedIndexChanged);
            // 
            // AgentName
            // 
            this.AgentName.AutoSize = true;
            this.AgentName.BackColor = System.Drawing.Color.Transparent;
            this.AgentName.Font = new System.Drawing.Font("Calibri", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgentName.Location = new System.Drawing.Point(57, 243);
            this.AgentName.Name = "AgentName";
            this.AgentName.Size = new System.Drawing.Size(118, 26);
            this.AgentName.TabIndex = 2;
            this.AgentName.Text = "Agent Name";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(340, 198);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Orders";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(538, 365);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Calibri", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearLabel.Location = new System.Drawing.Point(57, 295);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(47, 26);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Year";
            // 
            // yearCombo
            // 
            this.yearCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.Location = new System.Drawing.Point(185, 295);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(121, 21);
            this.yearCombo.TabIndex = 12;
            this.yearCombo.SelectedIndexChanged += new System.EventHandler(this.yearCombo_SelectedIndexChanged);
            // 
            // AgentTitle
            // 
            this.AgentTitle.AutoSize = true;
            this.AgentTitle.BackColor = System.Drawing.Color.Transparent;
            this.AgentTitle.Font = new System.Drawing.Font("Calibri", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgentTitle.Location = new System.Drawing.Point(496, 144);
            this.AgentTitle.Name = "AgentTitle";
            this.AgentTitle.Size = new System.Drawing.Size(139, 31);
            this.AgentTitle.TabIndex = 13;
            this.AgentTitle.Text = "Agent Name";
            this.AgentTitle.Click += new System.EventHandler(this.AgentTitle_Click);
            // 
            // backHome
            // 
            this.backHome.BackColor = System.Drawing.Color.Transparent;
            this.backHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backHome.BackgroundImage")));
            this.backHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backHome.FlatAppearance.BorderSize = 0;
            this.backHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHome.ForeColor = System.Drawing.Color.Transparent;
            this.backHome.Location = new System.Drawing.Point(967, 511);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(46, 42);
            this.backHome.TabIndex = 15;
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // LogeOUTButt
            // 
            this.LogeOUTButt.AutoSize = true;
            this.LogeOUTButt.BackColor = System.Drawing.Color.Transparent;
            this.LogeOUTButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogeOUTButt.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogeOUTButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogeOUTButt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogeOUTButt.Location = new System.Drawing.Point(73, 19);
            this.LogeOUTButt.Name = "LogeOUTButt";
            this.LogeOUTButt.Size = new System.Drawing.Size(61, 17);
            this.LogeOUTButt.TabIndex = 24;
            this.LogeOUTButt.TabStop = true;
            this.LogeOUTButt.Text = "(Log-Out)";
            this.LogeOUTButt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogeOUTButt_LinkClicked);
            // 
            // workerName
            // 
            this.workerName.AutoSize = true;
            this.workerName.BackColor = System.Drawing.Color.Transparent;
            this.workerName.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.workerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.workerName.Location = new System.Drawing.Point(10, 19);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(42, 17);
            this.workerName.TabIndex = 25;
            this.workerName.Text = "label1";
            this.workerName.Click += new System.EventHandler(this.workerName_Click);
            // 
            // generateReport
            // 
            this.generateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateReport.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.generateReport.ForeColor = System.Drawing.Color.White;
            this.generateReport.Location = new System.Drawing.Point(62, 334);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(244, 29);
            this.generateReport.TabIndex = 26;
            this.generateReport.Text = "Generate Report";
            this.generateReport.UseVisualStyleBackColor = false;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(381, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(777, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Month";
            // 
            // TotalRevlabel3
            // 
            this.TotalRevlabel3.AutoSize = true;
            this.TotalRevlabel3.BackColor = System.Drawing.Color.Transparent;
            this.TotalRevlabel3.Font = new System.Drawing.Font("Calibri", 14.25743F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TotalRevlabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalRevlabel3.Location = new System.Drawing.Point(776, 355);
            this.TotalRevlabel3.Name = "TotalRevlabel3";
            this.TotalRevlabel3.Size = new System.Drawing.Size(134, 24);
            this.TotalRevlabel3.TabIndex = 29;
            this.TotalRevlabel3.Text = "Total Revenue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(916, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AgentActivetyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalRevlabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.LogeOUTButt);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.AgentTitle);
            this.Controls.Add(this.yearCombo);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.AgentName);
            this.Controls.Add(this.AgentNameCmobo);
            this.Controls.Add(this.AgentActivity);
            this.DoubleBuffered = true;
            this.Name = "AgentActivetyReport";
            this.Text = "AgentActivetyReport";
            this.Load += new System.EventHandler(this.AgentActivetyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgentActivity;
        private System.Windows.Forms.ComboBox AgentNameCmobo;
        private System.Windows.Forms.Label AgentName;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.Label AgentTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.LinkLabel LogeOUTButt;
        private System.Windows.Forms.Label workerName;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalRevlabel3;
        private System.Windows.Forms.Label label3;
    }
}