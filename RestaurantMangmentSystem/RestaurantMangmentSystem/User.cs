using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMangmentSystem
{
    public abstract class User
    {
        // Attr In User Class
        private string name;
        private string mobileNumber;
        private string userName;
        private string password;

        // Methods In User Class

        // Setter Methods In User Class
        public void setName(string name)
        {
            this.name = name;
        }

        public void setMobileNumber(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        // Getter Methods In User Class
        public string getName()
        {
            return name;
        }

        public string getMobileNumber()
        {
            return mobileNumber;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
