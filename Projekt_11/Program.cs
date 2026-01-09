using System;
class Program
{
    static void Main(string[] args)
    {
        string[] do_list = new string[0];
        while (true)
        {
            
            Console.WriteLine("1.Add case");
            Console.WriteLine("2.View cases");
            Console.WriteLine("3.Mark as completed");
            Console.WriteLine("4.Remove case");
            Console.WriteLine("5.Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Add_to_list(ref do_list);
                    break;
                case "2":
                    View_list(do_list);
                    break;
                case "3":
                    Mark_as_completed(ref do_list);
                    break;
                case "4":
                    Remove_from_list(ref do_list);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    break;
            }
        }

    }

    static void Add_to_list(ref string[] do_list)
    {
        string[] new_list = new string[do_list.Length + 1];
        Console.WriteLine("Enter the case to add:");
        string new_case = Console.ReadLine();
        for (int i = 0; i < do_list.Length; i++)
        {
            new_list[i] = do_list[i];
        }
        new_list[do_list.Length] = new_case;
        do_list = new_list;
    }

    static void View_list(string[] do_list)
    {
        if (do_list.Length == 0)
        {
            Console.WriteLine("The to-do list is empty.");
        }
        else
        {
            for (int i = 0; i < do_list.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{do_list[i]}\n");
            }
        }
        
    }
    static void Mark_as_completed(ref string[] do_list)
    {
        View_list(do_list);
        Console.WriteLine("Enter the number of the case to mark as completed:");
        int index = int.Parse(Console.ReadLine());

        do_list[index - 1] = do_list[index - 1] + " X";
    }
    static void Remove_from_list(ref string[] do_list)
    {
        View_list(do_list);
        Console.WriteLine("Enter the number of the case to remove:");
        int index = int.Parse(Console.ReadLine());

        string[] new_list = new string[do_list.Length - 1];
        for (int i = 0; i < do_list.Length; i++)
        {
            if (i < index - 1)
            {
                new_list[i] = do_list[i];
            }
            else if (i > index - 1)
            {
                new_list[i - 1] = do_list[i];
            }
        }
        do_list = new_list;
    }
}