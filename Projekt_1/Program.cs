using System;

class Program
{
    static void Main(string[] args)
    {
        string? name;
        string? product;
        decimal price;
        string? adreess;
        int adressNumber;
        for (int i = 1; i <= 3; i++)
        {

            Console.WriteLine("Enter name of client:");
            name = Console.ReadLine();

            Console.WriteLine("Enter product:");
            product = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter adress:");
            adreess = Console.ReadLine();
            Console.WriteLine("Enter adressNumber:");
            adressNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Order No {i}");
            Console.WriteLine($"Client: {name}");
            Console.WriteLine($"Product: {product}, price {price} EUR.");
            Console.WriteLine($"Adress:{adreess}, {adressNumber}.");
            Console.WriteLine();




        }
    }
}