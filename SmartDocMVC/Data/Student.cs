using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartDocMVC.Data
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public int Age { get; set; }

        public Student()
        {

        }

        public Student(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }
    }
}