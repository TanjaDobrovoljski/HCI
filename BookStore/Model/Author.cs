using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class Author
    {
        private string firstName;
        private string lastName;
        private string birthPlace;
        private string date_of_birth;

        public Author(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Author (string firstName,string lastName,string date, string birth_place)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.date_of_birth = date;
            this.birthPlace = birth_place;
            
            
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }
        public string getBirthPlace()
        {
            return birthPlace;
        }
        public string getDateOfBirth()
        {
            return date_of_birth;
        }
    }
}
