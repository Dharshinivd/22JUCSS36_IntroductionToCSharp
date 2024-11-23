using System;

class Switch
{
    static void Main(string[] args)
    {
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("It's Sunday!");
                break;
            case 2:
                Console.WriteLine("It's Monday!");
                break;
            case 3:
                Console.WriteLine("It's Tuesday");
                break;
            case 4:
                Console.WriteLine("It's Wednesday");
                break;
            case 5:
                Console.WriteLine("It's Thursday");
                break;
        }
    }
}
