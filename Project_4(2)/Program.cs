using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= rows; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}
