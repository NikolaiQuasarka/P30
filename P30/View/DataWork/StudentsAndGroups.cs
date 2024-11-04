using P30.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P30.Forms
{
    public partial class StudentsAndGroups : Form
    {
        public StudentsAndGroups()
        {
            InitializeComponent();

            studentsModelView = new StudentsModelView();

            Binding dGVBin = new Binding("DataSource", studentsModelView, "Students", false, DataSourceUpdateMode.OnPropertyChanged);
            dataGridView1.DataBindings.Add(dGVBin);

            Binding l1Bin = new Binding("Text", studentsModelView.SelectedStudent, "Name");
            label1.DataBindings.Add(l1Bin);

            Binding newId = new Binding("Value", studentsModelView, "NewId");
            newId.Format += (sender, e) =>
            {
                if (e.DesiredType == typeof(int)) { e.Value = Convert.ToInt32(e.Value); }
            };
            numericUpDown1.DataBindings.Add(newId);

            Binding newName = new Binding("Text", studentsModelView, "NewName");
            newName.Format += (sender, e) =>
            {
                if (e.DesiredType == typeof(int)) { e.Value = Convert.ToInt32(e.Value); }
            };
            textBox2.DataBindings.Add(newName);

            Binding newAge = new Binding("Value", studentsModelView, "NewAge");
            numericUpDown2.DataBindings.Add(newAge);
        }
        StudentsModelView studentsModelView;
        public void button1_Click(object sender, EventArgs e)
        {
            studentsModelView.AddStudent();
        }
    }
}
