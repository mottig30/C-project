using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JavierS
{
    class Order
    {
        public static int OrderSerialNum = 1000;
        //private int OrderSerial
        private int orderID;
        private DateTime dateOfOrder;
        private DateTime dateOfArrived;
        private float totalPrice;
        private EnumOrderStatus orderStatus;
        private Customer C;
        private Shipment S;
        private Worker W;
        public System.Collections.Generic.List<ItemInOrder> itemsInOrderList;

        public Order(int orderID, DateTime dateOfOrder, DateTime dateOfArrived, EnumOrderStatus orderStatus, Customer C, Shipment S, Worker W, bool is_new)
        {
            this.orderID = orderID;
            this.dateOfOrder = dateOfOrder;
            this.dateOfArrived = dateOfArrived;
            this.totalPrice = 0;
            this.orderStatus = orderStatus;
            this.C = C;
            this.S = S;
            this.W = W;
            this.itemsInOrderList = new System.Collections.Generic.List<ItemInOrder>();
            if (is_new)//if false, the order is in the DB
            {
                this.create_Order();
                Program.Orders.Add(this);
                C.orderCustomer.Add(this);
                S.shipmentOrders.Add(this);
                W.agentOrders.Add(this);
            }
        }
        public Order(Customer C, Worker W, bool is_new)
        {

            this.orderID = Program.Orders.Last().orderID + 1;
            this.dateOfOrder = DateTime.Now;
            this.dateOfArrived = DateTime.Now;
            this.totalPrice = 0;
            this.C = C;
            this.S = Program.seekShipment(1);
            this.W = W;
            this.orderStatus = (EnumOrderStatus)Enum.Parse(typeof(EnumOrderStatus), "draft");
            this.itemsInOrderList = new System.Collections.Generic.List<ItemInOrder>();
            if (is_new)//if false, the order is in the DB
            {
                this.create_Order();
                Program.Orders.Add(this);
                C.orderCustomer.Add(this);
                S.shipmentOrders.Add(this);
                W.agentOrders.Add(this);
            }
        }
        public void create_Order()
        {

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_add_order @id, @dateOfOrder, @dateOfArrived, @orderStatus, @Customer, @Shipment, @Worker";
            c1.Parameters.AddWithValue("@id", this.orderID);
            c1.Parameters.AddWithValue("@dateOfOrder", this.dateOfOrder);
            c1.Parameters.AddWithValue("@dateOfArrived", this.dateOfArrived);
            c1.Parameters.AddWithValue("@orderStatus", this.orderStatus.ToString());
            c1.Parameters.AddWithValue("@Customer", this.C.getEmail());
            c1.Parameters.AddWithValue("@Shipment", this.S.getShipmentID());
            c1.Parameters.AddWithValue("@Worker", this.W.getWorkerID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }

        public int getOrderId()
        {
            return this.orderID;
        }

        public DateTime getDateOfOrder()
        {
            return this.dateOfOrder;
        }

        public EnumOrderStatus getOrderStatus()
        {
            return this.orderStatus;
        }

        public Customer getCustomer()
        {
            return this.C;
        }

        public Supplier getSupplier()
        {
            if (this.itemsInOrderList.Count > 0)
                return this.itemsInOrderList.ElementAt(0).getItem().getModel().getSupplier();
            else
                return null;
        }
        public ItemInOrder seekItemInOrder(int ItemID)
        {
            foreach (ItemInOrder IO in this.itemsInOrderList)
            {
                if (IO.getItem().getItemId() == ItemID)
                    return IO;
            }
            return null;
        }

        public void UpdateOrderStatus(string status)
        {
            this.orderStatus = (EnumOrderStatus)Enum.Parse(typeof(EnumOrderStatus), status);
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_Update_orderStatus @orderID , @status";
            c1.Parameters.AddWithValue("@orderID", this.orderID);
            c1.Parameters.AddWithValue("@status", status);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }



    }
}

