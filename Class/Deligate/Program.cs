//delegates is a type safe referance to a mathod it means delegate can store address of methopd and call it later
//delgate is method that point a function
//where we use event handling:--- this used for callback metods
//two types of delegates 1. single cast delegate 2..multi cast delegates

//single cast delegates------->

using System;

internal class Program
{
    public void F1()
    {
    
        Console.WriteLine("Hello");
    }

    public void F2()
    {

        Console.WriteLine("Hi");
    }

    public void F3()
    {

        Console.WriteLine("Dear");
    }

    public delegate void myDel();
    static void Main()
    {
        Program p = new Program();
        myDel del = new myDel(p.F1);
        del -= p.F2;
        del += p.F3;

        del();
    }
}


 