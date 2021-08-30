using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    public class Customer : User
    {
        // Attr In Customer Class
        static int counter;
        private int id;
        private string address;
        private Dictionary<int, Order> dicOfOrder = new Dictionary<int, Order>();

        // Methods In Customer Class

        // Constructor
        public Customer()
        {
            id = ++counter;
        }

        public Customer(string address)
        {
            id = ++counter;
            this.address = address;
        }

        // Setter Methods In Customer Class
        public void setAddress(string address)
        {
            this.address = address;
        }

        // Getter Methods In Customer Class
        public int getCounter()
        {
            return counter;
        }

        public int getId()
        {
            return id;
        }

        public string getAddress()
        {
            return address;
        }

        // Custom Methods In Customer Class
        public void addOrder(Order newOrder)
        {
            dicOfOrder.Add(newOrder.getId(), newOrder);
        }

        public void cancelOrder(int id)
        {
            try
            {
                if (dicOfOrder.ContainsKey(id))
                    dicOfOrder.Remove(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
