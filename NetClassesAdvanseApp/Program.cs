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


// Anonime types
/*
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

*/


// Tuples
/*

(int number, string message, double pi) tuple = (number: 100, message: "Hello", pi: 3.14);


Console.WriteLine(tuple.GetType().Name);

Console.WriteLine(tuple.message);
Console.WriteLine(tuple.pi);
Console.WriteLine(tuple.number);

int a = 100;
int b = 200;

(a, b) = (b, a);
Console.WriteLine($"{a} {b}");

var currDate = GetCurrentDate();
Console.WriteLine($"{currDate.Item1} {currDate.Item2} {currDate.Item3}");

var info = GetArrayInfo(new int[] { 21, 45, 89, 11, 28, 45, 73 });
Console.WriteLine($"Count = {info.count}, Amount = {info.amount}");

EmployeePrint(("Billy", 25));
EmployeePrint(("Helen", 19));


(int, string, int) GetCurrentDate()
{
    int day = DateTime.Now.Day;
    string month = DateTime.Now.Month.ToString();
    int year = DateTime.Now.Year;

    return (day, month, year);
}

(int count, int amount) GetArrayInfo(int[] array)
{
    var result = (count: array.Length, amount: 0);
    foreach (var item in array)
        result.amount += item;
    return result;
}

void EmployeePrint((string name, int age) emplyee)
{
    Console.WriteLine($"Name: {emplyee.name}, Age: {emplyee.age}");
}
*/


UserClass userClass1 = new() { Name = "Tommy", Age = 35 };
UserClass userClass2 = new() { Name = "Billy", Age = 28 };
UserClass userClass3 = new() { Name = "Tommy", Age = 35 };
UserClass userClass4 = userClass1;

UserStruct userStruct1 = new() { Name = "Tommy", Age = 35 };
UserStruct userStruct2 = new() { Name = "Billy", Age = 28 };
UserStruct userStruct3 = new() { Name = "Tommy", Age = 35 };
UserStruct userStruct4 = userStruct1; 

UserRecord userRecord1 = new("Tommy", 35);
UserRecord userRecord2 = new("Billy",28);
UserRecord userRecord3 = new("Tommy", 35);
UserRecord userRecord4 = userRecord1;

UserRecordStruct userRecordStruct1 = new() { Name = "Tommy", Age = 35 };
UserRecordStruct userRecordStruct2 = new() { Name = "Billy", Age = 28 };
UserRecordStruct userRecordStruct3 = new() { Name = "Tommy", Age = 35 };
UserRecordStruct userRecordStruct4 = userRecordStruct1;

UserPos pos1 = new("Jim", 45);
Console.WriteLine(pos1.Name);
//pos1.Name = "Pol";

Console.WriteLine(userClass1.Equals(userClass2));
Console.WriteLine(userClass1.Equals(userClass3));
Console.WriteLine(userClass1.Equals(userClass4));
Console.WriteLine();
Console.WriteLine(userStruct1.Equals(userStruct2));
Console.WriteLine(userStruct1.Equals(userStruct3));
Console.WriteLine(userStruct1.Equals(userStruct4));
Console.WriteLine();
Console.WriteLine(userRecord1.Equals(userRecord2));
Console.WriteLine(userRecord1.Equals(userRecord3));
Console.WriteLine(userRecord1.Equals(userRecord4));
Console.WriteLine();
Console.WriteLine(userRecordStruct1.Equals(userRecordStruct2));
Console.WriteLine(userRecordStruct1.Equals(userRecordStruct3));
Console.WriteLine(userRecordStruct1.Equals(userRecordStruct4));
Console.WriteLine();


userClass4.Name = "Leopold";
Console.WriteLine(userClass1.Name);

userStruct4.Name = "Leopold";
Console.WriteLine(userStruct1.Name);

//userRecord4.Name = "Leopold";
Console.WriteLine(userRecord1.Name);

userRecordStruct4.Name = "Leopold";
Console.WriteLine(userRecordStruct1.Name);

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