using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class Educator
{
    public int EducatorId { get; set; }

    public string EducatorFullname { get; set; } = null!;

    public byte[] EducatorImg { get; set; } = null!;

    public string EducatorPhoneNumber { get; set; } = null!;

    public virtual ICollection<EducationAssignment> EducationAssignments { get; set; } = new List<EducationAssignment>();
}
