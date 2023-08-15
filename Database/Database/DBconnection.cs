using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SD = System.Data;
using static Database.VariablesStruct;

namespace Database
{
    public class DBconnection
    {

       


        



        public static DataGridView dgv = new DataGridView();// переменная для передачи между формами


        public static bool ConnectionDB() // буллевый метод
        {
            server = "localhost"; // Сервер
            database = "avto";  // база данных
            user = "root"; // имя пользовтеля
            password = "z147z147"; // пароль от бд
            port = "3307"; // порт
            sslM = "none";  // безопасность в бд так как у нас локальканая бд она не нужна



            try
            {
                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM); // переменная для подключение бд


                mySqlconnection = new MySqlConnection(connectionString); // создание экземпляра класса подключения
                mySqlconnection.Open(); // открытие соединения
                msCommand = new MySqlCommand(); // создания класса для SQL COMMANT
                msCommand.Connection = mySqlconnection; // реализация  SQL COMMANTOMMANT
                msDataAdapter = new MySqlDataAdapter(msCommand); // класс для адаьтации в таблице например
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединение с базой данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // обработка исключения
                return false;
            }
        } 

        public static void CloseDB() // метод для закрытия соединения
        {
            mySqlconnection.Close();
        }

        public MySqlConnection GetConnection() // get метод возращает соединенеи
        {
            return mySqlconnection;
        }

       


    }
}
