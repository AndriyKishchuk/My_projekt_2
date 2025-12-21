using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 11, 2, 33, 54 };
        int max = int.MinValue;
        int secondMax = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                secondMax = max;
                max = numbers[i];
            }
            else if (numbers[i] > secondMax && numbers[i] != max)
            {
                secondMax = numbers[i];
            }
        }
        Console.WriteLine("The largest number is: " + max);
        Console.WriteLine("The second largest number is: " + secondMax);
    }
}
