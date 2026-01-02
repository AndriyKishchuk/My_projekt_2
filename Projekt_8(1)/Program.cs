using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Text raport");
        StringBuilder dateofWork = new StringBuilder();
        StringBuilder listofwork = new StringBuilder();
        while (true)
        {
            Console.WriteLine("Enter work done:");
            string workInput = Console.ReadLine();
            Console.WriteLine("Enter date of work:");
            string dateInput = Console.ReadLine();
           
            if(string.IsNullOrEmpty(dateInput) && string.IsNullOrEmpty(workInput))
            {
                break;
            }
            dateofWork.AppendLine(dateInput);
            listofwork.AppendLine(workInput);
        }

        Console.WriteLine($"List of work:\n{listofwork} \ndate of doing:\n{dateofWork}");



    }
}