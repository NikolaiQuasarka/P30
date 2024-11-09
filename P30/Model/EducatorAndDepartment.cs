using P30.Model;
using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class EducatorAndDepartment
{
    public int EducatorId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Educator Educator { get; set; } = null!;
}
