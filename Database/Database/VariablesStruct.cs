using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database
{
    struct VariablesStruct
    {
        static public MySqlDataAdapter msDataAdapter;
        static public MySqlConnection mySqlconnection;
        static public MySqlCommand msCommand;
        static public MySqlConnection connection;
        static public string server;
        static public string database;
        static public string user;
        static public string password;
        static public string port;
        static public string connectionString;
        static public string sslM;
    }
}
