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
    public partial class MainMenu : Form
    {

        public string agentName;
        public string agentMail;
        public string agentId;
        public MainMenu(string agentName, string agentMail, string agentId)
        {
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            InitializeComponent();
            workerNameLabel.Text = "Hello" + " " + this.agentName;
        }

        private void workerNameLabel_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Worker w = Program.seekWorker(this.agentId);
            if (w.getWorkerType().ToString()!= "manager")
            {
                string messege = "This option open only to managers";
                string title = "Access Deny";
                MessageBox.Show(messege, title);
            }

            else//worker is maneger
            {
                AgentActivetyReport ar = new AgentActivetyReport(this.agentName, this.agentMail, this.agentId);
                ar.Show();
                this.Hide();

            }
        }

        private void createOrderButt_Click(object sender, EventArgs e)
        {
            GenerateOrder gO = new GenerateOrder(this.agentName, this.agentMail, this.agentId);
            gO.Show();
            this.Hide();
        }

        private void CreateCustomerButt_Click(object sender, EventArgs e)
        {

            CreateNewCustomerScreen cNCS = new CreateNewCustomerScreen(this.agentName, this.agentMail, this.agentId,true);
            cNCS.Show();
            this.Hide();
        }

        private void LogOutButt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void UpdateOrderButt_Click(object sender, EventArgs e)
        {
            MyOrders mO = new MyOrders(this.agentName, this.agentMail, this.agentId);
            mO.Show();
            this.Hide();
        }
    }
}
