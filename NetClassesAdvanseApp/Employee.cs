using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    internal partial class Employee
    {
        public string? Name { set; get; }

        public Employee(string name) 
        { 
            this.Name = name;
        }

        partial void AddYear();
    }
}
