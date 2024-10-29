namespace P30
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
            mainMenuStrip = new MenuStrip();
            учебныйПроцессToolStripMenuItem = new ToolStripMenuItem();
            учебныеПланыToolStripMenuItem = new ToolStripMenuItem();
            семестровыеИтогиToolStripMenuItem = new ToolStripMenuItem();
            сапсапToolStripMenuItem = new ToolStripMenuItem();
            студентыToolStripMenuItem = new ToolStripMenuItem();
            группыToolStripMenuItem = new ToolStripMenuItem();
            сапапToolStripMenuItem = new ToolStripMenuItem();
            специальностиToolStripMenuItem = new ToolStripMenuItem();
            кафедрыToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            предметыToolStripMenuItem1 = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { учебныйПроцессToolStripMenuItem, сапсапToolStripMenuItem, сапапToolStripMenuItem, специальностиToolStripMenuItem, предметыToolStripMenuItem1, кафедрыToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1045, 28);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // учебныйПроцессToolStripMenuItem
            // 
            учебныйПроцессToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { учебныеПланыToolStripMenuItem, семестровыеИтогиToolStripMenuItem });
            учебныйПроцессToolStripMenuItem.Name = "учебныйПроцессToolStripMenuItem";
            учебныйПроцессToolStripMenuItem.Size = new Size(148, 24);
            учебныйПроцессToolStripMenuItem.Text = "Учебный процесс";
            // 
            // учебныеПланыToolStripMenuItem
            // 
            учебныеПланыToolStripMenuItem.Name = "учебныеПланыToolStripMenuItem";
            учебныеПланыToolStripMenuItem.Size = new Size(229, 26);
            учебныеПланыToolStripMenuItem.Text = "Учебные планы";
            // 
            // семестровыеИтогиToolStripMenuItem
            // 
            семестровыеИтогиToolStripMenuItem.Name = "семестровыеИтогиToolStripMenuItem";
            семестровыеИтогиToolStripMenuItem.Size = new Size(229, 26);
            семестровыеИтогиToolStripMenuItem.Text = "Семестровые итоги";
            // 
            // сапсапToolStripMenuItem
            // 
            сапсапToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { студентыToolStripMenuItem, группыToolStripMenuItem });
            сапсапToolStripMenuItem.Name = "сапсапToolStripMenuItem";
            сапсапToolStripMenuItem.Size = new Size(92, 24);
            сапсапToolStripMenuItem.Text = "Учащиеся";
            // 
            // студентыToolStripMenuItem
            // 
            студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            студентыToolStripMenuItem.Size = new Size(156, 26);
            студентыToolStripMenuItem.Text = "Студенты";
            // 
            // группыToolStripMenuItem
            // 
            группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            группыToolStripMenuItem.Size = new Size(156, 26);
            группыToolStripMenuItem.Text = "Группы";
            // 
            // сапапToolStripMenuItem
            // 
            сапапToolStripMenuItem.Name = "сапапToolStripMenuItem";
            сапапToolStripMenuItem.Size = new Size(132, 24);
            сапапToolStripMenuItem.Text = "Преподаватели";
            // 
            // специальностиToolStripMenuItem
            // 
            специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            специальностиToolStripMenuItem.Size = new Size(131, 24);
            специальностиToolStripMenuItem.Text = "Специальности";
            // 
            // кафедрыToolStripMenuItem
            // 
            кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            кафедрыToolStripMenuItem.Size = new Size(86, 24);
            кафедрыToolStripMenuItem.Text = "Кафедры";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dataGridView2);
            panelMain.Controls.Add(dataGridView1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 28);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1045, 589);
            panelMain.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(545, 174);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 1;
            // 
            // предметыToolStripMenuItem1
            // 
            предметыToolStripMenuItem1.Name = "предметыToolStripMenuItem1";
            предметыToolStripMenuItem1.Size = new Size(95, 24);
            предметыToolStripMenuItem1.Text = "Предметы";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 617);
            Controls.Add(panelMain);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "Form1";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem сапсапToolStripMenuItem;
        private ToolStripMenuItem сапапToolStripMenuItem;
        private ToolStripMenuItem студентыToolStripMenuItem;
        private ToolStripMenuItem группыToolStripMenuItem;
        private ToolStripMenuItem кафедрыToolStripMenuItem;
        private ToolStripMenuItem учебныйПроцессToolStripMenuItem;
        private ToolStripMenuItem учебныеПланыToolStripMenuItem;
        private ToolStripMenuItem семестровыеИтогиToolStripMenuItem;
        private ToolStripMenuItem специальностиToolStripMenuItem;
        private Panel panelMain;
        private ToolStripMenuItem предметыToolStripMenuItem1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}
