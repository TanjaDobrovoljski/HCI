using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class BookStoreHasUserDAO
    {
        public static List<User> userList(int i)
        {
            
            List<User> list2 = new List<User>();

            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_store_has_user where BOOK_STORE_id='" + i + "';";

            //Create a list to store the result

           


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    
                     int u = (Int32)dataReader["USER_id"];

                    
                    User user = UserDAO.getByID(u);

                    

                    list2.Add(user);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();

                //return list to be displayed
                return list2;
            }
            else
            {
                return list2;
            }

        }
        public static List<BookStoreHasUser> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM book_store_has_user";

            //Create a list to store the result
            
            List<BookStoreHasUser> list = new List<BookStoreHasUser>();


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                int b;
                int u;



                while (dataReader.Read())
                {
                    b = (Int32)dataReader["BOOK_STORE_id"];
                    u = (Int32)dataReader["USER_id"];

                    BookStore1 store = BookStoreDAO.getByID(b);
                    User user = UserDAO.getByID(u);

                    BookStoreHasUser bookStoreHasUser = new BookStoreHasUser(store, user);

                    list.Add(bookStoreHasUser);

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


        public static Int32 getUserID(BookStore1 bookStore)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT USER_id FROM book_store.book_store_has_user where BOOK_STORE_id='" + BookStoreDAO.getID(bookStore.getName())+ "';";
                Int32 idUser = -1;
                idUser = (Int32)cmd.ExecuteScalar();

                conn.Close();

                return idUser;
            }
            catch (Exception)
            {
                MessageBox.Show("Error happened!");
                return 0;
            }
        }

        public static Int32 getBookStoreID(User user)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT BOOK_STORE_id FROM book_store.book_store_has_user where USER_id='" + UserDAO.getID(user.getUsername()) + "';";
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

        public static void Insert(BookStore1 book, User user)
        {


            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();


                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT into book_store_has_user (BOOK_STORE_id,USER_id) values('" + BookStoreDAO.getID(book.getName()) + "','" +UserDAO.getID(user.getUsername())+ "');";


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
                        MessageBox.Show("Cannot add, please try again");
                        break;
                }

            }


        }

        public static void Delete(BookStore1 b, User u)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();





                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "DELETE from book_store.book_store_has_user where BOOK_STORE_id='" + BookStoreDAO.getID(b.getName()) + "' and USER_id='" + UserDAO.getID(u.getUsername()) + "';";
                
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

        public static void Update_user(User u,string b)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();





                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE book_store_has_user SET USER_id='" + UserDAO.getID(u.getUsername()) + "' WHERE BOOK_STORE_id='" + BookStoreDAO.getID(b) + "';";



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

        public static void Update_bookStore(User u, BookStore1 b)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();





                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE book_store_has_user SET BOOK_STORE__id='" + BookStoreDAO.getID(b.getName())  + "' WHERE USER_id='" + UserDAO.getID(u.getUsername()) + "';";



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



    }
}
