using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class BookStoreDAO
    {
        private static readonly Random _random = new Random();
        public static Int32 getID(string name)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.book_store where name='" + name + "';";
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

        public static BookStore1 getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_store where id='" + id + "';";


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                BookStore1 b = new BookStore1(dataReader["name"].ToString(), dataReader["address"].ToString(), dataReader["work_time"].ToString(), dataReader["opening_date"].ToString());

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


        public static void Add_bookStore(string name, string address, string work_time, string opening_date)
        {

            BookStore1 bookStore = new BookStore1(name, address, work_time, opening_date);

            if (Check_bookStore(bookStore) == false)
            {
                string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";


                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);

                    conn.Open();


                    MySqlCommand comm = conn.CreateCommand();

                    comm.CommandText = "INSERT into book_store (name,address,work_time,opening_date) values('" + name + "','" + address + "','" + work_time + "','" + opening_date + "');";


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


        public static bool Check_bookStore(BookStore1 b)
        {
            List<BookStore1> list = Select();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getName().Equals(b.getName()) && list[i].getAddress().Equals(b.getAddress()) && list[i].getWorkTime().Equals(b.getWorkTime()) && list[i].getOPeningDate().Equals(b.getOPeningDate()))
                    return true;
            }
            return false;
        }

        public static int BookStoreCount()
        {
            List<BookStore1> lista = Select();
            return lista.Count;
        }

        public static List<BookStore1> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_store";

            //Create a list to store the result
            List<BookStore1> list = new List<BookStore1>();


            if (conn.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                BookStore1 b;

                while (dataReader.Read())
                {
                    if (dataReader["opening_date"].ToString().Contains("12:00:00 AM") == true)
                    {
                        b = new BookStore1(dataReader["name"].ToString(), dataReader["address"].ToString(), dataReader["work_time"].ToString(), dataReader["opening_date"].ToString().Replace(". 12:00:00 AM", ""));
                        list.Add(b);
                    }
                    else if (dataReader["opening_date"].ToString().Contains("00:00:00") == true)
                    {
                        b = new BookStore1(dataReader["name"].ToString(), dataReader["address"].ToString(), dataReader["work_time"].ToString(), dataReader["opening_date"].ToString().Replace(". 00:00:00", ""));
                        list.Add(b);
                    }

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


        public static void Update(BookStore1 b,BookStore1 b2)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();



                
                var parsedDate = DateTime.Parse(b2.getOPeningDate());
                
                string p = parsedDate.ToString("yyyy-MM-dd");
                Console.WriteLine(p);

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE book_store SET name='" + b2.getName() + "', address='" + b2.getAddress() + "' , work_time='" +b2.getWorkTime() + "', opening_date='" + p + "'  WHERE id='" + BookStoreDAO.getID(b.getName()) + "';";



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

        public static void Delete(BookStore1 b)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                string name = b.getName();



                MySqlCommand comm = conn.CreateCommand();

                List<BookStoreHasBook> list = BookStoreHasBookDAO.Select();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].getBookStore().getName() == BookStoreDAO.getByID(BookStoreDAO.getID(b.getName())).getName())
                        BookStoreHasBookDAO.Delete(b, list[i].getBook());
                }
               // comm.CommandText = "DELETE from  book_store_has_book where BOOK_STORE_id='" + BookStoreDAO.getID(b.getName()) + "';";
               // comm.CommandText = "DELETE from book_store.book_store_has_user where BOOK_STORE_id='" + BookStoreDAO.getID(b.getName()) + "';";

                
                List<BookStoreHasUser> list2 = BookStoreHasUserDAO.Select();
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list[i].getBookStore().getName() == BookStoreDAO.getByID(BookStoreDAO.getID(b.getName())).getName())
                        BookStoreHasUserDAO.Delete(b, list2[i].getUser());
                }

                comm.CommandText = "DELETE from book_store.book_store where name='" + name + "';";
                
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
                        MessageBox.Show("Invalid first name/last name or date of birth, please try again");
                        break;
                }

            }

        }

        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

    }
}

    
