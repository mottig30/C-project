using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierS
{
    class Supplier
    {
        private String name;
        private String addressCountry;
        private String addressCity;
        private String addressStreet;
        private int addressZipCod;
        private String email;
        private String phone;
        public System.Collections.Generic.List<Model> modelList;

        public Supplier(string name, string addressCountry, string addressCity, string addressStreet, int addressZipCod, string email, string phone) //constructor
        {
            this.name = name;
            this.addressCountry = addressCountry;
            this.addressCity = addressCity;
            this.addressStreet = addressStreet;
            this.addressZipCod = addressZipCod;
            this.email = email;
            this.phone = phone;
            this.modelList = new System.Collections.Generic.List<Model>();
        }

        public string getName()
        {
            return this.name;
        }

        public string getEmail()
        {
            return this.email;
        }
    }
}
