using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class LanguageDAO
    {
        public static Int32 getID(string language) 
        {
            string connString = "Server=127.0.0.1;Database=book_store;Uid=root;Password=Basscara Hophie1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id FROM book_store.language where name='" + language + "';";
                Int32 idLanguage = -1;
                idLanguage = (Int32)cmd.ExecuteScalar();

                conn.Close();

                return idLanguage;
            }
            catch (Exception)
            {
                MessageBox.Show("Error happened!");
                return 0;
            }
        }

        public static Language getByID(int id)
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM language where id='" + id + "';";


            if (conn.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                dataReader.Read();
                Language language = new Language(dataReader["name"].ToString());

                //close Data Reader
                dataReader.Close();

                //close Connection
                conn.CloseConnection();


                return language;
            }
            else
            {
                return null;
            }

        }
        public static List<Language> Select()
        {
            ConnectionPool conn = new ConnectionPool();

            string query = "SELECT * FROM language";

            //Create a list to store the result
            List<Language> list = new List<Language>();

           
            if (conn.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Language language = new Language(dataReader["name"].ToString());
                    list.Add(language);

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



    }
}
