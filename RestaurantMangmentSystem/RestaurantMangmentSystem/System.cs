using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    [Serializable]
    class System
    {
        // Attr In System Class
        private Dictionary<int, Offer> dicOfOffer = new Dictionary<int, Offer>();
        private Dictionary<int, Employee> dicOfEmployee = new Dictionary<int, Employee>();
        private Dictionary<int, Customer> dicOfCustomer = new Dictionary<int, Customer>();
        private Dictionary<string, Dictionary<int, Product> > dicOfProduct = new Dictionary<string, Dictionary<int, Product> >();

        // Custom Methods Of System Class
        public bool LogIn(string userName, string password)
        {
            foreach(KeyValuePair<int, Customer> customer in dicOfCustomer)
            {
                if (customer.Value.getPassword() == password && customer.Value.getName() == userName)
                    return true;
            }
            return false;
        }

        public void LogOut()
        {
           // Develop In GUI
        }

        public void register(Customer newCustomer)
        {
            dicOfCustomer.Add(newCustomer.getId(), newCustomer);
        }

        public void deleteCustomer(int id)
        {
            dicOfCustomer.Remove(id);
        }

        public void addProduct(Product newProduct)
        {
            if (dicOfProduct.ContainsKey(newProduct.getCategory()))
            {
                dicOfProduct[newProduct.getCategory()].Add(newProduct.getId(), newProduct);
            }
            else
            {
                Dictionary<int, Product> dicTemp = new Dictionary<int, Product>();
                dicTemp.Add(newProduct.getId(), newProduct);
                dicOfProduct.Add(newProduct.getCategory(), dicTemp);
            }
        }

        public void deleteProduct(int id)
        {
            foreach(KeyValuePair<string, Dictionary<int, Product> > product in dicOfProduct)
            {
                if(product.Value.ContainsKey(id))
                {
                    product.Value.Remove(id);
                }
            }
        }

        public void addEmployee(Employee newEmployee)
        {
            dicOfEmployee.Add(newEmployee.getId(), newEmployee);
        }

        public void deleteEmployee(int id)
        {
            dicOfEmployee.Remove(id);
        }

        public void addOffer(Offer newOffer)
        {
            dicOfOffer.Add(newOffer.getId(), newOffer);
        }

        public void deleteOffer(int id)
        {
            dicOfOffer.Remove(id);
        }

        public void employment(Order newOrder)
        {
            foreach(KeyValuePair<int, Employee> employee in dicOfEmployee)
            {
                if(employee.Value.getAvailability())
                {
                    employee.Value.addOrder(newOrder);
                }
            }
        }

    }
}
