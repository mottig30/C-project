namespace JavierS
{
    partial class LogInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInScreen));
            this.LogInButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.credentialsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogInButton.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(297, 258);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(155, 31);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserNameLabel.Location = new System.Drawing.Point(185, 168);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(87, 21);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User Name";
            this.UserNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordLabel.Location = new System.Drawing.Point(185, 216);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(77, 21);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(297, 170);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.UserNameTextBox.TabIndex = 3;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // credentialsLabel
            // 
            this.credentialsLabel.AutoSize = true;
            this.credentialsLabel.BackColor = System.Drawing.Color.Transparent;
            this.credentialsLabel.Font = new System.Drawing.Font("Calibri", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.credentialsLabel.ForeColor = System.Drawing.Color.Red;
            this.credentialsLabel.Location = new System.Drawing.Point(294, 129);
            this.credentialsLabel.Name = "credentialsLabel";
            this.credentialsLabel.Size = new System.Drawing.Size(170, 17);
            this.credentialsLabel.TabIndex = 5;
            this.credentialsLabel.Text = "Your credentials is not valid";
            this.credentialsLabel.Click += new System.EventHandler(this.credentialsLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24.95049F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(164, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Javier Simora Israel";
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.credentialsLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LogInButton);
            this.DoubleBuffered = true;
            this.Name = "LogInScreen";
            this.Text = "LogInScreen";
            this.Load += new System.EventHandler(this.LogInScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label credentialsLabel;
        private System.Windows.Forms.Label label1;
    }
}