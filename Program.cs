using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace JavierS
{
   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>       
        public static System.Collections.Generic.List<Worker> Workers;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Model> Models;
        public static System.Collections.Generic.List<Item> Items;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<Shipment> Shipments;
        public static System.Collections.Generic.List<Customer> Customers;
        [STAThread]
        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_workers();//אתחול הרשימה של העובדים
            init_customers();//אתחול הרשימה של לקוחות
            init_shipments();//אתחול הרשימה של משלוחים
            init_suppliers();//אתחול הרשימה של ספקים
            init_models();//אתחול הרשימה של דגמים
            init_items();//אתחול הרשימה של פריטים
            init_orders();//אתחול הרשימה של ההזמנות 
            init_itemInOrder(); // 

        }

        public static Supplier seekSupplier(string name)
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.getName() == name)
                    return s;
            }
            return null;
        }

        public static Model seekModel(int id)
        {
            foreach (Model m in Models)
            {
                if (m.getID() == id)
                    return m;
            }
            return null;
        }

        public static Customer seekCustomer(string email)
        {
            foreach (Customer c in Customers)
            {
                if (c.getEmail() == email)
                    return c;
            }
            return null;
        }

        public static Worker seekWorker(string id)
        {
            foreach (Worker w in Workers)
            {
                if (w.getWorkerID() == id)
                    return w;
            }
            return null;
        }

        public static Shipment seekShipment(int id)
        {
            foreach (Shipment s in Shipments)
            {
                if (s.getShipmentID() == id)
                    return s;
            }
            return null;
        }

        public static Order seekOrder(int id)
        {
            foreach (Order o in Orders)
            {
                if (o.getOrderId() == id)
                    return o;
            }
            return null;
        }

        public static Item seekItem(int id)
        {
            foreach (Item i in Items)
            {
                if (i.getItemId() == id)
                    return i;
            }
            return null;
        }



        public static void init_workers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Workers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Workers = new List<Worker>();

            while (rdr.Read())
            {
                EnumWorkerType T = (EnumWorkerType)Enum.Parse(typeof(EnumWorkerType), rdr.GetValue(5).ToString());
                Worker w = new Worker(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), DateTime.Parse(rdr.GetValue(4).ToString()), T);
                Workers.Add(w);
            }
        }

        public static void init_customers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Customer";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Customers = new List<Customer>();

            while (rdr.Read())
            {
                EnumCustomerType T = (EnumCustomerType)Enum.Parse(typeof(EnumCustomerType), rdr.GetValue(8).ToString());
                Customer CU = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), int.Parse(rdr.GetValue(7).ToString()), T, false);
                Customers.Add(CU);
            }
        }

        public static void init_shipments()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_shippments";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Shipments = new List<Shipment>();

            while (rdr.Read())
            {

                Shipment S = new Shipment(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), float.Parse(rdr.GetValue(2).ToString()), float.Parse(rdr.GetValue(3).ToString()),false);
                Shipments.Add(S);
            }
        }

        public static void init_suppliers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Suppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Supplier s = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), int.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString());
                Suppliers.Add(s);
            }
        }

        public static void init_models()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Models";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Models = new List<Model>();

            while (rdr.Read())
            {
                Supplier S = seekSupplier(rdr.GetValue(3).ToString());
                EnumModelType T = (EnumModelType)Enum.Parse(typeof(EnumModelType), rdr.GetValue(1).ToString());
                Model m = new Model(int.Parse(rdr.GetValue(0).ToString()), T, float.Parse(rdr.GetValue(2).ToString()), S);
                S.modelList.Add(m);
                Models.Add(m);
            }
        }

        public static void init_items()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Items";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Items = new List<Item>();

            while (rdr.Read())
            {
                Model M = seekModel(int.Parse(rdr.GetValue(1).ToString()));
                EnumSize T1 = (EnumSize)Enum.Parse(typeof(EnumSize), rdr.GetValue(2).ToString());
                EnumColor T2 = (EnumColor)Enum.Parse(typeof(EnumColor), rdr.GetValue(3).ToString());
                Item I = new Item(int.Parse(rdr.GetValue(0).ToString()),M, T1, T2);
                M.itemsList.Add(I);
                Items.Add(I);
            }
        }


        public static void init_orders()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Orders = new List<Order>();

            while (rdr.Read())
            {
                Customer C = seekCustomer(rdr.GetValue(4).ToString());
                Shipment S = seekShipment(int.Parse(rdr.GetValue(5).ToString()));
                Worker W = seekWorker(rdr.GetValue(6).ToString());
                EnumOrderStatus T = (EnumOrderStatus)Enum.Parse(typeof(EnumOrderStatus), rdr.GetValue(3).ToString());
                Order o = new Order(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), T, C, S, W,false);
                C.orderCustomer.Add(o);
                W.agentOrders.Add(o);
                S.shipmentOrders.Add(o);
                Orders.Add(o);
            }
        }

        public static void init_itemInOrder()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ItemInOrder";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Order o = seekOrder(int.Parse(rdr.GetValue(0).ToString()));
                Item i = seekItem(int.Parse(rdr.GetValue(1).ToString()));
                EnumItemStatus T = (EnumItemStatus)Enum.Parse(typeof(EnumItemStatus), rdr.GetValue(4).ToString());
                ItemInOrder iio = new ItemInOrder(o, i, int.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()),T,false);
                o.itemsInOrderList.Add(iio);
                i.itemsInOrderList.Add(iio);
            }
        }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
           Application.Run(new LogInScreen());
        }
    }
}                                                                                                                                                                                                                                                                                                                                       
