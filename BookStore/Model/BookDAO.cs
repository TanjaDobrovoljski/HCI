using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class BookDAO
    {
        public static  Author getAuthor(Book b)
        {
            
           return  AuthorDAO.getByID(BookHasAuthorDAO.getAuthorID(b));
        }
        public static Int32 getID(string title) //mora ovdje ici i autor da zna koju tacno knjigu da vrati ako postoji vise knjiga sa istim imenom
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.book where title='" + title + "';";
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

        public static Book getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book where id='" + id + "';";


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                Book b = new Book(dataReader["title"].ToString(), (Int32)dataReader["publishing_year"], PublisherDAO.getByID((Int32)dataReader["PUBLISHER_id"]), dataReader["description"].ToString(),dataReader["image"].ToString());


                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();


                return b;
            }
            else
            {
                return null;
            }

        }

        public static void Add_book(string title, int publishing_year, Publisher publisher, string description, string image,Author author)//mora imat i u koju knjizaru ide
        {

            Book b = new Book(title,publishing_year,publisher,description,image);

            if (Check_book(b) == false)
            {
                string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

                
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);

                    conn.Open();


                    MySqlCommand comm = conn.CreateCommand();
                    b.setAuthor(author);

                    comm.CommandText = "INSERT into book (title,publishing_year,PUBLISHER_id,description,image) values('" + title + "','" + publishing_year + "','" + PublisherDAO.getID(publisher.getName()) + "','" + description + "','" + image + "');";

                    AuthorDAO.Add_author(author.getFirstName(), author.getLastName(), author.getBirthPlace(), author.getDateOfBirth().ToString());


                    


                     //treba pozvat i add  u book store has book
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
                            MessageBox.Show("Cannot add new book, please try again");
                            break;
                    }

                }


            }
            else
                MessageBox.Show("This book already exist");


        }

        public static bool Check_book(Book b)
        {
            List<Book> list = Select();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getTitle().Equals(b.getTitle()) && list[i].getPublishingYear().Equals(b.getPublishingYear()) && list[i].getAuthor().Equals(b.getAuthor()))
                    return true;
            }
            return false;
        }

        public static List<Book> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book";

            //Create a list to store the result
            List<Book> list = new List<Book>();

            //list[2] = new List<string>();

            //Open connection
            if (conn.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Book b = new Book(dataReader["title"].ToString(), (Int32)dataReader["publishing_year"], PublisherDAO.getByID((Int32)dataReader["PUBLISHER_id"]), dataReader["description"].ToString(), dataReader["image"].ToString());
                    list.Add(b);
                    

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

        public static int BookCount()
        {
            List<Book> lista = Select();
            return lista.Count;
        }

        public static void Update(Book b, Book b2)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();





                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE book SET title='" + b2.getTitle() + "', publishing_year='" + b2.getPublishingYear() + "' , PUBLISHER_id='" + PublisherDAO.getID(b2.getPublisher().getName()) + "', description='" + b2.getDescription() + "' ,image='" + b2.getImage() +"' WHERE id='" + BookDAO.getID(b.getTitle())+ "';";



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
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

            }


        }

        public static void Delete(Book b)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                string title = b.getTitle();
                Publisher publisher = b.getPublisher();
                Author author = b.getAuthor();
                int publishing_year = b.getPublishingYear();



                MySqlCommand comm = conn.CreateCommand();

                List<BookHasAuthor> list = BookHasAuthorDAO.Select();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].getBook().getTitle() == BookDAO.getByID(BookDAO.getID(title)).getTitle())
                        BookHasAuthorDAO.Delete(b, list[i].getAuthor());
                }

                List<BookStoreHasBook> list2 = BookStoreHasBookDAO.Select();
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2[i].getBook().getTitle() == BookDAO.getByID(BookDAO.getID(title)).getTitle())
                        BookStoreHasBookDAO.Delete(list2[i].getBookStore(), b);
                }
                //comm.CommandText = "DELETE from  book_has_author where BOOK_id='" + BookDAO.getID(b.getTitle()) + "';";
               // comm.CommandText = "DELETE from  book_store_has_book where BOOK_id='" + BookDAO.getID(b.getTitle()) + "';";

                

                comm.CommandText = "DELETE from book_store.book where title='" + title + "' and publishing_year='" + publishing_year +"';";
                //ispravi za publishera,ide ti id a ne ime njegovo tj on
                //nez sta je ovo gore, al brises odmah knjigu i iz klase book has author

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
