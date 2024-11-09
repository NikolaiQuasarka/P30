using P30.Model;
using P30.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P30.View.DataWork
{
    public partial class DepartmentView : Form
    {
        public DepartmentView()
        {
            InitializeComponent();

            departmentModelView = new DepartmentModelView();
            dataGridView1.DataBindings.Add(new Binding("DataSource", departmentModelView, "Entities"));
            textBoxNewName.DataBindings.Add(new Binding("Text", departmentModelView, "DepartmentNewName"));
            textBoxSelectedName.DataBindings.Add(new Binding("Text", departmentModelView, "DepartmentUpdName"));
        }
        private DepartmentModelView departmentModelView;
        public Department? SelectedDepartment
        {
            get
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    return dataGridView1.SelectedRows[0].DataBoundItem as Department;
                else return null;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            departmentModelView.Add();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            departmentModelView.SelectedEntity = SelectedDepartment;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            departmentModelView.Remove();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(SelectedDepartment != null)
            departmentModelView.Update();
        }
    }
}
