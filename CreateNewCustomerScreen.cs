using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavierS
{
    public partial class CreateNewCustomerScreen : Form
    {
        private string agentName;
        private string agentMail;
        private string agentId;
        private bool fromMain;


        public CreateNewCustomerScreen(string agentName, string agentMail, string agentId,bool fromMain)
        {
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            this.fromMain = fromMain;
            InitializeComponent();
            workerName.Text= "Hello" + " " + this.agentName;
            //InitializeComponent();
            EmailLabelMan.Hide();
            PhoneLabelMandatory.Hide();
            CustomerNameManLabel.Hide();
            mainMandatoryLabel.Hide();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LatNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryLabel_Click(object sender, EventArgs e)
        {

        }

        private void CityLabel_Click(object sender, EventArgs e)
        {

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void StreetLabel_Click(object sender, EventArgs e)
        {

        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void CreatButton_Click(object sender, EventArgs e)
        {
            bool create = true;
            if(PhoneTextBox.Text.Length < 1)
            {
                mainMandatoryLabel.Show();
                PhoneLabelMandatory.Show();
                create = false;
            }

            if (EmailTextBox.Text.Length < 1)
            {
                mainMandatoryLabel.Show();
                EmailLabelMan.Show();
                create = false;
            }

            if (CustomerNameTextBox.Text.Length<1)
            {
                mainMandatoryLabel.Show();
                CustomerNameManLabel.Show();
                create = false;
            }

            if (PhoneTextBox.Text.Length != 9 && PhoneTextBox.Text.Length !=10  )
            {
                string messege = "Phone number must be 9 digits";
                string title = "Error";
                MessageBox.Show(messege, title);
                create = false;
            }



            if (EmailTextBox.Text.Contains("@") == false) {
                string messege = "Your Email Address is not valid";
                string title = "Error";
                MessageBox.Show(messege, title);
                create = false;
            }
            if (IsDigitsOnly(ZipCodeTextBox.Text)==false) {          
                MessageBox.Show("ZipCode-Only digits allowed", "Error");
                create = false;
            }

            if (create == true) { 
                EnumCustomerType T = (EnumCustomerType)Enum.Parse(typeof(EnumCustomerType), "silver");
                int intZip = Int32.Parse(ZipCodeTextBox.Text);
                    Customer newC = new Customer(EmailTextBox.Text, CustomerNameTextBox.Text, LatNameTextBox.Text, PhoneTextBox.Text, CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, intZip, T, true);
                    string messege = "New Customer Created";
                    MessageBox.Show(messege);
                if (this.fromMain == false)
                {
                    GenerateOrder gO = new GenerateOrder(this.agentName, this.agentMail, this.agentId);
                    gO.Show();
                    this.Hide();
                }

                else
                {
                    MainMenu mM = new MainMenu(this.agentName, this.agentMail, this.agentId);
                    mM.Show();
                    this.Hide();
                }
            }

    }

        private void CreateNewCustomerScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void mainMandatoryLabel_Click(object sender, EventArgs e)
        {
            mainMandatoryLabel.Hide();
        }

        private void CustomerNameManLabel_Click(object sender, EventArgs e)
        {
            CustomerNameManLabel.Hide();
        }

        private void PhoneLabelMandatory_Click(object sender, EventArgs e)
        {
            PhoneLabelMandatory.Hide();
        }

        private void EmailLabelMan_Click(object sender, EventArgs e)
        {
            EmailLabelMan.Hide();
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogeOUTButt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            if (this.fromMain == true)
            {
                MainMenu mMS = new MainMenu(this.agentName, this.agentMail, this.agentId);
                mMS.Show();
                this.Hide();
            }

            if (this.fromMain == false)
            {
                GenerateOrder Go = new GenerateOrder(this.agentName, this.agentMail, this.agentId);
                Go.Show();
                this.Hide();
            }
        }

        private void workerName_Click(object sender, EventArgs e)
        {

        }

public bool IsDigitsOnly(string str)
{
    foreach (char c in str)
    {
        if (c < '0' || c > '9')
            return false;
    }

    return true;
}
    }
}
     