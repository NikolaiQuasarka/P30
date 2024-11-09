using P30.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using P30.ModelView;

namespace P30.ModelViews
{
    internal class StudentsModelView : ModelViewBase<Student>
    {
        //public Student? SelectedStudent { get => Students.FirstOrDefault(s => s.Id == SelectedStudentId); }
        //public int SelectedStudentId { get; set; }
        //public BindingList<Student> Students { get; }


        //private int newId = 0; 
        //public int NewId
        //{
        //    get => newId; set { { newId = value; OnPropertyChanged(); } }
        //}

        //private string newName = ""; 
        //public string NewName 
        //{
        //    get => newName; set {  { newName = value; OnPropertyChanged(); } } 
        //}
        //private int newAge = 0; 
        //public int NewAge
        //{
        //    get => newAge; set {  { newAge = value; OnPropertyChanged(); } }
        //}
        //public void AddStudent()
        //{
        //    Student NewStudent = new Student(newId, newName, newAge);
        //    Students.Add(NewStudent);
        //    NewId = 0;
        //    NewName = "";
        //    NewAge = 0;
        //} 


        //public void Change()
        //{
        //    Students[1].Name = "New name";
        //}

        //public StudentsModelView()
        //{
        //    Students = new BindingList<Student>
        //{
        //    new  Student(1, "Tom", 45),
        //    new  Student(2, "Bob",  42),
        //    new Student(3, "Sam", 45)
        //};
        //    SelectedStudentId = 2; 
        //}

        protected override Student CreateNewEntity()
        {
            throw new NotImplementedException();
        }
    }
}
