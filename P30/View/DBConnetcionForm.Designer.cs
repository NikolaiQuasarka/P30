namespace P30
{
    partial class DBConnetcionForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 98);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Название сервера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 145);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 196);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(179, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 193);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 5;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 330);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "Подключение к базе данных";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}