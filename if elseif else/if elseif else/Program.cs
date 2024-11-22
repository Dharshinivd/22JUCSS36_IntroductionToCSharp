using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age=int.Parse(Console.ReadLine());
        if (age < 13)
        {
            Console.WriteLine("You are a child.");
        }
        else if(age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are an adult.");
        }


    }
}
    