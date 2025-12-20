using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[,] numbers = new int[5, 5];
        int max = int.MinValue;
        int min = int.MaxValue;
        int maxrow = 0;
        int maxcol = 0;
        int minrow = 0;
        int mincol = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                numbers[i, j] = random.Next(1, 101);
                Console.Write(numbers[i, j] + "\t");
                if (numbers[i, j] < min)
                {
                    min = numbers[i, j];
                    minrow = i;
                    mincol = j;
                }
                if (numbers[i, j] > max)
                {
                    max = numbers[i, j];
                    maxrow = i;
                    maxcol = j;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThe maximum number is: " + max);
        Console.WriteLine("The position of the maximum number is: " + maxrow + "," + maxcol);
        Console.WriteLine();
        Console.WriteLine("The minimum number is: " + min);
        Console.WriteLine("The position of the minimum number is: " + minrow + "," + mincol);
    }
}