using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;

namespace BookStore.Model
{
    class UserDAO
    {
       // ConnectionPool conn = new ConnectionPool();
       // private static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ToString();

        public static Int32 getID(string username)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.user where username='"+ username +"';";
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
        public static User getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM user where id='" + id + "';";


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                User a = new User(dataReader["username"].ToString(), dataReader["password"].ToString(), (Int32)dataReader["ROLE_id"]);


                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();


                return a;
            }
            else
            {
                return null;
            }

        }

        public static bool Check_user(string username,string password)
        {
            List<User> list = Select();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getUsername().Equals(username) && list[i].getPassword().Equals(password))
                    return true;
            }
            
            return false;
        }

        public static bool Check_Username(string user_name)
        {
            List<User> list = Select();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getUsername().Equals(user_name))
                    return true;
            }
            
            return false;
        }


        public static Int32 Check_Role(string userName,string hashPassword)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM user where username ='" + userName + "' and password = '" + hashPassword + "' ";
                MySqlDataReader reader = cmd.ExecuteReader();

                List<User> list = Select();


                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i].getUsername() == userName && list[i].getPassword() == hashPassword )
                    {
                        if (list[i].getAdmin() == 1)
                            return 1;
                        if (list[i].getAdmin() == 2)
                            return 2;

                    }
                }

                
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
            return -1;

        }
        

        public static List<User> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM user";

            //Create a list to store the result
            List<User> list = new List<User>();
         
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
                    User u = new User(dataReader["username"].ToString(),dataReader["password"].ToString(),(Int32)dataReader["ROLE_id"]);
                    list.Add(u);
                    
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

        public static void Insert(User user)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try 
            {
                MySqlConnection conn = new MySqlConnection(connString);
                


                conn.Open();

                string username = user.getUsername();
                string password = user.getPassword();
                

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT into user (username,password,ROLE_id) values('" + username + "','"+password+"','"+2+"');";

                //
                /*comm.Parameters.AddWithValue("@username",user.getUsername());
                comm.Parameters.AddWithValue("@password", user.getPassword());
                comm.Parameters.AddWithValue("@role_id", user.getAdmin());
                */
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
                        MessageBox.Show("Cannot add new user, please try again");
                        break;
                }

            }
        }

        //Update statement
       public static void Update(User u,User u2)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                



                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE user SET username='"+u2.getUsername()+"', password='"+u2.getPassword()+"' , ROLE_id='"+u2.getAdmin()+"' WHERE id='"+UserDAO.getID(u.getUsername())+"';";


                
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

        //Delete statement
        public static void Delete(User u) //samo po imenu brise
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                string username = u.getUsername();
                //string password = u.getPassword();

                List<BookStoreHasUser> list = BookStoreHasUserDAO.Select();
                
                
                MySqlCommand comm = conn.CreateCommand();


                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].getUser().getUsername() == UserDAO.getByID(UserDAO.getID(u.getUsername())).getUsername())
                        BookStoreHasUserDAO.Delete(list[i].getBookStore(), u);
                }

                comm.CommandText = "DELETE from book_store.user where username='" + username + "';"; 

                
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

