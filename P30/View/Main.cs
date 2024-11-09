using P30.View.DataWork;

namespace P30
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var studentsAndGroups = new Forms.StudentsAndGroupsView();
            studentsAndGroups.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var departments = new DepartmentView();
            departments.ShowDialog();
        }
    }
}
