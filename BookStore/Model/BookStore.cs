using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class BookStore1
    {
        private string name;
        private string address;
        private string work_time;
        public string opening_date;

        public BookStore1(string name, string address, string work_time, string opening_date)
        {
            this.name = name;
            this.address = address;
            this.work_time = work_time;
            this.opening_date = opening_date;
        }

        public BookStore1(string name)
        {
            this.name = name;
            
        }
        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public string getWorkTime()
        {
            return work_time;
        }

        public string getOPeningDate()
        {
            return opening_date;
        }
    }
}
