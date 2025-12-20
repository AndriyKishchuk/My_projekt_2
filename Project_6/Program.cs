using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static void Main(string[] args)
    {
        char[,] board =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        bool gameOver = false;
        char currentPlayer = 'X';
        while (!gameOver)
        {
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
                if (i < 2)
                    Console.WriteLine("---------");
            }

            Console.WriteLine($"Player {currentPlayer}, enter your move (1-9): ");
           
             if (!int.TryParse(Console.ReadLine(), out int move) || move < 1 || move > 9)
             {
                 Console.WriteLine("Invalid move. Try again.");
                 continue;
             }

            int row = (move - 1) / 3;
            int col = (move - 1) % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                continue;
            }
            board[row, col] = currentPlayer;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer ||
                   board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                {
                    gameOver = true;

                }
                if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer ||
                board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                {
                    gameOver = true;

                }
            }
            if (gameOver)
            {
                Console.Clear();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
                    if (i < 2)
                        Console.WriteLine("---------");
                }
                Console.WriteLine($"Player {currentPlayer} wins!");
            }

            bool drawn = true;
            foreach (char cell in board)
            {
                if (cell != 'X' && cell != 'O')
                {
                    drawn = false;
                }
            }
            if (drawn)
            {
                Console.Clear();
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}



