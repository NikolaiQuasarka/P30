using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class Item
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public virtual ICollection<EducationAssignment> EducationAssignments { get; set; } = new List<EducationAssignment>();
}
