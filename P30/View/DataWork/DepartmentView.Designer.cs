namespace P30.View.DataWork
{
    partial class DepartmentView
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
            dataGridView1 = new DataGridView();
            DepartmentId = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxSelectedName = new TextBox();
            groupBox2 = new GroupBox();
            textBoxNewName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DepartmentId, DepartmentName });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(377, 340);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // DepartmentId
            // 
            DepartmentId.DataPropertyName = "DepartmentId";
            DepartmentId.HeaderText = "Номер";
            DepartmentId.MinimumWidth = 6;
            DepartmentId.Name = "DepartmentId";
            DepartmentId.ReadOnly = true;
            DepartmentId.Visible = false;
            // 
            // DepartmentName
            // 
            DepartmentName.DataPropertyName = "DepartmentName";
            DepartmentName.HeaderText = "Название кафедры";
            DepartmentName.MinimumWidth = 6;
            DepartmentName.Name = "DepartmentName";
            DepartmentName.ReadOnly = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 102);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(140, 102);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Изменить";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 160);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSelectedName);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Location = new Point(395, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 139);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбранная кафедра";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Навзание:";
            // 
            // textBoxSelectedName
            // 
            textBoxSelectedName.Location = new Point(92, 47);
            textBoxSelectedName.Name = "textBoxSelectedName";
            textBoxSelectedName.Size = new Size(193, 27);
            textBoxSelectedName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxNewName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Location = new Point(395, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 195);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Новая кафедра";
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(92, 73);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(193, 27);
            textBoxNewName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 76);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Название";
            // 
            // DepartmentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 362);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "DepartmentView";
            Text = "Department";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DepartmentId;
        private DataGridViewTextBoxColumn DepartmentName;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxSelectedName;
        private GroupBox groupBox2;
        private TextBox textBoxNewName;
        private Label label2;
    }
}