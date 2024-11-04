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
            var studentsAndGroups = new Forms.StudentsAndGroups();
            studentsAndGroups.ShowDialog();
        }
    }
}
