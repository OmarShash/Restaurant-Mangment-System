using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    public class Employee : User
    {
        // Attr In Employee Class
        static int counter;
        private int id;
        private int workingHour;
        private bool availability;
        private Dictionary<int, Order> dicOfOrder = new Dictionary<int, Order>(); // Initialization in Constructor Not here
        
        // Methods In Employee Class

        // Counstructor
        public Employee()
        {
            id = ++counter;
            availability = true;
        }

        public Employee(int workingHour, bool availability)
        {
            id = ++counter;
            this.availability = availability;
        }

        // Setter Methods In Employee Class
        public void setWorkingHour(int workingHour)
        {
            this.workingHour = workingHour;
        }

        public void setAvailability(bool availability)
        {
            this.availability = availability;
        }

        // Getter Methods In Employee Class
        public int getCounter()
        {
            return counter;
        }

        public int getId()
        {
            return id;
        }

        public int getWorkingHour()
        {
            return workingHour;
        }

        public bool getAvailability()
        {
            return availability;
        }

        public Order getOrder(int id)
        {
            if (dicOfOrder.ContainsKey(id))
            {
                Order o = new Order();
                o = dicOfOrder[id];
                return o;
            }
            else
                return null;
        }

        // Custom Methods In Employee Class
        public void addOrder(Order newOrder)
        {
            if (dicOfOrder.Count() < 2)
                dicOfOrder.Add(newOrder.getId(), newOrder);
            if (dicOfOrder.Count() == 2)
                availability = false;
        }
    }
}
