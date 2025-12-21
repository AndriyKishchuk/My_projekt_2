using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int indexToRemove = 2;
        int[] newNumbers = new int[numbers.Length - 1];
        int j = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == indexToRemove)
            {
                continue;
            }
            newNumbers[j++] = numbers[i];
        }

        foreach (var number in newNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
