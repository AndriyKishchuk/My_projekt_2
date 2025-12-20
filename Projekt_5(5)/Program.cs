using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers days: ");
        int days = int.Parse(Console.ReadLine());

        DayOfWeek day = (DayOfWeek)((days+1) % 7);
        Console.WriteLine("Day of the week: " + day);
    }
}