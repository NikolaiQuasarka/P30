using System;
using System.Collections.Generic;

namespace P30.Model;

public partial class Performance
{
    public int PerformanceId { get; set; }

    public int StudentId { get; set; }

    public int EAssignmentId { get; set; }

    public bool PerformanceSemester { get; set; }

    public short PerformanceYear { get; set; }

    public string PerformanceType { get; set; } = null!;

    public byte PerformanceMark { get; set; }

    public virtual EducationAssignment EAssignment { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
