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
        private Table table; // ��������� ���������� ��� �������� ���� Table


        public Form1()
        {
            InitializeComponent();

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB(); // ��������� ���������� � ��
            table = new Table(); // ��������� ���������
            table.MdiParent = this; // ����������� ��������� ��������� ���� � ����� ���� this ��������� � �������� ����
            table.Show(); // �������� ����� Show
        }


    }
}