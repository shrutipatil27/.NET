
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