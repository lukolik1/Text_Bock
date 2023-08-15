using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String fileName = openFileDialog1.FileName;
            FileStream filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            if (filestream != null)
            {
                StreamReader streamreader = new StreamReader(filestream);
                txfflox.Text = streamreader.ReadToEnd();
                filestream.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            String fileName = saveFileDialog1.FileName;
            FileStream filestream = File.Open(fileName, FileMode.Create,
            FileAccess.Write);
            if (filestream != null)
            {
                StreamWriter streamwriter = new StreamWriter(filestream);
                streamwriter.Write(txfflox.Text);
                streamwriter.Flush();
                filestream.Close();
            }
        }
    }
}