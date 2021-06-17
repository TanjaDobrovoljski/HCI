using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class Publisher
    {
        private string name;
        private string address;
        private string email;
        private string phone_number;

        public Publisher(string name)
        {
            this.name = name;
        }
        public Publisher(string name,string address,string email,string phone_number)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone_number = phone_number;
        }

        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public string getEmail()
        {
            return email;

        }
        public string getPhoneNumber()
        {
            return phone_number;
        }
    }
}
