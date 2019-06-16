namespace JavierS
{
    partial class MyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrders));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusComboBox1 = new System.Windows.Forms.ComboBox();
            this.customerLabel1 = new System.Windows.Forms.Label();
            this.OrserStatusLabel1 = new System.Windows.Forms.Label();
            this.CustomerComboBox2 = new System.Windows.Forms.ComboBox();
            this.seeAllMyOrdersbutton1 = new System.Windows.Forms.Button();
            this.UpdateItemsStaBott = new System.Windows.Forms.Button();
            this.OConfirmationBott = new System.Windows.Forms.Button();
            this.AgentNameLabel = new System.Windows.Forms.Label();
            this.LogeOutButten = new System.Windows.Forms.LinkLabel();
            this.GoToMain = new System.Windows.Forms.PictureBox();
            this.sendOrderButt = new System.Windows.Forms.Button();
            this.EditOrderButt = new System.Windows.Forms.Button();
            this.filterlabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(19, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StatusComboBox1
            // 
            this.StatusComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusComboBox1.FormattingEnabled = true;
            this.StatusComboBox1.Location = new System.Drawing.Point(112, 112);
            this.StatusComboBox1.Name = "StatusComboBox1";
            this.StatusComboBox1.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox1.TabIndex = 2;
            this.StatusComboBox1.Text = "Select";
            this.StatusComboBox1.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox1_SelectedIndexChanged);
            // 
            // customerLabel1
            // 
            this.customerLabel1.AutoSize = true;
            this.customerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customerLabel1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customerLabel1.Location = new System.Drawing.Point(255, 113);
            this.customerLabel1.Name = "customerLabel1";
            this.customerLabel1.Size = new System.Drawing.Size(66, 17);
            this.customerLabel1.TabIndex = 3;
            this.customerLabel1.Text = "Customer:";
            // 
            // OrserStatusLabel1
            // 
            this.OrserStatusLabel1.AutoSize = true;
            this.OrserStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.OrserStatusLabel1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OrserStatusLabel1.Location = new System.Drawing.Point(23, 116);
            this.OrserStatusLabel1.Name = "OrserStatusLabel1";
            this.OrserStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.OrserStatusLabel1.TabIndex = 4;
            this.OrserStatusLabel1.Text = "Order Status:";
            // 
            // CustomerComboBox2
            // 
            this.CustomerComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerComboBox2.FormattingEnabled = true;
            this.CustomerComboBox2.Location = new System.Drawing.Point(327, 112);
            this.CustomerComboBox2.Name = "CustomerComboBox2";
            this.CustomerComboBox2.Size = new System.Drawing.Size(121, 21);
            this.CustomerComboBox2.TabIndex = 5;
            this.CustomerComboBox2.Text = "Select";
            this.CustomerComboBox2.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox2_SelectedIndexChanged);
            // 
            // seeAllMyOrdersbutton1
            // 
            this.seeAllMyOrdersbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.seeAllMyOrdersbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeAllMyOrdersbutton1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.seeAllMyOrdersbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seeAllMyOrdersbutton1.Location = new System.Drawing.Point(473, 110);
            this.seeAllMyOrdersbutton1.Name = "seeAllMyOrdersbutton1";
            this.seeAllMyOrdersbutton1.Size = new System.Drawing.Size(110, 28);
            this.seeAllMyOrdersbutton1.TabIndex = 6;
            this.seeAllMyOrdersbutton1.Text = "See All Orders";
            this.seeAllMyOrdersbutton1.UseVisualStyleBackColor = false;
            this.seeAllMyOrdersbutton1.Click += new System.EventHandler(this.seeAllMyOrdersbutton1_Click);
            // 
            // UpdateItemsStaBott
            // 
            this.UpdateItemsStaBott.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateItemsStaBott.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateItemsStaBott.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateItemsStaBott.ForeColor = System.Drawing.Color.White;
            this.UpdateItemsStaBott.Location = new System.Drawing.Point(604, 152);
            this.UpdateItemsStaBott.Name = "UpdateItemsStaBott";
            this.UpdateItemsStaBott.Size = new System.Drawing.Size(184, 45);
            this.UpdateItemsStaBott.TabIndex = 7;
            this.UpdateItemsStaBott.Text = "Update Items Status";
            this.UpdateItemsStaBott.UseVisualStyleBackColor = false;
            this.UpdateItemsStaBott.Click += new System.EventHandler(this.UpdateItemsStaBott_Click);
            // 
            // OConfirmationBott
            // 
            this.OConfirmationBott.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OConfirmationBott.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OConfirmationBott.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OConfirmationBott.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OConfirmationBott.Location = new System.Drawing.Point(604, 220);
            this.OConfirmationBott.Name = "OConfirmationBott";
            this.OConfirmationBott.Size = new System.Drawing.Size(184, 45);
            this.OConfirmationBott.TabIndex = 8;
            this.OConfirmationBott.Text = "Order Confirmation";
            this.OConfirmationBott.UseVisualStyleBackColor = false;
            this.OConfirmationBott.Click += new System.EventHandler(this.OConfirmationBott_Click);
            // 
            // AgentNameLabel
            // 
            this.AgentNameLabel.AutoSize = true;
            this.AgentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgentNameLabel.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AgentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgentNameLabel.Location = new System.Drawing.Point(16, 9);
            this.AgentNameLabel.Name = "AgentNameLabel";
            this.AgentNameLabel.Size = new System.Drawing.Size(42, 17);
            this.AgentNameLabel.TabIndex = 9;
            this.AgentNameLabel.Text = "label1";
            this.AgentNameLabel.Click += new System.EventHandler(this.AgentNameLabel_Click);
            // 
            // LogeOutButten
            // 
            this.LogeOutButten.AutoSize = true;
            this.LogeOutButten.BackColor = System.Drawing.Color.Transparent;
            this.LogeOutButten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogeOutButten.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogeOutButten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogeOutButten.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogeOutButten.Location = new System.Drawing.Point(77, 9);
            this.LogeOutButten.Name = "LogeOutButten";
            this.LogeOutButten.Size = new System.Drawing.Size(61, 17);
            this.LogeOutButten.TabIndex = 10;
            this.LogeOutButten.TabStop = true;
            this.LogeOutButten.Text = "(Log-Out)";
            this.LogeOutButten.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogeOutButten_LinkClicked);
            // 
            // GoToMain
            // 
            this.GoToMain.BackColor = System.Drawing.Color.Transparent;
            this.GoToMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoToMain.BackgroundImage")));
            this.GoToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToMain.Location = new System.Drawing.Point(736, 435);
            this.GoToMain.Name = "GoToMain";
            this.GoToMain.Size = new System.Drawing.Size(52, 50);
            this.GoToMain.TabIndex = 11;
            this.GoToMain.TabStop = false;
            this.GoToMain.Click += new System.EventHandler(this.GoToMain_Click);
            // 
            // sendOrderButt
            // 
            this.sendOrderButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendOrderButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendOrderButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendOrderButt.Location = new System.Drawing.Point(604, 292);
            this.sendOrderButt.Name = "sendOrderButt";
            this.sendOrderButt.Size = new System.Drawing.Size(184, 45);
            this.sendOrderButt.TabIndex = 12;
            this.sendOrderButt.Text = "Send to supllier";
            this.sendOrderButt.UseVisualStyleBackColor = false;
            this.sendOrderButt.Click += new System.EventHandler(this.sendOrderButt_Click);
            // 
            // EditOrderButt
            // 
            this.EditOrderButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditOrderButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditOrderButt.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EditOrderButt.ForeColor = System.Drawing.Color.White;
            this.EditOrderButt.Location = new System.Drawing.Point(604, 355);
            this.EditOrderButt.Name = "EditOrderButt";
            this.EditOrderButt.Size = new System.Drawing.Size(184, 45);
            this.EditOrderButt.TabIndex = 13;
            this.EditOrderButt.Text = "Edit Order";
            this.EditOrderButt.UseVisualStyleBackColor = false;
            this.EditOrderButt.Click += new System.EventHandler(this.EditOrderButt_Click);
            // 
            // filterlabel1
            // 
            this.filterlabel1.AutoSize = true;
            this.filterlabel1.BackColor = System.Drawing.Color.Transparent;
            this.filterlabel1.Font = new System.Drawing.Font("Calibri", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.filterlabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterlabel1.Location = new System.Drawing.Point(22, 86);
            this.filterlabel1.Name = "filterlabel1";
            this.filterlabel1.Size = new System.Drawing.Size(54, 19);
            this.filterlabel1.TabIndex = 0;
            this.filterlabel1.Text = "Filters:";
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.filterlabel1);
            this.Controls.Add(this.seeAllMyOrdersbutton1);
            this.Controls.Add(this.CustomerComboBox2);
            this.Controls.Add(this.OrserStatusLabel1);
            this.Controls.Add(this.customerLabel1);
            this.Controls.Add(this.StatusComboBox1);
            this.Controls.Add(this.EditOrderButt);
            this.Controls.Add(this.sendOrderButt);
            this.Controls.Add(this.GoToMain);
            this.Controls.Add(this.LogeOutButten);
            this.Controls.Add(this.AgentNameLabel);
            this.Controls.Add(this.OConfirmationBott);
            this.Controls.Add(this.UpdateItemsStaBott);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyOrders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox StatusComboBox1;
        private System.Windows.Forms.Label customerLabel1;
        private System.Windows.Forms.Label OrserStatusLabel1;
        private System.Windows.Forms.ComboBox CustomerComboBox2;
        private System.Windows.Forms.Button seeAllMyOrdersbutton1;
        private System.Windows.Forms.Button UpdateItemsStaBott;
        private System.Windows.Forms.Button OConfirmationBott;
        private System.Windows.Forms.Label AgentNameLabel;
        private System.Windows.Forms.LinkLabel LogeOutButten;
        private System.Windows.Forms.PictureBox GoToMain;
        private System.Windows.Forms.Button sendOrderButt;
        private System.Windows.Forms.Button EditOrderButt;
        private System.Windows.Forms.Label filterlabel1;
    }
}