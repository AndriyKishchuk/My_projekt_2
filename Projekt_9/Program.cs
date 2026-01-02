using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Вітаємо Вас у грі Шибениця!! Спробуйте вгадати слово!");
        string wordToGuess = "ПРОГРАМУВАННЯ";
        char[] Letters = new char[wordToGuess.Length];
        int maxAttemps = 6;
        bool isWordGuessed = false;

        for (int i = 0; i < Letters.Length; i++)
        {
            Letters[i] = '_';
        }
        Console.WriteLine($"Кількість літер у слові:{wordToGuess.Length}");

        while (!isWordGuessed)
        {
            Console.WriteLine($"Кількість можливих невірних спроб:{maxAttemps}");
            Console.WriteLine("Введіть вашу першу літеру:");
            char userGuess = Console.ReadLine().ToUpper()[0];
            int[] index = new int[wordToGuess.Length];
            bool letterFound = false;
            int indexCounter = 0;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == userGuess)
                {
                    Letters[i] = userGuess;
                    letterFound = true;
                    index[indexCounter] = i;
                    indexCounter++;
                }
            }
            if (letterFound)
            {
                for (int i = 0; i < indexCounter; i++)
                {
                    Console.WriteLine($"Ви вгадали літеру! Індекс: {index[i]}");
                  
                }
            }
            else
            {
                maxAttemps--;
                Console.WriteLine("Літера не знайдена у слові.");
            }
            if (!Letters.Contains('_'))
            {
                isWordGuessed = true;
                Console.WriteLine($"Вітаємо! Ви вгадали слово: {wordToGuess}");
            }
            else if (maxAttemps == 0)
            {
                Console.WriteLine($"Ви програли! Загадане слово було: {wordToGuess}");
                break;
            }
        }

    }
}