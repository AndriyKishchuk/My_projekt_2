using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number for view day of week:");
        int number = Int32.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("This is Monday");
                break;
            case 2:
                Console.WriteLine("This is Tuedsday");
                break;
            case 3:
                Console.WriteLine("This is Wednesday");
                break;
            case 4:
                Console.WriteLine("This is Thursday");
                break;
            case 5:
                Console.WriteLine("This is Friday");
                break;
            case 6:
                Console.WriteLine("This is Saturday");
                break;
            case 7:
                Console.WriteLine("This is Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
    }
}