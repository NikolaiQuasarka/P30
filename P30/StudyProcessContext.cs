using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using P30.Model;

namespace P30;

public partial class StudyProcessContext : DbContext
{
    public StudyProcessContext()
    {
    }

    public StudyProcessContext(DbContextOptions<StudyProcessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<EducationAssignment> EducationAssignments { get; set; }

    public virtual DbSet<Educator> Educators { get; set; }

    public virtual DbSet<EducatorAndDepartment> EducatorAndDepartments { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Performance> Performances { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudyGroup> StudyGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=study_process;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__C22324220B263553");

            entity.ToTable("Department");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("department_name");
        });

        modelBuilder.Entity<EducationAssignment>(entity =>
        {
            entity.HasKey(e => e.EAssignmentId).HasName("PK__Educatio__DB1AC702873BDBE7");

            entity.ToTable("EducationAssignment");

            entity.Property(e => e.EAssignmentId).HasColumnName("eAssignment_id");
            entity.Property(e => e.EAssignmentLabs).HasColumnName("eAssignment_labs");
            entity.Property(e => e.EAssignmentLectures).HasColumnName("eAssignment_lectures");
            entity.Property(e => e.EAssignmentPractices).HasColumnName("eAssignment_practices");
            entity.Property(e => e.EducatorId).HasColumnName("educator_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.StudyGroupId).HasColumnName("studyGroup_id");

            entity.HasOne(d => d.Educator).WithMany(p => p.EducationAssignments)
                .HasForeignKey(d => d.EducatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Education__educa__34C8D9D1");

            entity.HasOne(d => d.Item).WithMany(p => p.EducationAssignments)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Education__item___35BCFE0A");

            entity.HasOne(d => d.StudyGroup).WithMany(p => p.EducationAssignments)
                .HasForeignKey(d => d.StudyGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Education__study__33D4B598");
        });

        modelBuilder.Entity<Educator>(entity =>
        {
            entity.HasKey(e => e.EducatorId).HasName("PK__Educator__5C2B47CEB72978D4");

            entity.ToTable("Educator");

            entity.Property(e => e.EducatorId).HasColumnName("educator_id");
            entity.Property(e => e.EducatorFullname)
                .HasMaxLength(30)
                .HasColumnName("educator_fullname");
            entity.Property(e => e.EducatorImg).HasColumnName("educator_img");
            entity.Property(e => e.EducatorPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("educator_phoneNumber");
        });

        modelBuilder.Entity<EducatorAndDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EducatorAndDepartment");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.EducatorId).HasColumnName("educator_id");

            entity.HasOne(d => d.Department).WithMany()
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EducatorA__depar__2F10007B");

            entity.HasOne(d => d.Educator).WithMany()
                .HasForeignKey(d => d.EducatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EducatorA__educa__2E1BDC42");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__Item__52020FDD56718E1F");

            entity.ToTable("Item");

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemName)
                .HasMaxLength(30)
                .HasColumnName("item_name");
        });

        modelBuilder.Entity<Performance>(entity =>
        {
            entity.HasKey(e => e.PerformanceId).HasName("PK__Performa__8C2C0F60CFCAA8E6");

            entity.ToTable("Performance");

            entity.Property(e => e.PerformanceId).HasColumnName("performance_id");
            entity.Property(e => e.EAssignmentId).HasColumnName("eAssignment_id");
            entity.Property(e => e.PerformanceMark).HasColumnName("performance_mark");
            entity.Property(e => e.PerformanceSemester).HasColumnName("performance_semester");
            entity.Property(e => e.PerformanceType)
                .HasMaxLength(30)
                .HasColumnName("performance_type");
            entity.Property(e => e.PerformanceYear).HasColumnName("performance_year");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.EAssignment).WithMany(p => p.Performances)
                .HasForeignKey(d => d.EAssignmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Performan__eAssi__398D8EEE");

            entity.HasOne(d => d.Student).WithMany(p => p.Performances)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Performan__stude__38996AB5");
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.SpecialityId).HasName("PK__Speciali__E82ED62086E0FE16");

            entity.ToTable("Speciality");

            entity.Property(e => e.SpecialityId).HasColumnName("speciality_id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.SpecialityName)
                .HasMaxLength(30)
                .HasColumnName("speciality_name");
            entity.Property(e => e.SpecialityStudyYears).HasColumnName("speciality_studyYears");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__2A33069AD9C8F252");

            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.StudentFullname)
                .HasMaxLength(30)
                .HasColumnName("student_fullname");
            entity.Property(e => e.StudentPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("student_phoneNumber");
            entity.Property(e => e.StudyGroupId).HasColumnName("studyGroup_id");
        });

        modelBuilder.Entity<StudyGroup>(entity =>
        {
            entity.HasKey(e => e.StudyGroupId).HasName("PK__StudyGro__58991610412EF856");

            entity.ToTable("StudyGroup");

            entity.HasIndex(e => e.StudyGroupName, "UQ__StudyGro__DAE696AE50285442").IsUnique();

            entity.Property(e => e.StudyGroupId).HasColumnName("studyGroup_id");
            entity.Property(e => e.SpecialityId).HasColumnName("speciality_id");
            entity.Property(e => e.StudyGroupName)
                .HasMaxLength(10)
                .HasColumnName("studyGroup_name");
            entity.Property(e => e.StudyGroupYear).HasColumnName("studyGroup_year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
