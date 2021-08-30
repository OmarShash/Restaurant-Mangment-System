using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    public class Offer
    {
        // Attr In Offer Class
        static int counter;
        private int id;
        private int discountPrecentage;
        private DateTime releaseDate;
        private DateTime expireDate;
        private string mangerName;
        private string message;
        private float price;
        private Dictionary<int, Product> dicOfProduct = new Dictionary<int, Product>();

        // Methods In Offer Class

        // Constructors
        public Offer()
        {
            id = ++counter;
            releaseDate = DateTime.Now;
            expireDate = releaseDate.AddDays(1);
        }

        public Offer(int discountPrecentage, int expireDate, string mangerName, string message)
        {
            id = ++counter;
            this.discountPrecentage = discountPrecentage;
            releaseDate = DateTime.Now;
            this.expireDate = releaseDate.AddDays(expireDate);
            this.mangerName = mangerName;
            this.message = message;
        }

        // Setter Methods
        public void setDiscountPrecentage(int discountPrecentage)
        {
            this.discountPrecentage = discountPrecentage;
        }

        public void setReleaseDate(DateTime releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public void setExpireDate(int expireDate)
        {
            this.expireDate = releaseDate.AddDays(expireDate);
        }

        public void setMangerName(string mangerName)
        {
            this.mangerName = mangerName;
        }

        public void setMessage(string message)
        {
            this.message = message;
        }

        // Getter Methods
        public int getCounter()
        {
            return counter;
        }
        public int getId()
        {
            return id;
        }

        public int getDiscountPrecentage()
        {
            return discountPrecentage;
        }

        public DateTime getReleaseDate()
        {
            return releaseDate;
        }

        public DateTime getExpireDate()
        {
            return expireDate;
        }

        public string getMangerName()
        {
            return mangerName;
        }

        public string getMessage()
        {
            return message;
        }

        // Custom Methods
        public void addProduct(Product newProduct)
        {
            dicOfProduct.Add(newProduct.getId(), newProduct);
        }

        public float getPriceOffer()
        {
            foreach(KeyValuePair<int, Product> product in dicOfProduct)
                this.price += product.Value.getPrice();
            return price - (price * (discountPrecentage / 100f));
        }

        public void showOffer()
        {
            Console.WriteLine("id: "+ getId());
            Console.WriteLine("descount: "+ getDiscountPrecentage() + "%");
            Console.WriteLine("Release Date: " + getReleaseDate());
            Console.WriteLine("Expire Date: " + getExpireDate());
            Console.WriteLine("manger Name: " + getMangerName());
            Console.WriteLine("Message: " + getMessage());
            Console.WriteLine("price: " + getPriceOffer());
            foreach (KeyValuePair<int, Product> product in dicOfProduct)
            {
                Console.WriteLine("product id: {0}", product.Key);
                product.Value.showProduct();
            }
        }
    }
}
