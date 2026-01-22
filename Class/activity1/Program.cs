using System;
//variable declaration
//class variableDeclaration {
//    static void Main() {
//        //int age = 12;
//        //string name = "divya";
//        //float marks = 90.0f;
//        //Console.WriteLine("NAME: " + name);
//        //Console.WriteLine("AGE: " + age);
//        //Console.WriteLine("marks :" + marks);
//    }
//}

//User Input
//class UserInput
//{
//    static void Main()
//    {
//        string name;
//        int age;

//        Console.WriteLine("Enter the name:");
//        name = Console.ReadLine();

//        Console.WriteLine("Enter the age:");
//        //age = int.Parse(Console.ReadLine());
//        age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("\nName:"+name);
//        Console.WriteLine("Age:" + age);
//    }
//}

//TypeCasting
//a)implicit typecasting
//class implicitTypecasting
//{
//    static void Main()
//    {
//        int num = 10;
//        double result = num; //int into double
//        Console.WriteLine("Integer value:" + num);
//        Console.WriteLine("Double value:" + result);

//    }
//}

//b)explicit Typecasting
//class ExplicitTypecasting
//{
//    static void Main()
//    {
//        double num = 10.70;
//        int result = (int)num; //double to int
//        Console.WriteLine(num);
//        Console.WriteLine(result);

//    }
//}

//c)typecasting using convert class
//class ConvertTypecasting
//{
//    static void Main()
//    {
//        String number = "25";
//        int result = Convert.ToInt32(number);
//        Console.WriteLine("String value:"+ number);
//        Console.WriteLine("Converted value:"+result);
//    }
//}

//typecasting using parse
//class ParseTypecasting
//{
//    static void Main()
//    {
//        String value = "45.90";
//        double num = double.Parse(value);
//        Console.WriteLine("string value:"+value);
//        Console.WriteLine("Parsed Double value:" + num);
//    }
//}

//IF-ELSE statement
//class IfElse
//{
//    static void Main()
//    {
//        int number = 10;

//        if (number > 0)
//        {
//            Console.WriteLine("Number is Positive");
//        }
//        else
//            Console.WriteLine("Number is Negative");
//    }
//}

//For Loop
//class Forloop
//{
//    static void Main()
//    {
//        Console.WriteLine("Number From 1 to 10 :");
//        for(int i = 0; i<=10; i++)
//        {
//            Console.WriteLine(i);
//        }

//    }
//}

//Odd-Even
//class OddEven
//{
//    static void Main()
//    {
//        int num;
//        Console.Write("Enter the number:");
//        num = int .Parse(Console.ReadLine());
//        if(num % 2 == 0)
//        {
//            Console.WriteLine("Number is Even");
//        }
//        else
//        {
//            Console.WriteLine("Number is odd");
//        }
//    }
//}

//Marks check
//class MarkCheck
//{
//    static void Main()
//    {
//        double marks;
//        Console.WriteLine("Enter the marks:");
//        marks = double.Parse(Console.ReadLine());
//        if (marks >= 60)
//        {
//            Console.WriteLine("Result: Pass");

//        }
//        else
//            Console.WriteLine("Result: Fail");
//    }
//}

//Function
//class Funstion
//{
//    static void DisplayMessage()
//    {
//        Console.WriteLine("This is a C#");
//    }
//    static void Main()
//    {
//        DisplayMessage();
//    }
//}

//Arithmetic Operations
//class Arithmatic
//{
//    static void Main()
//    {
//        int a = 20;
//        int b = 2;

//        Console.WriteLine("Addtion:" + (a + b));
//        Console.WriteLine("Suntraction:" + (a - b));
//        Console.WriteLine("Multiplication:" + (a * b));
//        Console.WriteLine("Division:" + (a / b));
//        Console.WriteLine("Mod:" + (a % b));


//    }
//}

//Comaprision
class Compare
{
    static void Main()
    {
        int x = 10;
        int y = 20;

        Console.WriteLine("x > y:" + (x > y));
        Console.WriteLine("x < y:" + (x < y));
        Console.WriteLine("x >= y:" + (x >= y));
        Console.WriteLine("x <= y:" + (x <= y));
        Console.WriteLine("x == y:" + (x == y));
        Console.WriteLine("x != y:" + (x != y));
    }
}