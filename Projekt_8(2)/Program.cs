using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string sentece = "Hello,        World!";
        StringBuilder result = new StringBuilder();
        foreach (char c in sentece)
        {
            if (c != ' ')
            {
                result.Append(c);
            }
        }
        Console.WriteLine(result);
    }
}