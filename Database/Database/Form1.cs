using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using MySql.Data.MySqlClient;

namespace Database
{
    public partial class Form1 : Form
    {
        private Table table; // обьявляем перемменую для создание окна Table


        public Form1()
        {
            InitializeComponent();

        }

        private void новаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB(); // Открываем соединение с бд
            table = new Table(); // обьявояем экземпляр
            table.MdiParent = this; // конструкция позволяет открывать окно в нашем окне this ображение к декущему окну
            table.Show(); // вызываем метод Show
        }


    }
}