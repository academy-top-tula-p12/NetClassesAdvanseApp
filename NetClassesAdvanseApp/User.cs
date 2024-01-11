using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    class UserClass
    {
        public string? Name { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    struct UserStruct
    {
        public string? Name { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    record UserRecord
    {
        public string? Name { init; get; }
        public int Age { init; get; }

        public UserRecord(string? name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }




    record UserPos(string Name, int Age);





    record struct UserRecordStruct
    {
        public string? Name { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
