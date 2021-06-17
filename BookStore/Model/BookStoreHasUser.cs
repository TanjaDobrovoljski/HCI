using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    class BookStoreHasUser
    {
        BookStore1 bookStore;
        User user;

        public BookStoreHasUser(BookStore1 bookStore,User user)
        {
            this.bookStore = bookStore;
            this.user = user;
        }
        public BookStore1 getBookStore()
        {
            return bookStore;
        }

        public User getUser()
        {
            return user;
        }

    }
}
