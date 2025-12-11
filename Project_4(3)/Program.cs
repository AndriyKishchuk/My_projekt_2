using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        for (int i = 1; i < number; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                numbers[i] = i;
            }
            Console.WriteLine(numbers[i]);
        }
    }
}