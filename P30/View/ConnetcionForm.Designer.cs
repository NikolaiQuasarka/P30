namespace P30
{
    partial class ConnetcionForm
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
            comboBoxName = new ComboBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 82);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Название сервера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 129);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 180);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // comboBoxName
            // 
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(170, 79);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(211, 28);
            comboBoxName.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(170, 126);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(211, 27);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(170, 177);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(211, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(170, 248);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 6;
            button1.Text = "Соедениться";
            button1.UseVisualStyleBackColor = true;
            // 
            // ConnetcionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 330);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(comboBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConnetcionForm";
            Text = "Подключение к базе данных";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxName;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button button1;
    }
}