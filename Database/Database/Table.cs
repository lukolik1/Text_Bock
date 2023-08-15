using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;
using System.Data;
using System.Net.Http.Headers;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using static Database.VariablesStruct;


namespace Database
{


    public partial class Table : Form
    {








        public bool IsSaved = false; // обьявление перемменой для проверки
        public String DocName; // обьявление String переменной
        public SD.DataSet data; // обьявление DataSet  переменной для обработки наших данных из бд

        public object Table1 { get; set; } // обьявляем обьект который влзвращает get и set методы

        

        public Table()
        {
            InitializeComponent();
            
                string script = "SELECT * FROM avtocar"; // отображение данных из бд ( формируем скрипт)
                MySqlConnection connection = new MySqlConnection(connectionString);// создание экземпляра класса подключения
                connection.Open();// открытие соединения
                MySqlDataAdapter reader = new MySqlDataAdapter(script, connectionString); // реализация скрипта
                SD.DataTable table = new SD.DataTable(); // создание экземпляра таблицы
                reader.Fill(table); // реализация sql запроса и рендерим в записи в таблицу
                dataGridView1.DataSource = table; // отображение таблицы в datagrid
                connection.Close();// закрытие соединения


               


           
                













        }



        private void button2_Click(object sender, EventArgs e)
        {
            DBconnection.dgv.DataSource = dataGridView1.DataSource; // отопражения запроса в окна новый_Запрос
            Новый_запрос новый_Запрос = new Новый_запрос();
            новый_Запрос.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBconnection.dgv.DataSource;// отображение запроса из окна новый_запрос
        }





       


        


    }
}
