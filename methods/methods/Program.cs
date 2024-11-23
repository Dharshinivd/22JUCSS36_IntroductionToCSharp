using System;
class Method
{
    static void MyMethod()
    {
        Console.WriteLine("It's Executed.");
    }
    static void MyName()
    {
        Console.WriteLine("Another Example.");
        int i = 0;
        while (i<5)
        {
           Console.WriteLine( i);i++;
        }
    }
    static void Main(string[] args)
    {
        MyMethod();
        MyName();
    }
}