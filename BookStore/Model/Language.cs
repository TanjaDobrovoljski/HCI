using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class Language //da li da postavim mogucnost izbora vise jezika tj dodavanja???
    {
        private string language = "serbian";
        private int id = 2;

        public Language(string language)
        {
            this.language = language;
        }

        public Language(int i)
        {
            this.id = i;
        }

        public string getLanguage()
        {
            return language;
        }

    }
}
