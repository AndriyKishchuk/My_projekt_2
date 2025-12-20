using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rand = new Random();
        int[] num = new int[10];
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = rand.Next(-10, 10);
            Console.WriteLine(num[i]);
            if (i % 2 == 0)
            {
                Console.WriteLine($"Іndex {i}: {num[i]}");
            }
            sum += num[i];

        }
        if (sum < 0)
        {
            Console.WriteLine($"Sum of elements: {sum} is minus");
        }
        else
        {
            Console.WriteLine($"Sum of elements: {sum} is plus");
        }

    }
}