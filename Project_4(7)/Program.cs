using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter prime number:");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;

            }
          

        }
        if (isPrime)
        {
            Console.WriteLine("It is a prime number");
        }
        else
        {
            Console.WriteLine("It is not a prime number");
        }
    }
}