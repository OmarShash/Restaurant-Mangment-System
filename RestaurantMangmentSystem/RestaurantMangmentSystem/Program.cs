using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Our Restaurant" + "\n");
            // Products
            Product p1 = new Product("Caffe", "Drinks", 4.4f, 5.2f, "Photo1", 5);
            Product p2 = new Product("tea", "Drinks", 3.2f, 3.0f, "Photo2", 150);
            Product p3 = new Product("pepsi", "Drinks", 4.5f, 8.0f, "Photo3", 90);

            Product p4 = new Product("meat", "Dinner", 3.9f, 59.5f, "Photo4", 90);
            Product p5 = new Product("Rice", "Dinner", 4.1f, 40.5f, "Photo5", 90);
            
            // Offers
            Offer of = new Offer(30, 7, "Admin", "Thanks");
            of.addProduct(p4);
            of.addProduct(p5);
            //of.showOffer();

            // Orders
            Order or = new Order();
            or.addOffer(of);
            or.addProduct(p3);
            or.deleteProduct(p3.getId());
            or.PlaceOrder();
            or.showOrder();

            Order or2 = new Order();
            or2.addOffer(of);
            or2.addProduct(p3);
            or2.deleteProduct(p3.getId());
            or2.PlaceOrder();
            or2.showOrder();

            Order or3 = new Order();
            or3.addOffer(of);
            or3.addProduct(p3);
            or3.deleteProduct(p3.getId());
            or3.PlaceOrder();
            or3.showOrder();

            // Customer
            Customer c = new Customer();

            // Employee
            Employee e = new Employee();
            e.addOrder(or);
            e.addOrder(or2);
            e.addOrder(or3);

            Console.WriteLine((e.getOrder(or.getId())));
            Console.WriteLine(e.getOrder(or2.getId()));
            Console.WriteLine(e.getOrder(or3.getId())); // Not Print AnyThing
            
        }
    }
}
