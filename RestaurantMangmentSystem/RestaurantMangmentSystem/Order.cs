using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    public class Order
    {
        // Attr In Order Class
        static int counter;
        private int id;
        private int deliveryTime;
        private bool resevedStatus;
        private DateTime date = new DateTime();
        private int deliveryCharges;
        private float totalCash;
        private int discountPrecentage;
        private float cashAfterDiscount;
        private string complainMessage;
        private Dictionary<int, Product> dicOfProduct = new Dictionary<int, Product>();
        private Dictionary<int, Offer> dicOfOffer = new Dictionary<int, Offer>();

        // Methods In Order Class

        // Constructors
        public Order()
        {
            id = ++counter;
            resevedStatus = false;
            date = DateTime.Now;
            deliveryCharges = 8;
            deliveryTime = 40;
        }

        public Order(int deliveryTime, bool resevedStatus, int deliveryCharges, int totalCash, int discountPrecentage, int cashAfterDiscount, string complainMessage)
        {
            id = ++counter;
            this.deliveryTime = deliveryTime;
            this.resevedStatus = resevedStatus;
            date = DateTime.Now;
            this.deliveryCharges = deliveryCharges;
            this.totalCash = totalCash;
            this.discountPrecentage = discountPrecentage;
            this.cashAfterDiscount = cashAfterDiscount;
            this.complainMessage = complainMessage;
        }

        // Methods In Oder Class

        // Setter Methods
        public void setDeliveryTime(int deliveryTime)
        {
            this.deliveryTime = deliveryTime;
        }

        public void setResevedStatus(bool resevedStatus)
        {
            this.resevedStatus = resevedStatus;
        }

        public void setDeliveryCharges(int deliveryCharges)
        {
            this.deliveryCharges = deliveryCharges;
        }

        public void setTotalCash(float totalCash)
        {
            this.totalCash = totalCash;
        }

        public void setDiscountPrecentage(int discountPrecentage)
        {
            this.discountPrecentage = discountPrecentage;
        }

        public void setCashAfterDiscount(float cashAfterDiscount)
        {
            this.cashAfterDiscount = cashAfterDiscount;
        }

        public void setComplainMessage(string complainMessage)
        {
            this.complainMessage = complainMessage;
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

        public int getDeliveryTime()
        {
            return deliveryTime;
        }

        public bool getResevedStatus()
        {
            return resevedStatus;
        }

        public DateTime getDate()
        {
            return date;
        }

        public int getDeliveryCharges()
        {
            return deliveryCharges;
        }

        public float getTotalCash()
        {
            return totalCash;
        }

        public int getDiscountPrecenatge()
        {
            return discountPrecentage;
        }

        public float getCashAfterDiscount()
        {
            return cashAfterDiscount;
        }

        public string getComplainMessage()
        {
            return complainMessage;
        }

        // Custom Methods
        public void addProduct(Product newProduct)
        {
            dicOfProduct.Add(newProduct.getId(), newProduct);
        }

        public void addOffer(Offer newOffer)
        {
            dicOfOffer.Add(newOffer.getId(), newOffer);
        }

        public void deleteProduct(int id)
        {
            try
            {
                if (dicOfProduct.ContainsKey(id))
                    dicOfProduct.Remove(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteOffer(int id)
        {
            try
            {
                if (dicOfOffer.ContainsKey(id))
                    dicOfOffer.Remove(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PlaceOrder()
        {
            foreach (KeyValuePair<int, Product> product in dicOfProduct)
                totalCash += product.Value.getPrice();
            foreach (KeyValuePair<int, Offer> offer in dicOfOffer)
                totalCash += offer.Value.getPriceOffer();
            totalCash += deliveryCharges;
            cashAfterDiscount = totalCash - (totalCash * (discountPrecentage / 100f));
        }

        public void showOrder()
        {
            Console.WriteLine("Order Id " + getId());
            Console.WriteLine("Delivery Time: " + getDeliveryTime());
            Console.WriteLine("Reseved Status: " + getResevedStatus());
            Console.WriteLine("Date: " + getDate());
            Console.WriteLine("Delivery Charges: " + getDeliveryCharges());
            Console.WriteLine("Total Cash: " + getTotalCash());
        }
    }
}
