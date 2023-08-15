namespace Database
{
    partial class Новый_запрос
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(692, 221);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(104, 262);
            button2.Name = "button2";
            button2.Size = new Size(445, 47);
            button2.TabIndex = 6;
            button2.Text = "Запрос";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Новый_запрос
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 321);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Name = "Новый_запрос";
            Text = "Новый_запрос";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button2;
    }
}