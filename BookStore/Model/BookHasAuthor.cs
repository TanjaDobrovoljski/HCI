using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class BookHasAuthor
    {
        private Book book;
        private Author author;

        public BookHasAuthor(Book book,Author author)
        {
            this.book = book;
            this.author = author;
        }

        public  Book getBook()
        {
            return book;
        }

        public Author getAuthor()
        {
            return author;
        }
    }
}
