using System;
class StringProgram
{
    static void Main()
    {
        string str = "Veera dharshini";
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Upper Case: " + str.ToUpper());
        Console.WriteLine("Lower Case: " + str.ToLower());
        Console.WriteLine("Length: " + str.Length);
        Console.WriteLine("Contains 'Dharshini': " + str.Contains("Dharshini"));
        Console.WriteLine("IndexOf 'Veera': " + str.IndexOf("veera"));
        Console.WriteLine("Substring 6: " + str.Substring(6));
        Console.WriteLine("Replace 'dharshini' with 'harshini': " + str.Replace("dharshini", "harshini"));
        Console.WriteLine("Trim: " + str.Trim());
        Console.WriteLine("Split: " + str.Split(' ')[0]);
    }
}
