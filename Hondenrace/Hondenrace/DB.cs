using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Hondenrace
{
    class DB
    {
        //MySqlConnection connection = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi467376;Database=dbi467376;Pwd=password123;");
        MySqlConnection connection = new MySqlConnection("Server=localhost;Uid=root;Database=casinoapp;Pwd= ;");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
