using System;
class Program
{
    static void Main(string[] args)
    {
      // Завдання 1
        Console.Write("How many employers do you have - ");
        int num_employee = Convert.ToInt32(Console.ReadLine());
        double average = 0;
        double sum = 0;
        for (int i = 0; i < num_employee; i++)
        {
            Console.WriteLine("How much salary do you have for month?");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{i + 1}-{salary}");
            sum += salary;


        }
        average = sum / num_employee;
        Console.WriteLine($"Average salary is: {average}");
    }
}
