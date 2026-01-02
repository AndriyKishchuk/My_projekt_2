using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter your surname:");
        string? surname = Console.ReadLine();
        if (name[0] == surname[0])
        {
            Console.WriteLine("First letter surname and name are the same");
        }
        else
        {
            Console.WriteLine("First letter surname and name are different");
        }
        Console.WriteLine(name + " " + surname);
    }
}
