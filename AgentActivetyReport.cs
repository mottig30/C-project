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
    public partial class AgentActivetyReport : Form
    {
        public string agentName;
        public string agentMail;
        public string agentId;
        public int counter;

        public AgentActivetyReport(string agentName, string agentMail, string agentId)
        {
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
     
            InitializeComponent();

            workerName.Text = "Hello" + " " + this.agentName;

            Fill_Agent_combo_box();
            Fill_Year_combo_box();
            this.counter = 0;
        }

 

        private void FormReport_Load(object sender, EventArgs e)
        {
   
            if (counter==1) {
                Fill_chart();
                string chooseAgentName = AgentNameCmobo.SelectedItem.ToString();
                AgentTitle.Text = chooseAgentName;
                
            }
            else
            {
                string messege = "Pleas clear the chart";
                string title = "Error";
                MessageBox.Show(messege, title);
            }
        }

        public void Fill_chart() {

           
            int choosenYear = int.Parse(yearCombo.SelectedItem.ToString());
            string chooseAgentName = AgentNameCmobo.SelectedItem.ToString();
           Worker agent= Program.seekWorker(chooseAgentName);

            for (int month = 1; month <= 11; month++)
            {
                int x = agent.ordersPerMonth(choosenYear, month);
                chart1.Series["Orders"].Points.AddXY(month, x);

            }
            this.counter = 1;



        }

        public void clear_chart()
        {
            chart1.Series["Orders"].Points.Clear();
            this.counter = 0;
        }

        public void Fill_Agent_combo_box() //choose the agent to report
        {

            List<string> AgentNames = new List<string>();

            foreach (Worker P in Program.Workers)
            {
                if (P.getWorkerType().ToString() == "agent")
                {
                    AgentNames.Add(P.getWorkerID());

                }

            }
            AgentNameCmobo.DataSource = AgentNames;
            
        }

 


        public void Fill_Year_combo_box() //choose the agent to report
        {
            List<int> Year = new List<int>();          
            Year.Add(2017);
            Year.Add(2018);
            Year.Add(2019);
            yearCombo.DataSource = Year;
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void AgentNameCmobo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgentActivity_Click(object sender, EventArgs e)
        {

        }

        private void LoadReport_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                Fill_chart();
                string chooseAgentName = AgentNameCmobo.SelectedItem.ToString();
                AgentTitle.Text = chooseAgentName;
            }
            else
            {
                string messege = "Pleas first clear the chart";
                string title = "Error";
                MessageBox.Show(messege, title);
            }
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgentTitle_Click(object sender, EventArgs e)
        {
            string chooseAgentName = AgentNameCmobo.SelectedItem.ToString();
            AgentTitle.Text = chooseAgentName;
        }

        private void AgentActivetyReport_Load(object sender, EventArgs e)
        {

        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            MainMenu mMS = new MainMenu(this.agentName, this.agentMail, this.agentId);
            mMS.Show();
            this.Hide();
        }

        private void LogeOUTButt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void workerName_Click(object sender, EventArgs e)
        {

        }

        private void generateReport_Click(object sender, EventArgs e)
        {
                clear_chart();           
                Fill_chart();
                string chooseAgentName = AgentNameCmobo.SelectedItem.ToString();              
                AgentTitle.Text = chooseAgentName;
                Fill_TotalOrderPrice_combo_box();
        }

        public void Fill_TotalOrderPrice_combo_box()
        {
            int choosenYear = int.Parse(yearCombo.SelectedItem.ToString());
            string chooseAgentName = AgentNameCmobo.SelectedItem.ToString();
            Worker agent = Program.seekWorker(chooseAgentName);
            for (int month = 1; month <= 11; month++)
            {
                float x = agent.sumOrdersPerMonth(choosenYear, month);
                string y = Convert.ToString(x);
                label3.Text = y;

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
