using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchApp
{
    class Student
    {
        public string School { get; set; }
        [IgnoreSearch]
        public string Grade { get; set; }
        public Student(string school, string grade) 
        {
            School = school;
            Grade = grade;
        }
    }
}
