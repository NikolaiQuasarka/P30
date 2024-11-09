using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class EducationAssignment
{
    public int EAssignmentId { get; set; }

    public int StudyGroupId { get; set; }

    public int EducatorId { get; set; }

    public int ItemId { get; set; }

    public byte EAssignmentLectures { get; set; }

    public byte EAssignmentPractices { get; set; }

    public byte EAssignmentLabs { get; set; }

    public virtual Educator Educator { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual ICollection<Performance> Performances { get; set; } = new List<Performance>();

    public virtual StudyGroup StudyGroup { get; set; } = null!;
}
