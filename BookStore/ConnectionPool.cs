using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace BookStore
{
    class ConnectionPool
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public ConnectionPool()
        {
            Initialize();
            
        }

        //Initialize values
        private void Initialize()
        {
            server = "127.0.0.1";
            database = "book_store";
            uid = "root";
            password = "Basscara Hophie1";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Database=" +
            database + ";" + "Uid=" + uid + ";" + "Password=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public  bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        internal MySqlCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert()
        {
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
       /* public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }*/

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
    /*private static ArrayList connections;
    private static int connectionNumber = 10;
    private static string connectionString = "Server=127.0.0.1;Database=book_store;Uid=root;Pwd=BasscaraHophie1;";

    public static string ConnectionString
    {
        get { return ConnectionPool.connectionString; }
        set { ConnectionPool.connectionString = value; }
    }


    static ConnectionPool()
    {
        try
        {
            connections = new ArrayList();
            for (int i = 0; i < connectionNumber; i++)
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                connections.Add(conn);
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
        }
    }

    public static MySqlConnection getSingleConnection()
    {
        MySqlConnection conn = new MySqlConnection(connectionString);
        conn.Open();
        return conn;
    }

    public static void closeSingleConnection(MySqlConnection conn)
    {
        conn.Close();
    }

    public static MySqlConnection checkOutConnection()
    {
        foreach (MySqlConnection conn in connections)
        {
            if (conn.State == ConnectionState.Open)
            {
                connections.Remove(conn);
                return conn;
            }
        }
        MySqlConnection fallback = getSingleConnection();
        return fallback;
    }

    public static void checkInConnection(MySqlConnection conn)
    {
        connections.Add(conn);
    }*/

}