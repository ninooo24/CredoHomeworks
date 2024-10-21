using System;

class Program
{
    static char[,] board = new char[3, 3]; 
    static char currentPlayer = 'X';
    static int row, col; 
    static int movesCount = 0;

    static void Main()
    {
        CreateBoard();

        while (true) 
        {
            Console.Clear(); 
            DrawBoard(); 
            PlayerInput();
            movesCount++;   
            if (CheckWinner(board, currentPlayer))
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer} wins!"); 
                break; 
            }

            if (movesCount == 9)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("It's a draw!");
                break; 
            }

            // Switch player/ chats vkitxe :)
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }

    static void CreateBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    static void DrawBoard()
    {
        Console.WriteLine("   0   1   2"); 
        Console.WriteLine("  -----------");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " | "); 
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " | "); 
            }
            Console.WriteLine();
            Console.WriteLine("  -----------");
        }
    }

    static void PlayerInput()
    {
        bool isValidInput = false;
        while (!isValidInput)
        {
            Console.WriteLine($"Player {currentPlayer}, enter your move (row and column): ");
            try
            {
                Console.Write("Row: ");
                row = int.Parse(Console.ReadLine());

                Console.Write("Column: ");
                col = int.Parse(Console.ReadLine());

                if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer; 
                    isValidInput = true; 
                }
                else
                {
                    Console.WriteLine("Invalid move!  Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input! Please enter numbers between 0 and 2.");
            }
        }
    }
    static bool CheckWinner(char[,] board, char player)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) || 
                (board[0, i] == player && board[1, i] == player && board[2, i] == player))   
            {
                return true;
            }
        }
        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||   
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))   
        {
            return true;
        }
        return false;
    }

}
