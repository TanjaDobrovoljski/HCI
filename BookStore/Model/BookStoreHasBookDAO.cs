using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class BookStoreHasBookDAO
    {

        public static List<BookStoreHasBook> getBooks(int bookStoreId)
        {
            ConnectionPool conn = new ConnectionPool();

            

            string query = "SELECT * FROM book_store_has_book WHERE BOOK_STORE_id='" + bookStoreId + "';";



            List<BookStoreHasBook> list = new List<BookStoreHasBook>();


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                int book;



                while (dataReader.Read())
                {
                    
                    book = (Int32)dataReader["BOOK_id"];

                    BookStore1 bookStore = BookStoreDAO.getByID(bookStoreId);
                    Book book1 = BookDAO.getByID(book);

                    BookStoreHasBook bookStoreHasBook = new BookStoreHasBook(book1, bookStore, (Int32)dataReader["quantity"],System.Convert.ToDouble( dataReader["price"].ToString()));

                    list.Add(bookStoreHasBook);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<BookStoreHasBook> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_store_has_book";



            List<BookStoreHasBook> list = new List<BookStoreHasBook>();


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                int b;
                int book;



                while (dataReader.Read())
                {
                    b = (Int32)dataReader["BOOK_STORE_id"];
                    book = (Int32)dataReader["BOOK_id"];

                    BookStore1 bookStore = BookStoreDAO.getByID(b);
                    Book book1 = BookDAO.getByID(book);

                    BookStoreHasBook bookStoreHasBook = new BookStoreHasBook(book1, bookStore, (Int32)dataReader["quantity"],Convert.ToDouble( dataReader["price"]));

                    list.Add(bookStoreHasBook);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static Int32 getBookStoreID(Book book)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT BOOK_STORE_id FROM book_store.book_store_has_book where BOOK_id='" + BookDAO.getID(book.getTitle()) + "';";
                Int32 idBook = -1;
                idBook = (Int32)cmd.ExecuteScalar();

                conn.Close();

                return idBook;
            }
            catch (Exception)
            {
                MessageBox.Show("Error happened!");
                return 0;
            }
        }

        public static Int32 getBookID(BookStore1 bookStore)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT BOOK_id FROM book_store.book_store_has_book where BOOK_STORE_id='" + BookStoreDAO.getID(bookStore.getName()) + "';";
                Int32 idBookStore = -1;
                idBookStore = (Int32)cmd.ExecuteScalar();

                conn.Close();

                return idBookStore;
            }
            catch (Exception)
            {
                MessageBox.Show("Error happened!");
                return 0;
            }
        }

        

        public static void Insert(BookStore1 bookStore, Book book, int quantity, double price)
        {


            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();


                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT into book_store_has_book (BOOK_STORE_id,BOOK_id,quantity,price) values('" + BookStoreDAO.getID(bookStore.getName().ToString()) + "','" + BookDAO.getID(book.getTitle().ToString()) + "','" + quantity + "','" + price + "');";


                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Cannot add , please try again");
                        break;
                }

            }


        }

        public static void Delete(BookStore1 bookStore,Book book)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "DELETE from book_store.book_store_has_book where BOOK_STORE_id='" + BookStoreDAO.getID(bookStore.getName()) + "' and BOOK_id='" + BookDAO.getID(book.getTitle()) + "';";
                
                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid data, please try again");
                        break;
                }

            }


        }
    }
}
