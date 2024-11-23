using System;
class Foreach
{
    static void Main(string[] args)
    {
        string[] icecream = { "Vannilla", "Black Current", "Strwberry", "Chocolate" };
        foreach (string ice in icecream)
        {
            Console.WriteLine(ice);
        }
    }
}