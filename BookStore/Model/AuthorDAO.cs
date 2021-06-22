using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class AuthorDAO
    {
        /*public static Int32 getID(string first_name,string last_name,string date)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";
            
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.author where first_name='" + first_name + "' and last_name='"+last_name+"' and date_of_birth='"+date+"';";
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
        }*/

        public static Int32 getID(string first_name, string last_name)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.author where first_name='" + first_name + "' and last_name='" + last_name + "';";
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

        public static Author getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM author where id='" + id + "';";


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                Author a = new Author(dataReader["first_name"].ToString(), dataReader["last_name"].ToString(),dataReader["date_of_birth"].ToString(), dataReader["birth_place"].ToString());


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

        public static void Add_author(string firstName, string lastName,  string date,string birth_place)
        {
            
            Author a = new Author(firstName, lastName, date, birth_place);

            if (Check_author(a) == false)
            {
                string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

                //open connection
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);



                    conn.Open();




                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT into book_store.author (first_name,last_name,date_of_birth,birth_place) VALUES('" + firstName + "','" + lastName + "','" + date + "','" + birth_place + "');";

                    
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
                            MessageBox.Show("Cannot add new author, please try again");
                            break;
                    }

                }


            }
            else
                MessageBox.Show("This author already exist");


        }

        public static bool Check_author(Author a)
        {
            List<Author> list = Select();

            for (int i=0;i<list.Count;i++)
            {
                if (list[i].getFirstName().Equals(a.getFirstName()) && list[i].getLastName().Equals(a.getLastName()) && list[i].getDateOfBirth().Equals(a.getDateOfBirth()) && list[i].getBirthPlace().Equals(a.getBirthPlace()))
                    return true;
            }
            return false;
        }


        public static List<Author> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM author";

            //Create a list to store the result
            List<Author> list = new List<Author>();

            //list[2] = new List<string>();

            //Open connection
            if (conn.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Author u;
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if (dataReader["date_of_birth"].ToString().Contains("12:00:00 AM") == true)
                    {
                        u = new Author(dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), dataReader["date_of_birth"].ToString().Replace(". 12:00:00 AM", ""), dataReader["birth_place"].ToString());
                        list.Add(u);
                    }
                    else if (dataReader["date_of_birth"].ToString().Contains("00:00:00") == true)
                            {
                        u = new Author(dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), dataReader["date_of_birth"].ToString().Replace(". 00:00:00", ""), dataReader["birth_place"].ToString());
                        list.Add(u);
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

        public static void Update(Author a, Author a2)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();


                var parsedDate = DateTime.Parse(a2.getDateOfBirth());

                string p = parsedDate.ToString("yyyy-MM-dd");

               
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE author SET first_name='" + a2.getFirstName() + "', last_name='" + a2.getLastName() + "' , date_of_birth='" + p+"', birth_place='" + a2.getBirthPlace() +  "' WHERE id='" + AuthorDAO.getID(a.getFirstName(),a.getLastName()) + "';";



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

        public static void Delete(Author a)
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;password = Basscara Hophie1;";

            //open connection
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);



                conn.Open();

                string first_name = a.getFirstName();
                string last_name = a.getLastName();
                string date = a.getDateOfBirth();
                List<BookHasAuthor> list = BookHasAuthorDAO.Select();
                

                MySqlCommand comm = conn.CreateCommand();
                for (int i = 0; i < list.Count; i++)
                {
                    if ((list[i].getAuthor().getFirstName() == AuthorDAO.getByID(AuthorDAO.getID(a.getFirstName(), a.getLastName())).getFirstName()) && (list[i].getAuthor().getLastName() == AuthorDAO.getByID(AuthorDAO.getID(a.getFirstName(), a.getLastName())).getLastName()))
                        BookHasAuthorDAO.Delete(list[i].getBook(), a);
                }


                comm.CommandText = "DELETE from book_store.author where first_name='" + first_name + "' and last_name='" + last_name +  "';";

               
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
    }
}
