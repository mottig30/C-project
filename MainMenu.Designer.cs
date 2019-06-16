namespace JavierS
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.createOrderButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.workerNameLabel = new System.Windows.Forms.Label();
            this.CreateCustomerButt = new System.Windows.Forms.Button();
            this.LogOutButt = new System.Windows.Forms.LinkLabel();
            this.UpdateOrderButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createOrderButt
            // 
            this.createOrderButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createOrderButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createOrderButt.Font = new System.Drawing.Font("Calibri", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createOrderButt.ForeColor = System.Drawing.Color.White;
            this.createOrderButt.Location = new System.Drawing.Point(247, 148);
            this.createOrderButt.Name = "createOrderButt";
            this.createOrderButt.Size = new System.Drawing.Size(243, 49);
            this.createOrderButt.TabIndex = 0;
            this.createOrderButt.Text = "Generate Order";
            this.createOrderButt.UseVisualStyleBackColor = false;
            this.createOrderButt.Click += new System.EventHandler(this.createOrderButt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(247, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Worker Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workerNameLabel
            // 
            this.workerNameLabel.AutoSize = true;
            this.workerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.workerNameLabel.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.workerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.workerNameLabel.Location = new System.Drawing.Point(11, 9);
            this.workerNameLabel.Name = "workerNameLabel";
            this.workerNameLabel.Size = new System.Drawing.Size(42, 17);
            this.workerNameLabel.TabIndex = 2;
            this.workerNameLabel.Text = "label1";
            this.workerNameLabel.Click += new System.EventHandler(this.workerNameLabel_Click);
            // 
            // CreateCustomerButt
            // 
            this.CreateCustomerButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateCustomerButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCustomerButt.Font = new System.Drawing.Font("Calibri", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateCustomerButt.ForeColor = System.Drawing.Color.White;
            this.CreateCustomerButt.ImageKey = "(none)";
            this.CreateCustomerButt.Location = new System.Drawing.Point(247, 288);
            this.CreateCustomerButt.Name = "CreateCustomerButt";
            this.CreateCustomerButt.Size = new System.Drawing.Size(243, 49);
            this.CreateCustomerButt.TabIndex = 3;
            this.CreateCustomerButt.Text = "Create New Customer";
            this.CreateCustomerButt.UseVisualStyleBackColor = false;
            this.CreateCustomerButt.Click += new System.EventHandler(this.CreateCustomerButt_Click);
            // 
            // LogOutButt
            // 
            this.LogOutButt.AutoSize = true;
            this.LogOutButt.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButt.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogOutButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogOutButt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogOutButt.Location = new System.Drawing.Point(69, 9);
            this.LogOutButt.Name = "LogOutButt";
            this.LogOutButt.Size = new System.Drawing.Size(61, 17);
            this.LogOutButt.TabIndex = 4;
            this.LogOutButt.TabStop = true;
            this.LogOutButt.Text = "(Log-Out)";
            this.LogOutButt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutButt_LinkClicked);
            // 
            // UpdateOrderButt
            // 
            this.UpdateOrderButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateOrderButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateOrderButt.Font = new System.Drawing.Font("Calibri", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateOrderButt.ForeColor = System.Drawing.Color.Snow;
            this.UpdateOrderButt.Location = new System.Drawing.Point(247, 218);
            this.UpdateOrderButt.Name = "UpdateOrderButt";
            this.UpdateOrderButt.Size = new System.Drawing.Size(243, 49);
            this.UpdateOrderButt.TabIndex = 5;
            this.UpdateOrderButt.Text = "View Orders";
            this.UpdateOrderButt.UseVisualStyleBackColor = false;
            this.UpdateOrderButt.Click += new System.EventHandler(this.UpdateOrderButt_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 511);
            this.Controls.Add(this.UpdateOrderButt);
            this.Controls.Add(this.LogOutButt);
            this.Controls.Add(this.CreateCustomerButt);
            this.Controls.Add(this.workerNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createOrderButt);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createOrderButt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label workerNameLabel;
        private System.Windows.Forms.Button CreateCustomerButt;
        private System.Windows.Forms.LinkLabel LogOutButt;
        private System.Windows.Forms.Button UpdateOrderButt;
    }
}