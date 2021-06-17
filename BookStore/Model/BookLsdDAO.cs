using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class BookLsdDAO
    {
/*
        public static Int32 getID(string title) //mora ovdje ici i autor da zna koju tacno knjigu da vrati ako postoji vise knjiga sa istim imenom
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.book_lsd where title='" + title + "';";
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

        public static BookLsd getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_lsd where BOOK_id='" + id + "';";


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                BookLsd bookLsd = new BookLsd(dataReader["title"].ToString(),dataReader["description"].ToString(),dataReader["image"].ToString() );

                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();


                return bookLsd;
            }
            else
            {
                return null;
            }

        }

        //provjeri za publishera
        public static void Add_book(string title, string description, string image, Author author)//mora imat i u koju knjizaru ide
        {

            BookLsd b = new BookLsd(title, description, image);

            if (Check_book(b) == false)
            {
                string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";


                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);

                    conn.Open();


                    MySqlCommand comm = conn.CreateCommand();

                    comm.CommandText = "INSERT into book (title,publishing_year,PUBLISHER_id,description,image) values('" + title + "','" + publishing_year + "','" + PublisherDAO.getID(publisher.getName()) + "','" + description + "','" + image + "');";

                    AuthorDAO.Add_author(author.getFirstName(), author.getLastName(), author.getBirthPlace(), author.getDateOfBirth().ToString());

                    BookHasAuthorDAO.Insert(b, author);

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

        public static bool Check_book(BookLsd b)
        {
            List<BookLsd> list = Select();
            Book book = BookDAO.getByID(getID(b.getTitle()));

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getTitle().Equals(b.getTitle()) &&  && list[i].getAuthor().Equals(b.getAuthor()))
                    return true;
            }
            return false;
        }

        public static List<BookLsd> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_lsd";

            //Create a list to store the result
            List<BookLsd> list = new List<BookLsd>();

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
                    BookLsd b = new BookLsd(dataReader["title"].ToString(), dataReader["description"].ToString(), dataReader["image"].ToString());
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

        public static int BookLsdCount()
        {
            List<BookLsd> lista = Select();
            return lista.Count;
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
                comm.CommandText = "DELETE from book_store.book where title='" + title + "' and publishing_year='" + publishing_year + "';";
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
*/

    }
}
