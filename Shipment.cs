using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JavierS
{
    class Shipment
    {
        private int shipmentID;
        private float price;
        private float weight;
        private DateTime sendingDate;
        public System.Collections.Generic.List<Order> shipmentOrders;

        public Shipment(int shipmentID, DateTime sendingDate, float price, float weight,bool is_new) //constructor
        {
            this.shipmentID = shipmentID;
            this.price = price;
            this.weight = weight;
            this.sendingDate = sendingDate;
            this.shipmentOrders = new System.Collections.Generic.List<Order>();
            if (is_new)
            {
                this.create_shipment();
                Program.Shipments.Add(this);
            }
        }

        public void create_shipment()
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_add_shipment @shipmentID,@sendingDate, @price, @weight";
            c1.Parameters.AddWithValue("@shipmentID", this.shipmentID);
            c1.Parameters.AddWithValue("@sendingDate", this.sendingDate);
            c1.Parameters.AddWithValue("@price", this.price);
            c1.Parameters.AddWithValue("@weight", this.weight);
     
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }


    


        public DateTime getSendingDate()
        {
            return this.sendingDate;
        }

        public int getShipmentID()
        {
            return this.shipmentID;
        }

        public float getPrice()
        {
            return this.price;
        }

    }
}
