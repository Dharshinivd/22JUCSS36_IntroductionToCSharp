using System;

class data
{
    static void Main()
    {
        int intVar = 42;
        double doubleVar = intVar; 
        Console.WriteLine($"Implicit Conversion: int {intVar} to double {doubleVar}");

        double largeDouble = 123.45;
        int smallInt = (int)largeDouble;
        Console.WriteLine($"Explicit Conversion: double {largeDouble} to int {smallInt}");

        string str = "100";
        int strToInt = Convert.ToInt32(str);
        Console.WriteLine($"Convert String to Int: {strToInt}");  
    }
}