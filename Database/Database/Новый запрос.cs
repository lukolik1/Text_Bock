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
using static Database.VariablesStruct;

namespace Database
{
    public partial class Новый_запрос : Form
    {
        public Новый_запрос()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text; //  записываем передоваемое значение из richTextBox1.Text
            MySqlConnection connection = new MySqlConnection(connectionString); // создание экземпляра класса подключения
            connection.Open();// открытие соединения
            MySqlDataAdapter reader = new MySqlDataAdapter(script, connectionString);// реализация скрипта
            SD.DataTable table = new SD.DataTable();// создание экземпляра таблицы
            reader.Fill(table);// реализация sql запроса и рендерим в записи в таблицу
            DBconnection.dgv.DataSource = table;// отправляем запрос
            connection.Close();// закрытие соединения
        }
    }
}
