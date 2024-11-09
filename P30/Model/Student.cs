using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace P30.Model;

public partial class Student: ModelBase
{
    public int StudentId { get; set; }

    public string StudentFullname { get; set; } = null!;

    public int StudyGroupId { get; set; }

    public string StudentPhoneNumber { get; set; } = null!;

    public virtual ICollection<Performance> Performances { get; set; } = new List<Performance>();
}
