using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class BookHasAuthorDAO
    {
        public static List<BookHasAuthor> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_has_author";

            //Create a list to store the result
            int v = BookDAO.BookCount();
            List<BookHasAuthor> list = new List<BookHasAuthor>();

            
            if (conn.OpenConnection() == true)
            {
                
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int b;
                int a;

                

                while (dataReader.Read())
                {
                    b = (Int32)dataReader["BOOK_id"];
                    a = (Int32)dataReader["AUTHOR_id"];

                    Book book = BookDAO.getByID(b);
                    Author author = AuthorDAO.getByID(a);

                    BookHasAuthor bookHasAuthor = new BookHasAuthor(book, author);
                    list.Add(bookHasAuthor);

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

        public static Int32 getAuthorID(Book book) 
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT AUTHOR_id FROM book_store.book_has_author where BOOK_id='" + BookDAO.getID(book.getTitle()) + "';";
                Int32 idAuthor = -1;
                idAuthor = (Int32)cmd.ExecuteScalar();

                conn.Close();

                return idAuthor;
            }
            catch (Exception)
            {
                MessageBox.Show("Error happened!");
                return 0;
            }
        }

        public static Int32 getBookID(Author author)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT BOOK_id FROM book_store.book_has_author where AUTHOR_id='" + AuthorDAO.getID(author.getFirstName(),author.getLastName()) + "';";
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

        

        public static void Insert(Book book,Author author)
        {

            
                string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

                //open connection
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);



                    conn.Open();


                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT into book_has_author (BOOK_id,AUTHOR_id) values('" + BookDAO.getID(book.getTitle()) + "','" + AuthorDAO.getID(author.getFirstName(),author.getLastName()) +"');";

                    
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


        public static void Delete(Book b,Author author)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "DELETE from book_store.book_has_author where BOOK_id='" + BookDAO.getID(b.getTitle()) + "' and AUTHOR_id='" + AuthorDAO.getID(author.getFirstName(),author.getLastName()) + "';";
                
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

