using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    internal partial class Employee
    {
        public int Age { set; get; }

        public Employee(string name, int age) : this(name)
        {
            Age = age;
        }

        partial void AddYear()
        {
            Age++;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
