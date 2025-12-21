using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] numbers =
        {
            { 1, 24, 3 },
            { 42, 56, 6 },
            { 73, 8, 95 }
        };
        int rows = numbers.GetLength(0);
        int cols = numbers.GetLength(1);
        int total = rows * cols;

        for (int i = 0; i < total - 1; i++)
        {
            for (int j = 0; j < total - 1 - i; j++)
            {
                int row1 = j / cols;
                int col1 = j % cols;
                int row2 = (j + 1) / cols;
                int col2 = (j + 1) % cols;
                if (numbers[row1, col1] > numbers[row2, col2])
                {
                    int temp = numbers[row1, col1];
                    numbers[row1, col1] = numbers[row2, col2];
                    numbers[row2, col2] = temp;
                }

            }
        }
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }



    }
}