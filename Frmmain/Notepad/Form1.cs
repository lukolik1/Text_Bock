using System.Windows.Forms;

namespace Notepad
{
    public partial class Frmmain : Form
    {
        private int openDoc;
        private blank frm;
        private inform inf;



        public Frmmain()
        {
            InitializeComponent();
            mnuSave.Enabled = false;

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            frm = new blank();
            frm.DocName = "Документ" + ++openDoc;
            frm.Text = frm.DocName; frm.MdiParent = this;
            frm.Show();
        }

        private void mnuArrangelcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank) (this.ActiveMdiChild);
            frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Paste();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Delete();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.SelectAll();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Fon_Times_New_Roman();
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Color_Red();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // задание доступных расширений файлов программно
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank(); frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
            mnuSave.Enabled = true;

        }
        
        private void mnuSave_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Save(frm.DocName);
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                frm.Save(saveFileDialog1.FileName); frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName; frm.Text = frm.DocName;
            }
            frm.IsSaved = true;
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)(this.ActiveMdiChild);
                frm.Save(saveFileDialog1.FileName); frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName; frm.Text = frm.DocName;
            }
            mnuSave.Enabled = true;
            frm.IsSaved = true;

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            inf = new inform();
            inf.MdiParent = this;
            inf.Show();
        }
    }
}