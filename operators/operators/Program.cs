using System;

class Operators
{
    static void Main()
    {
        int a = 10, b = 5;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");
        Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine($"Is {a} equal to {b}? {a == b}");
        Console.WriteLine($"Is {a} not equal to {b}? {a != b}");
        Console.WriteLine($"Is {a} greater than {b}? {a > b}");
        Console.WriteLine($"Is {a} less than {b}? {a < b}");
        Console.WriteLine("\nLogical Operators:");
        bool x = true, y = false;
        Console.WriteLine($"x AND y: {x && y}");
        Console.WriteLine($"x OR y: {x || y}");
        Console.WriteLine($"NOT x: {!x}");
        Console.WriteLine("\nAssignment Operators:");
        int c = a;
        c += b; 
        Console.WriteLine($"c += b: {c}");
        Console.WriteLine("\nUnary Operators:");
        int d = 5;
        Console.WriteLine($"Increment d: {++d}"); 
        Console.WriteLine($"Decrement d: {--d}"); 
    }
}