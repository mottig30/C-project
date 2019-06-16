using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JavierS
{
    class Customer
    {
        //fildes of the class:

        private string fName;
        private string lName;
        private string phone;
        private string email;
        private string addressCountry;
        private string addressCity;
        private string addressStreet;
        private int addressZip;
        private EnumCustomerType customerType;
        public System.Collections.Generic.List<Order> orderCustomer;

        public Customer(string email, string fName, string lName, string phone, string addressCountry, string addressCity, string addressStreet, int addressZip, EnumCustomerType customerType, bool is_new)
        {
            this.email = email;
            this.fName = fName;
            this.lName = lName;
            this.phone = phone;
            this.addressCountry = addressCountry;
            this.addressCity = addressCity;
            this.addressStreet = addressStreet;
            this.addressZip = addressZip;
            this.customerType = customerType;
            orderCustomer = new System.Collections.Generic.List<Order>();
            if (is_new)//if false, the order is in the DB
            {
                this.create_Customer();
                Program.Customers.Add(this);

            }
        }

        //getters

        public void create_Customer()
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "EXECUTE SP_add_customer @email, @fName, @lName, @phone, @addressCountry, @addressCity, @addressStreet, @addressZip, @customerType ";
            c1.Parameters.AddWithValue("@email", this.email);
            c1.Parameters.AddWithValue("@fName", this.fName);
            c1.Parameters.AddWithValue("@lName", this.lName);
            c1.Parameters.AddWithValue("@phone", this.phone);
            c1.Parameters.AddWithValue("@addressCountry", this.addressCountry);
            c1.Parameters.AddWithValue("@addressCity", this.addressCity);
            c1.Parameters.AddWithValue("@addressStreet", this.addressStreet);
            c1.Parameters.AddWithValue("@addressZip", this.addressZip);
            c1.Parameters.AddWithValue("@customerType", this.customerType.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c1);
        }
        public string getfName()
        {
            return this.fName;
        }

        public string GetPhone()
        {
            return this.phone;
        }

        public string getEmail()
        {

            return this.email;
        }

        public string getAddressCountry()
        {
            return this.addressCountry;
        }

        public string getAddressCity()
        {
            return this.addressCity;
        }

        public string getAddressStreet()
        {
            return this.addressStreet;
        }

        public int getAddressZip()
        {
            return this.addressZip;

        }
        public string getFullName()
        {
            return (this.fName + " " + this.lName);

        }
    }
}
