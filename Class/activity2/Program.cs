/*2.Deployment of.NET Application(with Explanation)

What is Deployment?
Deployment means making the application available to users after development.

Steps
Build → Build Solution
Right click project → Publish
Choose publish method (Folder / IIS)
Publish

Explanation
Build converts code into executable files
Publish copies required files to deployment location
 Use: Sharing application with users  */

/* 
 3. Exception Handling (with Explanation)
What is Exception Handling?
It is a technique to handle runtime errors and prevent program crash.*/
//try
//{
//    int x = 10;
//    int y = 0;
//    int z = x / y;
//}
//catch (Exception e)
//{
//    Console.WriteLine("Error occurred: " + e.Message);
//}
//finally
//{
//    Console.WriteLine("Program Ended");
//}
/* Explanation

try → risky code

catch → handles error

finally → always executes

 Use: Error handling & stability */

/* 4. Class to Class & Method Communication
 Class to class communication means one class accessing the methods or data of another class using an object or static members.
  It is used to divide large programs into small modules.
 */
//Method 1: Using Object (Most Common)

/* class ClassA
{
   public void ShowMessage()
   {
       Console.WriteLine("Method of ClassA called");
   }
}

class ClassB
{
   static void Main()
   {
       ClassA obj = new ClassA(); // object creation
       obj.ShowMessage();         // method call
   }
}*/

//Explanation

//ClassA contains a method ShowMessage()

//ClassB creates an object of ClassA

//Method of ClassA is accessed using object

//This is class to class communication

/*Method Communication 
Method communication means one method calling another method to pass data or get a result.
In simple words:
Methods talk to each other by sending values and receiving results.

Why do we need method communication?
To reuse code
To divide logic into small parts
To make programs easy to understand
To follow OOP principles

How does method communication happen?
Method communication happens using:
Method calling
Parameters
Return values
*/
//Example 1: Method calling method (Same class)

/* class Demo
{
    public void Show()
    {
        Print(); // calling another method
    }

    public void Print()
    {
        Console.WriteLine("Method communication example");
    }

    static void Main()
    {
        Demo d = new Demo();
        d.Show();
        Console.ReadLine();
    }
}*/

//Explanation:
//Show() calls Print()
//Both methods communicate within the same class

//Example 2: Method communication using parameters
/*class MathOp
{
    public void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }
}

class Test
{
    static void Main()
    {
        MathOp m = new MathOp();
        m.Add(10, 20); // passing values
        Console.ReadLine();
    }
}*/

//Explanation:
//Values are passed from one method to another
//This is method communication using parameters

//Example 3: Method communication using return value
/*class Calculator
{
    public int Multiply(int x, int y)
    {
        return x * y; // return result
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        int result = c.Multiply(5, 4); // receiving result
        Console.WriteLine("Result = " + result);
        Console.ReadLine();
    }
}*/


//Explanation:
//One method returns data
//Another method receives and uses it

/* 5. Communication Between Class and Object
What is Communication Between Class and Object?
Communication between class and object means accessing the members (methods and variables) of a class using an object.
In simple words:
Class defines behavior, object uses that behavior.*/
/*

class Employee
{
    public void Show()
    {
        Console.WriteLine("Employee Details");
    }
}

class Test
{
    static void Main()
    {
        Employee e = new Employee();
        e.Show();
    }
}*/
/*6.Code Reusability(with Explanation)
What is Code Reusability ?
Using the same code multiple times without rewriting.*/
class Parent
{
    public void Print()
    {
        Console.WriteLine("Reusable Code");
    }
}

class Child : Parent
{
    static void Main()
    {
        Child c = new Child();
        c.Print();
    }
}
//Explanation
//Child class inherits Parent
//Parent method reused

/* 7. In-Built Packages in .NET
What are Packages?
Namespaces containing predefined classes and methods

Common Namespaces
Namespace	             Purpose
System	                Base classes
System.IO	            File handling
System.Data	              Database
System.Windows.Forms	  UI
 */

//8.DDL in .NET / C# (with Explanation)
//What is DDL?
//DDL commands define database structure

//CREATE TABLE Student(Id INT PRIMARY KEY,Name VARCHAR(50));

//Explanation

//CREATE → creates table
//ALTER → modifies table
//DROP → deletes table
// Used with SQL Server + ADO.NET

/*9.C# + ADO.NET Connectivity (with Explanation)
What is ADO.NET ?
ADO.NET is a.NET library used to connect C# applications to databases (like SQL Server).
It allows you to send SQL queries, retrieve data, and update the database.*/
