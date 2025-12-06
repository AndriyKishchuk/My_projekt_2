using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number 1:");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number 2:");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please select action: +; -; /; *; ");
        string action = Console.ReadLine();
        switch (action)
        {
            case "+":
                Console.WriteLine($"Result is {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Result is {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Result is {num1 * num2}");
                break;
            case "/":
                if (num2 != 0)
                {
                    Console.WriteLine($"Result is {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid action selected.");
                break;
        }
    }
}