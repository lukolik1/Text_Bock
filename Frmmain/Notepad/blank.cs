using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Notepad
{
    public partial class blank : Form
    {
        public String DocName;
        private String BufferText;
        public bool IsSaved = false;

        public void Cut() // Вырезание текста 
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }


        public void Copy() // Копирование текста
        {
            this.BufferText = richTextBox1.SelectedText;
        }

        public void Paste() // Вставка
        {
            richTextBox1.SelectedText = this.BufferText;
        }

        // Выделение всего текста – используем свойство SelectAll элемента  управления RichTextBox

        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }

        public void Delete() // Удаление 
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }


        public void Color_Red() // Удаление 
        {
            richTextBox1.ForeColor = Color.Red;
            
        }


        public void Fon_Times_New_Roman() // Удаление 
        {
           richTextBox1.SelectionFont = new Font("Times New Roman", 14);

        }


        public void Open(String OpenFileName)
        {
            if (OpenFileName == null) { return; }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd(); sr.Close();
                DocName = OpenFileName;
            }
        }



        public void Save(String SaveFileName)
        {
            if (SaveFileName == null) 
            { 
                return; 
            }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text); sw.Close(); //Устанавливаем имя документа
                DocName = SaveFileName;
            }
        }

        public blank()
        {

            InitializeComponent();



            

        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            

          
            


            // ассоциируем контекстное меню с текстовым полем
            richTextBox1.ContextMenuStrip = contextMenuStrip2;
            
           
            
        }

        private void blank_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsSaved == true)
                if (MessageBox.Show("Do you want save changes in "
                    + this.DocName + "?", "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
        }
    }
}
