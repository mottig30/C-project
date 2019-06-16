using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JavierS
{
    class ItemInOrder
    {
        private int quantityInOrder;
        private int quantityDefective;
        private EnumItemStatus EnumItemStatus;
        Item item;
        Order order;




        public ItemInOrder(Order Order, Item Items, int quantityInOrder, int quantityDefective, EnumItemStatus enumItemStatus, bool is_new)
        {
            this.quantityInOrder = quantityInOrder;
            this.item = Items;
            this.order = Order;
            this.quantityDefective = quantityDefective;
            this.EnumItemStatus = enumItemStatus;
            if (is_new)
            {
                this.item.itemsInOrderList.Add(this);
                this.order.itemsInOrderList.Add(this);
                this.create_ItemInOrder();
            }

        }
        public void create_ItemInOrder()
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_add_ItemInOrder @Order, @Items, @quantityInOrder, @quantityDefective, @enumItemStatus";
            c1.Parameters.AddWithValue("@Order", this.order.getOrderId());
            c1.Parameters.AddWithValue("@Items", this.item.getItemId());
            c1.Parameters.AddWithValue("@quantityInOrder", this.quantityInOrder);
            c1.Parameters.AddWithValue("@quantityDefective", this.quantityDefective);
            c1.Parameters.AddWithValue("@enumItemStatus", this.EnumItemStatus.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }

        public Item getItem()
        {
            return this.item;
        }

        public string getQuantity()
        {
            return this.quantityInOrder.ToString();
        }

        public void removeItemFromOrder()
        {
            this.order.itemsInOrderList.Remove(this);
            this.item.itemsInOrderList.Remove(this);
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_delete_itemInOrder @OrderID, @ItemID";
            c1.Parameters.AddWithValue("@OrderID", this.order.getOrderId());
            c1.Parameters.AddWithValue("@ItemID", this.item.getItemId());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }

        public void UpdateItemInOrderStatus(string status)
        {
            this.EnumItemStatus = (EnumItemStatus)Enum.Parse(typeof(EnumItemStatus), status);
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_Update_itemStatus @orderID , @itemID , @status ";
            c1.Parameters.AddWithValue("@orderID", this.order.getOrderId());
            c1.Parameters.AddWithValue("@itemID", this.item.getItemId());
            c1.Parameters.AddWithValue("@status", status);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }

        public void UpdateItemInOrderDefective(int numOfDefective)
        {
            this.quantityDefective = numOfDefective;
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_Update_quantityDefective @orderID , @itemID , @numOfDefective ";
            c1.Parameters.AddWithValue("@orderID", this.order.getOrderId());
            c1.Parameters.AddWithValue("@itemID", this.item.getItemId());
            c1.Parameters.AddWithValue("@numOfDefective", numOfDefective);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }

        public string getquantityDefective()
        {
            return this.quantityDefective.ToString();
        }

        public string getStatus()
        {
            return this.EnumItemStatus.ToString();
        }

    }
}