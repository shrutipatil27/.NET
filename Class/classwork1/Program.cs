
//solid principles---> they helps to write clean,maintainable and scalable code
//it is object oriented design principles
//s means single responsibility principle 
//o means open/closed principle
//l means liskov substitution principle
//i means interface segregation principle
//d means dependency inversion principle

//single responsibility principle(SRP)----->
//one class should do only one job (if a class has more than one responsibility then it becomes coupled or harder to maintain)
using System.Security.Cryptography.X509Certificates;

class student
{
    public void SaveStudent()
    {
        //code to save student details in database
    }
    public void PrintReport()
    {
        //code to generate student report
    }
}

//this above is bad example of single responsibility principle because the class student has more than one responsibility

//good example of single responsibility principle
class Student
{
    public string Name { get; set; }
    class SaveStudentData
    {
        public void SaveStudent(Student std)
        {
            //code to save student details in database
        }
    }
}
class StudentReport
{
    public void PrintReport(Student std)
    {
        //code to generate student report
    }
}

//open/closed principle(OCP)----->
// class should be open for extension but closed for modification (you should be able to add new features without changing existing code)
class discount
{
    public Double Discount(string customerType)
    {
        if ()
        {
        }
        else
        {
            return 0;
        }
    }
}
//this above is bad example of open/closed principle because if we want to add new customer type we have to modify the existing code

//good example of open/closed principle

interface IDiscount
{
    getDiscount()
}
class StudentDiscount : IDiscount
{
    public getDiscount() => 10
        }
class TeacherDiscount : IDiscount
{
    public getDiscount() => 15
        }
// to add new discount type we just have to create new class that implements IDiscount interface without modifying existing code

//liskov substitution principle(LSP)----->
//child class should replace parent class without affecting the functionality of the program( if b is a child of a then we should be able to use b instead of a everywhere without breaking the code)
class Bird
{
    public void fly()
    {
        //code to fly
    }
}
class Ostrich : Bird
{
    public override void fly()
    {

    }

}
//ostirch is a bird but it cannot fly so this is bad example of liskov substitution principle

//good example of liskov substitution principle
interface IBird
{

}
interface IFlyingBird
{
    void fly();
}
class Sparrow : IFlyingBird
{
    public void fly()
    {

    }
}
class Ostrich : IBird
{

}


//I – Interface Segregation Principle (ISP)-->  “A class should not be forced to implement interfaces it does not use.”
//Instead of one big interface, create multiple small, specific interfaces.

//Bad example
interface IWorker
{
    void Work();
    void Eat();
}

class HumanWorker : IWorker
{
    public void Work()
    {
        // human working
    }

    public void Eat()
    {
        // human eating
    }
}

class RobotWorker : IWorker
{
    public void Work()
    {
        // robot working
    }

    public void Eat()
    {
        // ❌ robot does not eat
        throw new NotImplementedException();
    }
}
//Robot is forced to implement Eat() which it does not need.

//Good example
interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

class HumanWorker1 : IWork, IEat
{
    public void Work()
    {
        // human working
    }

    public void Eat()
    {
        // human eating
    }
}

class RobotWorker1 : IWork
{
    public void Work()
    {
        // robot working
    }
}
//Each class implements only what it needs, Easy to maintain and extend

//D – Dependency Inversion Principle (DIP)--> High-level modules should not depend on low-level modules.
//Both should depend on abstractions (interfaces)

//Bad example
class MySQLDatabase
{
    public void SaveData()
    {
        // save data in MySQL
    }
}

class UserService
{
    MySQLDatabase db = new MySQLDatabase();

    public void SaveUser()
    {
        db.SaveData();
    }
}
//UserService is tightly coupled to MySQLDatabase,If database changes → code must be modified

//Good example
interface IDatabase
{
    void SaveData();
}

class MySQLDatabase1 : IDatabase
{
    public void SaveData()
    {
        // save data in MySQL
    }
}

class MongoDatabase : IDatabase
{
    public void SaveData()
    {
        // save data in MongoDB
    }
}

class UserService1
{
    private IDatabase db;

    public UserService1(IDatabase database)
    {
        db = database;
    }

    public void SaveUser()
    {
        db.SaveData();
    }
}
//UserService depends on interface, not concrete class,Easy to switch DB without changing business logic

//SOLID – One-Line Revision (Very Useful for MCQs)

//S (SRP) → One class = One responsibility

//O(OCP) → Open for extension, closed for modification

//L (LSP) → Child can replace parent without breaking code

//I (ISP) → Many small interfaces > one large interface

//D(DIP) → Depend on abstractions, not concrete classes