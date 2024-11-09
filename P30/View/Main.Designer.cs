namespace P30
{
    partial class Main
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(114, 68);
            button1.Name = "button1";
            button1.Size = new Size(260, 50);
            button1.TabIndex = 1;
            button1.Text = "Управление учебным процессом";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(114, 124);
            button2.Name = "button2";
            button2.Size = new Size(260, 50);
            button2.TabIndex = 2;
            button2.Text = "Учащиеся и группы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(114, 180);
            button3.Name = "button3";
            button3.Size = new Size(260, 50);
            button3.TabIndex = 3;
            button3.Text = "Преподаватели";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(114, 236);
            button4.Name = "button4";
            button4.Size = new Size(260, 50);
            button4.TabIndex = 4;
            button4.Text = "Специальности";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(114, 292);
            button5.Name = "button5";
            button5.Size = new Size(260, 50);
            button5.TabIndex = 5;
            button5.Text = "Предметы";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(114, 348);
            button6.Name = "button6";
            button6.Size = new Size(260, 50);
            button6.TabIndex = 6;
            button6.Text = "Кафедры";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 504);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Main";
            Text = "Главное меню";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
