namespace JavierSimorra
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.EnumSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Calibri", 47.76237F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(149, 173);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(121, 21);
            this.CustomerList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Worker Name: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(636, 252);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(120, 21);
            this.Quantity.TabIndex = 5;
            // 
            // EnumSize
            // 
            this.EnumSize.FormattingEnabled = true;
            this.EnumSize.Location = new System.Drawing.Point(490, 251);
            this.EnumSize.Name = "EnumSize";
            this.EnumSize.Size = new System.Drawing.Size(121, 21);
            this.EnumSize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(487, 227);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(27, 14);
            this.Size.TabIndex = 8;
            this.Size.Text = "Size";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(340, 227);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(32, 14);
            this.Color.TabIndex = 9;
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Model";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(196, 252);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.SystemColors.Window;
            this.AddItem.Location = new System.Drawing.Point(681, 290);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 13;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "*option to add new customer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Priview item list (including supplier details)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(296, 509);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(161, 23);
            this.sendButton.TabIndex = 17;
            this.sendButton.Text = "Send Order To Supplier";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(57, 254);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 18);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "JavierSimorra";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.radioButton2.Location = new System.Drawing.Point(57, 279);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 18);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Joseph Ribkoff";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Supplier";
            this.BackgroundImage = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 235);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "workerName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 554);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnumSize);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form2";
            this.Text = "Joseph Ribkuff";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.ComboBox EnumSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
    }
}