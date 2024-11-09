using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class StudyGroup
{
    public int StudyGroupId { get; set; }

    public string StudyGroupName { get; set; } = null!;

    public int SpecialityId { get; set; }

    public short StudyGroupYear { get; set; }

    public virtual ICollection<EducationAssignment> EducationAssignments { get; set; } = new List<EducationAssignment>();
}
