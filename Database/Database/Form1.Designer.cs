namespace Database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            новаяТаблицаToolStripMenuItem = new ToolStripMenuItem();
            сохранитьДаныеToolStripMenuItem = new ToolStripMenuItem();
            загрузитьДанныеToolStripMenuItem = new ToolStripMenuItem();
            jоткрытьФайлToolStripMenuItem = new ToolStripMenuItem();
            загрузитьФайлToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { новаяТаблицаToolStripMenuItem, сохранитьДаныеToolStripMenuItem, загрузитьДанныеToolStripMenuItem, jоткрытьФайлToolStripMenuItem, загрузитьФайлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // новаяТаблицаToolStripMenuItem
            // 
            новаяТаблицаToolStripMenuItem.Name = "новаяТаблицаToolStripMenuItem";
            новаяТаблицаToolStripMenuItem.Size = new Size(101, 20);
            новаяТаблицаToolStripMenuItem.Text = "Новая таблица";
            новаяТаблицаToolStripMenuItem.Click += новаяТаблицаToolStripMenuItem_Click;
            // 
            // сохранитьДаныеToolStripMenuItem
            // 
            сохранитьДаныеToolStripMenuItem.Name = "сохранитьДаныеToolStripMenuItem";
            сохранитьДаныеToolStripMenuItem.Size = new Size(12, 20);
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            загрузитьДанныеToolStripMenuItem.Size = new Size(12, 20);
            // 
            // jоткрытьФайлToolStripMenuItem
            // 
            jоткрытьФайлToolStripMenuItem.Name = "jоткрытьФайлToolStripMenuItem";
            jоткрытьФайлToolStripMenuItem.Size = new Size(12, 20);
            // 
            // загрузитьФайлToolStripMenuItem
            // 
            загрузитьФайлToolStripMenuItem.Name = "загрузитьФайлToolStripMenuItem";
            загрузитьФайлToolStripMenuItem.Size = new Size(12, 20);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "база данных";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem новаяТаблицаToolStripMenuItem;
        private ToolStripMenuItem сохранитьДаныеToolStripMenuItem;
        private ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem jоткрытьФайлToolStripMenuItem;
        private ToolStripMenuItem загрузитьФайлToolStripMenuItem;
    }
}