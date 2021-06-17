using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class PublisherDAO
    {
        public static Int32 getID(string name)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.publisher where name='" + name + "';";
                Int32 idPublisher = -1;
                idPublisher = (Int32)cmd.ExecuteScalar();

                conn.Close();

                return idPublisher;
            }
            catch (Exception)
            {
                MessageBox.Show("Error happened!");
                return 0;
            }
        }

        public static Publisher getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM publisher where id='" + id + "';";

           
            if (conn.OpenConnection() == true)
            {
                
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                Publisher p = new Publisher(dataReader["name"].ToString(), dataReader["address"].ToString(), dataReader["email"].ToString(), dataReader["phone_number"].ToString());
                 

                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();

                
                return p;
            }
            else
            {
                return null;
            }

        }


        public static void Add_publisher(string name, string address, string email, string phone_number)
        {

            Publisher p = new Publisher(name, address, email, phone_number);

            if (Check_publisher(p) == false)
            {
                string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password =Basscara Hophie1;";

                //open connection
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);



                    conn.Open();


                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT into publisher (name,address,email,phone_number) values('" + name + "','" + address + "','" + email+ "','" + phone_number + "');";

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
                            MessageBox.Show("Cannot add new publisher, please try again");
                            break;
                    }

                }


            }
            else
                MessageBox.Show("This author already exist");


        }

        public static bool Check_publisher(Publisher p)
        {
            List<Publisher> list = Select();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getName().Equals(p.getName()) && list[i].getAddress().Equals(p.getAddress()) && list[i].getEmail().Equals(p.getEmail()) && list[i].getPhoneNumber().Equals(p.getPhoneNumber()))
                    return true;
            }
            return false;
        }

        public static List<Publisher> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM publisher";

            //Create a list to store the result
            List<Publisher> list = new List<Publisher>();

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
                    Publisher p = new Publisher(dataReader["name"].ToString(), dataReader["address"].ToString(), dataReader["email"].ToString(), dataReader["phone_number"].ToString());
                    list.Add(p);

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

        public static void Update(Publisher p,Publisher p2)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();





                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE publisher SET name='" + p2.getName() + "', address='" + p2.getAddress() + "' , email='" + p2.getEmail() + "', phone_number='" + p2.getPhoneNumber() + "' WHERE id='" + PublisherDAO.getID(p.getName()) + "';";



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

        public static void Delete(Publisher p)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                string name = p.getName();



                MySqlCommand comm = conn.CreateCommand();
                List<Book> list = BookDAO.Select();
                for(int i=0;i<list.Count;i++)
                {
                    if (list[i].getPublisher().getName() == PublisherDAO.getByID(PublisherDAO.getID(p.getName())).getName())
                        BookDAO.Delete(BookDAO.getByID(BookDAO.getID(list[i].getTitle())));
                }
                
                
                //comm.CommandText = "DELETE from book_store.book where PUBLISHER_id='" + PublisherDAO.getID(p.getName()) + "';";

                comm.CommandText = "DELETE from book_store.publisher where id='" + PublisherDAO.getID(p.getName()) + "';";

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
                        MessageBox.Show("Invalid name, please try again");
                        break;
                }

            }


        }

    }
}
