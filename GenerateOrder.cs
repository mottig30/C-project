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
    public partial class GenerateOrder : Form
    {
        public string agentName;
        public string agentMail;
        public string agentId;
        DataTable dt1 = new DataTable();
        Order O;
        string supplierName = "defult";
        bool flagEditingEx = false;
        public GenerateOrder(string agentName, string agentMail, string agentId)
        {
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            InitializeComponent();
            agentNameLabel.Text = "Hello" + " " + this.agentName;
            Fill_Customer_box();
            Fill_Supplier_box();
            GenerateOrder_Load();
            QuantityUpDown1.Minimum = 1;
        }

        public GenerateOrder(string agentName, string agentMail, string agentId, int OrderID)
        {
            this.agentName = agentName;
            this.agentMail = agentMail;
            this.agentId = agentId;
            this.flagEditingEx = true;
            InitializeComponent();
            agentNameLabel.Text = "Hello" + " " + this.agentName;
            this.O = Program.seekOrder(OrderID);
            CustomerComboBox1.Text = O.getCustomer().getEmail();
            FullNameLabel.Text = O.getCustomer().getFullName().ToString();
            SupllierComboBox2.Text = O.getSupplier().getName();
            this.supplierName = SupllierComboBox2.Text;
            Fill_Model_box(SupllierComboBox2.Text);
            GenerateOrder_Load();
            QuantityUpDown1.Minimum = 1;
            foreach(ItemInOrder IO in O.itemsInOrderList)
            {
                dt1.Rows.Add(O.getSupplier().getName(),IO.getItem().getModel().getID().ToString(), IO.getItem().getItemId().ToString(),
                    IO.getItem().getItemColore().ToString(), IO.getItem().getItemSize().ToString(), IO.getQuantity());
            }
        }

        public void Fill_Supplier_box()
        {

            List<string> suppliersList = new List<string>();

            foreach (Supplier S in Program.Suppliers)
            {
                suppliersList.Add(S.getName());
            }
            SupllierComboBox2.DataSource = suppliersList;
        }

        public void Fill_Item_box(string modelID)
        {

            List<int> itemList = new List<int>();
            Model M = Program.seekModel(int.Parse(modelID));
            foreach (Item I in M.itemsList)
            {
                itemList.Add(I.getItemId());
            }
            ItemComboBox.DataSource = itemList;
        }


        public void Fill_Model_box(string supplierName)
        {

            List<int> modelsList1 = new List<int>();
            Supplier s = Program.seekSupplier(supplierName);
            foreach (Model m in s.modelList)
            {
                modelsList1.Add(m.getID());
            }
            ModelComboBox1.DataSource = modelsList1;
        }
        public void Fill_Customer_box()
        {

            List<string> names = new List<string>();

            foreach (Customer C in Program.Customers)
            {
                names.Add(C.getEmail());
            }
            CustomerComboBox1.DataSource = names;
        }



        private void ModelComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = ModelComboBox1.SelectedItem.ToString();
            Fill_Item_box(click);
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = ItemComboBox.SelectedItem.ToString();
            Item I = Program.seekItem(int.Parse(click));
            ColorChangelabel1.Text = I.getItemColore().ToString();
            SizeChangelabel2.Text = I.getItemSize().ToString();
        }

        private void ColorChangelabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void SizeChangelabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerateOrder_Load()
        {
            dt1.Columns.AddRange(new DataColumn[6] { new DataColumn("Supplier", typeof(string)), new DataColumn("Model", typeof(string)),new DataColumn("Item ID", typeof(string)),
            new DataColumn("Color", typeof(string)),new DataColumn("Size", typeof(string)),new DataColumn("Quantity", typeof(string)) });
            this.dataGridView1.DataSource = dt1;
        }


        private void QuantityUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = CustomerComboBox1.SelectedItem.ToString();
            Customer C = Program.seekCustomer(click);
            FullNameLabel.Text = C.getFullName().ToString();
            List<string> oneCustomerList = new List<string>();
            oneCustomerList.Add(click);
            CustomerComboBox1.DataSource = oneCustomerList;


        }

        private void FullNameLabel_Click(object sender, EventArgs e)
        {

        }


        private void SupllierComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string click = SupllierComboBox2.SelectedItem.ToString();
            Fill_Model_box(click);
        }

        private void AddItembutton1_Click_1(object sender, EventArgs e)
        {           
            if (dt1.Rows.Count == 0)
            {
                O = new Order(Program.seekCustomer(CustomerComboBox1.Text), Program.seekWorker(this.agentId), true);
                supplierName = SupllierComboBox2.Text;
                dt1.Rows.Add(supplierName, ModelComboBox1.Text, ItemComboBox.Text, ColorChangelabel1.Text, SizeChangelabel2.Text, QuantityUpDown1.Text);
                ItemInOrder IT = new ItemInOrder(O, Program.seekItem(int.Parse(ItemComboBox.Text)), int.Parse(QuantityUpDown1.Text), 0, (EnumItemStatus)Enum.Parse(typeof(EnumItemStatus), "notArrived"), true);
            }else
            {
                if(SupllierComboBox2.Text == supplierName)
                {
                    bool flag = false;
                    foreach (ItemInOrder I in O.itemsInOrderList)
                    {
                        if (int.Parse(ItemComboBox.Text) == I.getItem().getItemId())
                        {
                            MessageBox.Show("Item already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            flag = true;
                        }                                                
                    }
                    if (flag == false)
                    {
                        dt1.Rows.Add(supplierName, ModelComboBox1.Text, ItemComboBox.Text, ColorChangelabel1.Text, SizeChangelabel2.Text, QuantityUpDown1.Text);
                        ItemInOrder IT = new ItemInOrder(O, Program.seekItem(int.Parse(ItemComboBox.Text)), int.Parse(QuantityUpDown1.Text), 0, (EnumItemStatus)Enum.Parse(typeof(EnumItemStatus), "notArrived"), true);
                    }
                }
                else
                {
                    MessageBox.Show("Can not change supplir during order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void ChangeCustomerB_Click(object sender, EventArgs e)
        {
            if (flagEditingEx == false)
            {
                if (dt1.Rows.Count != 0)
                {
                    if (MessageBox.Show("The order in editing, would you like ro change customer?", "Order edit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        dt1.Rows.Clear();
                        Fill_Customer_box();
                    }
                }
                else
                {
                    Fill_Customer_box();
                }
            }
            else
            {
                MessageBox.Show("Can not change customer while editing order");
            }
        }

        private void SendOrderB_Click(object sender, EventArgs e)//sending the order to the supplier mail
        {
            bool orderEmpty = true;
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Can not save an empty order");
                orderEmpty = false;
            }
            if (orderEmpty == true)
            {
                Supplier s = Program.seekSupplier(supplierName);
                yourOrdersButton c = new yourOrdersButton(this.O.getOrderId(), s.getEmail(), this.agentName, this.agentMail, this.agentId);
                c.Show();
                this.Hide();
            }
        }

        private void DeleteRButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string itemID = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            ItemInOrder IO = O.seekItemInOrder(int.Parse(itemID));
            IO.removeItemFromOrder();
            dataGridView1.Rows.RemoveAt(rowIndex);
            if (dataGridView1.Rows.Count == 0)
            {
                this.O.UpdateOrderStatus("draft");
            }

        }

        private void GenerateOrder_Load(object sender, EventArgs e)
        {

        }

        private void Customerlibel_Click(object sender, EventArgs e)
        {

        }

        private void quantitylabel1_Click(object sender, EventArgs e)
        {

        }

        private void sizelabel1_Click(object sender, EventArgs e)
        {

        }

        private void Colorlabel1_Click(object sender, EventArgs e)
        {

        }

        private void Itemlabel1_Click(object sender, EventArgs e)
        {

        }

        private void Modellabel1_Click(object sender, EventArgs e)
        {

        }

        private void Supplierlabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("Order saved as Draft","Notice");
            }
            MainMenu mMS = new MainMenu(this.agentName, this.agentMail, this.agentId);
            mMS.Show();
            this.Hide();
        }

        private void agentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen lIS = new LogInScreen();
            lIS.Show();
            this.Hide();
        }

        private void createCustomerButt_Click(object sender, EventArgs e)
        {
            CreateNewCustomerScreen cNCS = new CreateNewCustomerScreen(this.agentName, this.agentMail, this.agentId, false);
            cNCS.Show();
            this.Hide();
        }
    }
}
