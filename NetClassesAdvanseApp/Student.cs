using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    /*
    return_type this [type index]
    {
        set{ ... }
        get{ ... }
    }
    */

    class Student
    {
        public string? Name { set; get; }
        public int Age { set; get; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    class Group
    {
        List<Student> students = new();

        string title = "";
        string depart = "";

        public void Add(Student student)
        {
            students.Add(student);
        }

        public int Count
        {
            get => students.Count;
        }

        public Student this[int index]
        {
            get
            {
                if (index >= 0 && index < students.Count)
                    return students[index];
                else
                    return students[0];
            }
            set
            {
                if(index >= 0 && index < students.Count)
                    students[index] = value;
                
            }
        }

        public string this[string prop]
        {
            get
            {
                if (prop == "title")
                    return title;
                else
                    return depart;
            }

            set
            {
                if (prop == "title")
                    title = value;
                else
                    depart = value;
            }
        }
    }

    class User
    {
        string name = "";
        string email = "";
        string address = "";

        public string this[string prop]
        {
            get
            {
                return prop switch
                {
                    "name" => name,
                    "email" => email,
                    "address" => address,
                    _ => throw new Exception($"Unknown property {prop}")
                };
            }
            set
            {
                switch(prop)
                {
                    case "name": name = value; break;
                    case "email": email = value; break;
                    case "address": address = value; break;
                    default:
                        throw new Exception($"Unknown property {prop}");
                }
            }
        }

        public override string ToString()
        {
            return $"{name}, {email}, {address}";
        }
    }

}
