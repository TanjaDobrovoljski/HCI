using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class BookStoreHasBook
    {
        private Book book;
        private BookStore1 bookStore;
        private int quantity;
        private double price;

        public BookStoreHasBook(Book book,BookStore1 bookStore,int quantity,double price)
        {
            this.book = book;
            this.bookStore = bookStore;
            this.quantity = quantity;
            this.price = price;
        }

        public Book getBook()
        {
            return book;
        }

        public BookStore1 getBookStore()
        {
            return bookStore;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public double getPrice()
        {
            return price;
        }

    }
}
