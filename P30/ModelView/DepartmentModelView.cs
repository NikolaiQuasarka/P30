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
            DepartmentNewName = "";
        }
        public string DepartmentNewName { get; set; }
        protected override Department CreateNewEntity()
        {
            var department = new Department()
            {
                DepartmentName = this.DepartmentNewName
            };
            return department;
        }
        public string DepartmentUpdName { get; set; }
        protected override void UpdateEntity()
        {
            if (SelectedEntity != null)
            {
                SelectedEntity.DepartmentName = this.DepartmentUpdName == "" ? SelectedEntity.DepartmentName : this.DepartmentUpdName;
            }
            else throw new Exception("Не выбрана сущность");
        }
    }
}
