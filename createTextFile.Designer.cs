namespace JavierS
{
    partial class yourOrdersButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yourOrdersButton));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MyOrderButton = new System.Windows.Forms.Button();
            this.agentNameLabel = new System.Windows.Forms.Label();
            this.LogeOutButt = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(188, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send order to supplier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.80198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order generated";
            // 
            // MyOrderButton
            // 
            this.MyOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MyOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyOrderButton.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MyOrderButton.ForeColor = System.Drawing.Color.White;
            this.MyOrderButton.Location = new System.Drawing.Point(188, 237);
            this.MyOrderButton.Name = "MyOrderButton";
            this.MyOrderButton.Size = new System.Drawing.Size(167, 48);
            this.MyOrderButton.TabIndex = 4;
            this.MyOrderButton.Text = "View your orders";
            this.MyOrderButton.UseVisualStyleBackColor = false;
            this.MyOrderButton.Click += new System.EventHandler(this.MyOrderButton_Click);
            // 
            // agentNameLabel
            // 
            this.agentNameLabel.AutoSize = true;
            this.agentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.agentNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agentNameLabel.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.agentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agentNameLabel.Location = new System.Drawing.Point(11, 9);
            this.agentNameLabel.Name = "agentNameLabel";
            this.agentNameLabel.Size = new System.Drawing.Size(42, 17);
            this.agentNameLabel.TabIndex = 5;
            this.agentNameLabel.Text = "label2";
            this.agentNameLabel.Click += new System.EventHandler(this.agentNameLabel_Click);
            // 
            // LogeOutButt
            // 
            this.LogeOutButt.AutoSize = true;
            this.LogeOutButt.BackColor = System.Drawing.Color.Transparent;
            this.LogeOutButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogeOutButt.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogeOutButt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogeOutButt.Location = new System.Drawing.Point(67, 9);
            this.LogeOutButt.Name = "LogeOutButt";
            this.LogeOutButt.Size = new System.Drawing.Size(61, 17);
            this.LogeOutButt.TabIndex = 6;
            this.LogeOutButt.TabStop = true;
            this.LogeOutButt.Text = "(Log-Out)";
            this.LogeOutButt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogeOutButt_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(528, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // yourOrdersButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogeOutButt);
            this.Controls.Add(this.agentNameLabel);
            this.Controls.Add(this.MyOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "yourOrdersButton";
            this.Text = "View your orders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MyOrderButton;
        private System.Windows.Forms.Label agentNameLabel;
        private System.Windows.Forms.LinkLabel LogeOutButt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}