using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int result1 = calculator.Add(1, 2);
        Console.WriteLine("Result 1:" + result1);

        double result2 = calculator.Add(4, 5);
        Console.WriteLine("Result 2:" + result2);
    }
}
