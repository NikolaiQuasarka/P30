using P30.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30.Models
{
    internal class Student: ModelBase
    {
        private int id;
        private string name;
        private int age;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Name { 
            get
            {
                return name;
            } 
            set
            { 
                name = value;
                OnPropertyChanged();
            } 
        }
        public int Age { get
            { 
                return age;
            }
            set
            { 
                age = value;
                OnPropertyChanged();
            } 
        }

        public Student(int id, string name, int age) { 
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
