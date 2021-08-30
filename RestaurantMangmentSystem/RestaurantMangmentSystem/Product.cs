using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    public class Product
    {
        // Attr In Product Class
        static int counter;
        private int id;
        private string name;
        private string category;
        private float rate;
        private float price;
        private string photo;
        private int numberOfBuy;
        private int unitSold;
        private int quantity;

        // Methods In Product Class

        // Constructors
        public Product()
        {
            id = ++counter;
        }

        public Product(string name, string category, float rate, float price, string photo, int quantity)
        {
            id = ++counter;
            this.name = name;
            this.category = category;
            this.rate = rate;
            this.price = price;
            this.photo = photo;
            this.quantity = quantity;
        }

        // Setter Methods
        public void setName(string name)
        {
            this.name = name;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public void setRate(float rate)
        {
            this.rate = rate;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public void setPhoto(string photo)
        {
            this.photo = photo;
        }

        public void setNumberOfBuy(int numberOfBuy)
        {
            this.numberOfBuy = numberOfBuy;
        }

        public void setUnitSold(int unitSold)
        {
            this.unitSold = unitSold;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
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
        public string getName()
        {
            return name;
        }

        public string getCategory()
        {
            return category;
        }

        public float getRate()
        {
            return rate;
        }

        public float getPrice()
        {
            return price;
        }

        public string getPhoto()
        {
            return photo;
        }

        public int getNumberOfBuy()
        {
            return numberOfBuy;
        }

        public int getUnitSold()
        {
            return unitSold;
        }

        public int getQuantity()
        {
            return quantity;
        }

        // Custom Methods
        public void customerRate(float rate)
        {
            this.rate = (this.rate + rate) / 5f;
        }

        public void showProduct()
        {
            Console.WriteLine(getId());
            Console.WriteLine(getName());
            Console.WriteLine(getCategory());
            Console.WriteLine(getRate());
            Console.WriteLine(getPrice());
            Console.WriteLine(getPhoto());
            Console.WriteLine(getUnitSold());
        }
    }
}
