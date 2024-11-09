using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class Speciality
{
    public int SpecialityId { get; set; }

    public string SpecialityName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public byte SpecialityStudyYears { get; set; }
}
