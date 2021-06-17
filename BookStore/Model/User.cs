using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class User
    {
        private string username;
        private string password;
        private int admin = 2;

        public User(string username, string password, int admin)
        {
            this.username = username;
            this.password = password;
            this.admin = admin;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public int getAdmin()
        {
            return admin;
        }
    }
}

