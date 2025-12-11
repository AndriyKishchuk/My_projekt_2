using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of Fibonacci");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.WriteLine(a + " " + b + " ");
        for (int i = 3; i<=n; i++)
        {
            int c = a + b;
            Console.WriteLine(c + " ");
            a = b;
            b = c;

        }
    }
}