using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavierS
{
    class Worker
    {
        //Fields of the class:

        private string workerID;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDate;
        private EnumWorkerType workerType;
        public System.Collections.Generic.List<Order> agentOrders;


        public Worker(string workerID, string firstName, string lastName, string email, DateTime birthDate, EnumWorkerType workerType)
        {
            this.workerID = workerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDate = birthDate;
            this.workerType = workerType;
            this.agentOrders = new System.Collections.Generic.List<Order>();
        }

        //getters:

        public string getWorkerID()
        {
            return this.workerID;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public string getEmail()
        {
            return this.email;
        }

        public DateTime getBirthDate()
        {
            return this.birthDate;
        }

        public EnumWorkerType getWorkerType()
        {
            return this.workerType;
        }

        public float sumOrdersPerMonth(int year, int month) // מחזיר את סך ההזמנה פר חודש
        {
            float sum = 0;
            foreach (Order o in this.agentOrders)
            {
                if ((int.Parse(o.getDateOfOrder().Month.ToString()) == month) && (int.Parse(o.getDateOfOrder().Year.ToString()) == year))
                {
                    sum = sum + totalOrderPrice(o);
                }
            }
            return sum;
        }


        public float totalOrderPrice(Order O) // מחשב סכום כולל להזמנה
        {
            float total = 0;
            foreach (ItemInOrder IO in O.itemsInOrderList)
            {
                Item i = IO.getItem();
                Model m = i.getModel();
                total = total + m.getPrice();
            }
            return total;
        }

        public int ordersPerMonth(int year, int month) // מחזיר את מספר ההזמנות של הלקוח בחודש והשנה הרלוונטיים
        {
            int counter = 0;
            foreach (Order o in this.agentOrders)
            {
                if ((int.Parse(o.getDateOfOrder().Month.ToString()) == month) && (int.Parse(o.getDateOfOrder().Year.ToString()) == year))
                {
                    counter = counter + 1;
                }
            }
            return counter;
        }

    }
}
