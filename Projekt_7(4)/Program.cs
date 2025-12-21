using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int sum = 0;
        sum += numbers[0, 0];
        sum += numbers[1, 1];
        sum += numbers[2, 2];

        Console.WriteLine("Sum of diagonal elements: " + sum);
    }
}