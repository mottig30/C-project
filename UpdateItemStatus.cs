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
    public partial class UpdateItemStatus : Form
    {

        DataTable dt1 = new DataTable();
        string orderID;
        private string agentName;
        private string agentMail;
        private string agentId;
        public UpdateItemStatus(string orderID, string agentName, string agentMail, string agentId)
        {
            InitializeComponent();
            this.orderID = orderID;
            OrderIDLable.Text = orderID;
            CustomerLable.Text = Program.seekOrder(int.Parse(orderID)).getCustomer().getFullName();
            GridView_Load();
            Init_GridView();
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            AgentNameLabel.Text = "Hello" + " " + this.agentName;
        }


        private void Init_GridView()
        {
            Order O = Program.seekOrder(int.Parse(orderID));
            foreach (ItemInOrder IO in O.itemsInOrderList)
            {
                dt1.Rows.Add(IO.getItem().getModel().getID().ToString(), IO.getItem().getItemId().ToString(),IO.getStatus(), IO.getItem().getItemSize().ToString(), IO.getItem().getItemColore().ToString(), IO.getQuantity(), IO.getquantityDefective());
            }
            dataGridView1.DataSource = dt1;
        }

        private void GridView_Load()
        {
            dt1.Columns.AddRange(new DataColumn[7] { new DataColumn("Model ID", typeof(string)), new DataColumn("Item ID", typeof(string)),new DataColumn("Status", typeof(string)),new DataColumn("Size", typeof(string)),
            new DataColumn("Color", typeof(string)),new DataColumn("Quantity", typeof(string)),new DataColumn("Defective Quantity", typeof(string))});
            this.dataGridView1.DataSource = dt1;


        }
        private void TitelOrderID_Click(object sender, EventArgs e)
        {

        }

        private void TitelCustomer_Click(object sender, EventArgs e)
        {

        }

        private void UpdateItemStatus_Load(object sender, EventArgs e)
        {

        }

        private void OrderIDLable_Click(object sender, EventArgs e)
        {

        }

        private void CustomerLable_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Arrivedbutton1_Click(object sender, EventArgs e)
        {
            if (dt1.Rows.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
                newDataRow.Cells[2].Value = "arrived";
                string ItemID = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                Order O = Program.seekOrder(int.Parse(orderID));
                ItemInOrder IO = O.seekItemInOrder(int.Parse(ItemID));
                IO.UpdateItemInOrderStatus("arrived");
            }

        }

        private void NotArrivedbutton2_Click(object sender, EventArgs e)
        {
            if (dt1.Rows.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
                newDataRow.Cells[2].Value = "Not Arrived";
                string ItemID = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                Order O = Program.seekOrder(int.Parse(orderID));
                ItemInOrder IO = O.seekItemInOrder(int.Parse(ItemID));
                IO.UpdateItemInOrderStatus("notArrived");
            }
        }

        private void Canceledbutton3_Click(object sender, EventArgs e)
        {
            if (dt1.Rows.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
                newDataRow.Cells[2].Value = "Canceled";
                string ItemID = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                Order O = Program.seekOrder(int.Parse(orderID));
                ItemInOrder IO = O.seekItemInOrder(int.Parse(ItemID));
                IO.UpdateItemInOrderStatus("canceled");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {          
                if (dt1.Rows.Count > 0)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow newDataRow = dataGridView1.Rows[rowIndex];
                if (newDataRow.Cells[2].Value.ToString() == "arrived")
                {
                    newDataRow.Cells[6].Value = numericUpDown1.Text;
                    string ItemID = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                    Order O = Program.seekOrder(int.Parse(orderID));
                    ItemInOrder IO = O.seekItemInOrder(int.Parse(ItemID));
                    IO.UpdateItemInOrderDefective(int.Parse(numericUpDown1.Text));
                }else
                    MessageBox.Show("Can not update Defective items if the order status is not 'arrived'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FinishBott_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Order O = Program.seekOrder(int.Parse(this.orderID));
            if (MessageBox.Show("Finish editing?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach(ItemInOrder IO in O.itemsInOrderList)
                {
                    if (!IO.getStatus().Equals("arrived"))
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    O.UpdateOrderStatus("arrived");
                    MessageBox.Show("Order status has Changed to Arrived", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MyOrders mO = new MyOrders(this.agentName, this.agentMail, this.agentId);
                mO.Show();
                this.Hide();
            }
        }

        private void AgentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            MyOrders Mo = new MyOrders(this.agentName, this.agentMail, this.agentId);
            Mo.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
