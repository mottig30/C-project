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
    public partial class MyOrders : Form
    {
        DataTable dt1 = new DataTable();
        public string agentName;
        public string agentMail;
        public string agentId;
        

        public MyOrders(string agentName, string agentMail, string agentId)
        {
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            InitializeComponent();
            GridView_Load();
            this.agentId = agentId;
            AgentNameLabel.Text = "Hello" + " " + this.agentName;
            Worker agent = Program.seekWorker(agentId);
            foreach(Order O in agent.agentOrders)
            {
                if(O.itemsInOrderList.Count > 0)
                dt1.Rows.Add(O.getOrderId().ToString(),O.getDateOfOrder().ToString(), O.getOrderStatus().ToString(), O.getCustomer().getFullName(), O.getSupplier().getName());
            }
            dataGridView1.DataSource = dt1;
            Fill_Customer_box();
            StatusComboBox1.DataSource = Enum.GetValues(typeof(EnumOrderStatus));
        }

        public void Fill_Customer_box()
        {
            Worker agent = Program.seekWorker(agentId);
            foreach (Order O in agent.agentOrders)
            {
                if (!CustomerComboBox2.Items.Contains(O.getCustomer().getEmail()))
                    CustomerComboBox2.Items.Add(O.getCustomer().getEmail());
            }
        }

        private void GridView_Load()
        {
            dt1.Columns.AddRange(new DataColumn[5] { new DataColumn("Order ID", typeof(string)), new DataColumn("Date Of Order", typeof(string)),new DataColumn("Status", typeof(string)),
            new DataColumn("Customer", typeof(string)),new DataColumn("Supplier", typeof(string))});
            this.dataGridView1.DataSource = dt1;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void StatusComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = StatusComboBox1.SelectedItem.ToString();            
            dt1.Rows.Clear();
            Worker agent = Program.seekWorker(this.agentId);
            foreach (Order O in agent.agentOrders)
            {
                if (O.getOrderStatus().ToString().Equals(click) && O.itemsInOrderList.Count > 0)
                {
                    dt1.Rows.Add(O.getOrderId().ToString(), O.getDateOfOrder().ToString(), O.getOrderStatus().ToString(), O.getCustomer().getFullName(), O.getSupplier().getName());
                }
            }
            dataGridView1.DataSource = dt1;
           
        }

        private void CustomerComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = CustomerComboBox2.SelectedItem.ToString();
            Customer C = Program.seekCustomer(click);
            dt1.Rows.Clear();
            foreach (Order O in C.orderCustomer)
            {
                if( O.itemsInOrderList.Count > 0)
                dt1.Rows.Add(O.getOrderId().ToString(), O.getDateOfOrder().ToString(), O.getOrderStatus().ToString(), O.getCustomer().getFullName(), O.getSupplier().getName());
            }
            dataGridView1.DataSource = dt1;

        }

        private void seeAllMyOrdersbutton1_Click(object sender, EventArgs e)
        {
            Worker agent = Program.seekWorker(this.agentId);
            dt1.Clear();

            foreach (Order O in agent.agentOrders)
            {
                if (O.itemsInOrderList.Count > 0)
                    dt1.Rows.Add(O.getOrderId().ToString(), O.getDateOfOrder().ToString(), O.getOrderStatus().ToString(), O.getCustomer().getFullName(), O.getSupplier().getName());
            }
            dataGridView1.DataSource = dt1;
        }

        private void OConfirmationBott_Click(object sender, EventArgs e)
        {
            bool empty = false;
            if (dt1.Rows.Count == 0)
            {
                empty = true;
                MessageBox.Show("Pleas Choose order", "Error");
            }

            if (empty == false) { 
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            if (newDataRow.Cells[2].Value.Equals("standBy"))
            {

                newDataRow.Cells[2].Value = "confirmed";
                string OrderID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                Order O = Program.seekOrder(int.Parse(OrderID));
                O.getCustomer().getEmail();
                O.UpdateOrderStatus("confirmed");
                Email sendCustomerMail = new Email("empty", O.getCustomer().getEmail());
                sendCustomerMail.sendCustomerEmail(O.getOrderId());
            }
            else
            {
                    if (newDataRow.Cells[2].Value.Equals("draft"))
                    {
                        MessageBox.Show("The order did not sent to the supplier!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else
                    {
                        MessageBox.Show("The order alrady confirmed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }            
            }
        }
        }

        private void AgentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogeOutButten_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            MainMenu mMS = new MainMenu(this.agentName, this.agentMail, this.agentId);
            mMS.Show();
            this.Hide();
        }

        private void UpdateItemsStaBott_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            string OrderID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            Order O = Program.seekOrder(int.Parse(OrderID));
            if (O.getOrderStatus().ToString().Equals("confirmed"))
            {
                UpdateItemStatus uIS = new UpdateItemStatus(OrderID,this.agentName,this.agentMail,this.agentId);
                uIS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Order don't confirmed, can't update status items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        
    }

        private void button1_Click(object sender, EventArgs e)//motti new button
        {

        }

        private void sendOrderButt_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            string OrderID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            Order O = Program.seekOrder(int.Parse(OrderID));
            if (O.getOrderStatus().ToString().Equals("draft"))
            {
                string supplierName = O.getSupplier().getName();
                Supplier s = Program.seekSupplier(supplierName);
                Random rand = new Random();
                string randomOrderNumber = "order" + rand.Next(0, 1000000).ToString() + "." + "txt";
                StreamWriter file = new StreamWriter(randomOrderNumber);
                O.UpdateOrderStatus("standBy");
                file.Write("Order number:" + " " + O.getOrderId().ToString() + Environment.NewLine);
                file.Write(Environment.NewLine);
                foreach (ItemInOrder i in O.itemsInOrderList)
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
                Email sentMailToSupplier = new Email(path,s.getEmail());
                sentMailToSupplier.sendSupplierEmail();
                dataGridView1.Rows[rowIndex].Cells[2].Value = "standBy";
                MessageBox.Show("Order Sended");

            }
            else
            {
                MessageBox.Show("Your order already sended","Error");
            }
        }

        private void EditOrderButt_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
            string OrderID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            Order O = Program.seekOrder(int.Parse(OrderID));
            if (O.getOrderStatus().ToString() == "draft")
            {
                GenerateOrder gO = new GenerateOrder( this.agentName, this.agentMail, this.agentId,O.getOrderId());
                gO.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Can not edit a non draft order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
