using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace JavierS
{
    public partial class yourOrdersButton : Form
    {
        private int O;
        private string to;
        private string agentName;
        private string agentMail;
        private string agentId;

        public yourOrdersButton(int O, string to, string agentName, string agentMail, string agentId)
        {
            this.O = O;
            this.to = to;
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            InitializeComponent();
            agentNameLabel.Text = "Hello" + " " + this.agentName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
               
        {                      
            Random rand = new Random();
            string randomOrderNumber = "order" + rand.Next(0, 1000000).ToString() + "." + "txt";
            StreamWriter file = new StreamWriter(randomOrderNumber);
            Order o = Program.seekOrder(this.O);
            o.UpdateOrderStatus("standBy");
            file.Write("Order number:" + " " + o.getOrderId().ToString() + Environment.NewLine);
            file.Write(Environment.NewLine);
            foreach (ItemInOrder i in o.itemsInOrderList)
            {

                file.Write("Item ID:" + " " + i.getItem().getItemId().ToString());
                file.Write(" ");
                file.Write("Item Color:" + " " + i.getItem().getItemColore());
                file.Write(" ");
                file.Write("Item size:" + " " + i.getItem().getItemSize());
                file.Write(" ");
                file.Write("Quantity:" + " " + i.getQuantity() + Environment.NewLine);
            }
            file.Close();
            string path = Environment.CurrentDirectory + "\\" + randomOrderNumber;//get the local path
            Email sentMailToSupplier = new Email(path, this.to);
            sentMailToSupplier.sendSupplierEmail(); 

        }

        private void agentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogeOutButt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void MyOrderButton_Click(object sender, EventArgs e)
        {
            MyOrders mO = new MyOrders(this.agentName, this.agentMail, this.agentId);
            mO.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu mMS = new MainMenu(this.agentName, this.agentMail, this.agentId);
            mMS.Show();
            this.Hide();
        }
    }
}
