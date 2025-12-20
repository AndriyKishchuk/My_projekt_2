using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] number = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                number[i, j] = (i + 1) * (j + 1);
                Console.Write(number[i, j ] + "\t");
            }
        }
    }
}