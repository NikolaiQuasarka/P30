using P30.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30.ModelView
{
    internal class DepartmentModelView: ModelViewBase<Department>
    {
        public DepartmentModelView()
        {
            DepartmentName = "";
        }
        public string DepartmentName { get; set; }
        protected override Department CreateNewEntity()
        {
            var department = new Department()
            {
                DepartmentName = this.DepartmentName
            };
            return department;
        }
    }
}
