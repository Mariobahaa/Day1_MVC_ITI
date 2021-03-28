using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day1
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
            ;
        }

        public Student(int id, string name, int age) 
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }
}