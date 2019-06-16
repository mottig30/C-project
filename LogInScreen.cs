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
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
            credentialsLabel.Hide();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Worker w = Program.seekWorker(UserNameTextBox.Text);

            if(UserNameTextBox.Text.Length < 1 || PasswordLabel.Text.Length <1)
            {
                credentialsLabel.Show(); 
            }

            if(w!= null)
            {
                if(w.getEmail()== textBox2.Text){
                    MainMenu m = new MainMenu(w.getFirstName(),w.getEmail(),w.getWorkerID());
                    m.Show();
                    this.Hide();
                }
                else
                {
                    credentialsLabel.Show();
                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void credentialsLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {



        }
    }
}
