using NetClassesAdvanseApp;

/*
string str = "Hello world";

Console.WriteLine(str.CharCount('l'));

Employee bill = new("Billy", 35);
Console.WriteLine(bill);
*/

//Fraction f1 = new(4, 5);
//Fraction f2 = new(6, 11);

//Console.WriteLine($"{f1}, {f1.Add(f2)}, {f1}");
//Console.WriteLine($"{f1}, {f1.Plus(f2)}, {f1}");
//Console.WriteLine($"{f1}, {f1 + f2}, {f1}");

//Console.WriteLine($"{f1}, {f2} :: {f1 - f2} :: {f1}, {f2}");
//Console.WriteLine($"{f1++}");
//Console.WriteLine($"{f1}");
//Console.WriteLine($"{++f1}");
//Console.WriteLine($"{f1}");

//Fraction f3 = new(6, 5);
//Money m3 = (Money)f3;
//Console.WriteLine($"{m3}");

//float x = 25.6f + f3;
//Console.WriteLine(x);



//Group group = new();
//group.Add(new("Joe", 23));
//group.Add(new("Leo", 19));
//group.Add(new("Tom", 34));
//group.Add(new("Ben", 29));
//group.Add(new("Sam", 31));

//group[-3] = new("Bill", 44);

//for(int i = 0; i < group.Count; i++)
//    Console.WriteLine(group[i]);


//User user = new();
//try
//{
//    user["name"] = "Phill";
//    user["email"] = "phill@gmail.com";
//    user["address"] = "Moscow";
//    user["age"] = "45";
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//Console.WriteLine(user);


var car = new { Title = "Volga", Number = "ac456p" };
Console.WriteLine(car.GetType().Name);

var users = new[]
{
    new {Name = "Bobby", Age = 45},
    new {Name = "Sammy", Age = 32},
    new {Name = "Tommy", Age = 28},
};

foreach(var user in users)
    Console.WriteLine($"Type: {user.GetType().Name}, Name: {user.Name}, Age: {user.Age}");







//public static class StringExtension
//{
//    public static int CharCount(this string s, char symbol)
//    {
//        int count = 0;
//        foreach(var ch in s)
//            if(ch == symbol)
//                count++;
//        return count;
//    }
//}