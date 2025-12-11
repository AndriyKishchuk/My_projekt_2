using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your hours for work day");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your rate per hour");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your total pay is: " + (hours * rate));
    }
}