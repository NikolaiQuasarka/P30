using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P30
{
    public partial class ConnetcionForm : Form
    {
        public ConnetcionForm()
        {
            InitializeComponent();

            comboBoxName.DataBindings.Add(new Binding("ValueMember", this, "HostName", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxLogin.DataBindings.Add(new Binding("Text", this, "Login", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxPassword.DataBindings.Add(new Binding("Text", this, "Password", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        public string HostName { get;  }
        public string Login { get; }
        public string Password { get; }

        public bool TryConnection()
        {
            return true;
        }
    }
}
