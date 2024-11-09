using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class Department: ModelBase
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
