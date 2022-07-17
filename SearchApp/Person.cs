using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchApp
{
    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public Person(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
