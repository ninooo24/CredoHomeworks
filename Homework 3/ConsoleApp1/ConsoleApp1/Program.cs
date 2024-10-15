using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Task 1");
        Console.WriteLine();

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);

        Console.WriteLine("Number of vowels: " + vowelCount);
        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Task 2");
        Console.WriteLine();

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] multiplicationTable = new int[10];

        for (int i = 0; i < 10; i++)
        {
            multiplicationTable[i] = number * (i + 1);
        }

        Console.WriteLine($"Multiplication Table of {number}:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{number} x {i + 1} = {multiplicationTable[i]}");
        }

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Task 3");
        Console.WriteLine();
        int[,] firstMatrix = new int[3, 3];
        int[,] secondMatrix = new int[3, 3];
        int[,] sumMatrix = new int[3, 3];

        // Populate the first matrix
        Console.WriteLine("Please enter the elements of the first matrix (3 rows of 3 numbers separated by spaces):");
        for (int i = 0; i < 3; i++)
        {
            string[] matrixInput = Console.ReadLine().Split(' ');
            for (int j = 0; j < 3; j++)
            {
                firstMatrix[i, j] = int.Parse(matrixInput[j]);
            }
        }

        // Populate the second matrix
        Console.WriteLine("Please enter the elements of the second matrix (3 rows of 3 numbers separated by spaces):");
        for (int i = 0; i < 3; i++)
        {
            string[] matrixInput = Console.ReadLine().Split(' ');
            for (int j = 0; j < 3; j++)
            {
                secondMatrix[i, j] = int.Parse(matrixInput[j]);
            }
        }

        // Add the two matrices
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                sumMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }

        // Display the result
        Console.WriteLine("The resulting matrix after addition is:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(sumMatrix[i, j] + "\t");
            }
            Console.WriteLine(); // New line after each row
        }

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Task 4");
        Console.WriteLine();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());
                double result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            else if (option == "2")
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());
                double result = num1 - num2;
                Console.WriteLine("Result: " + result);
            }
            else if (option == "3")
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());
                double result = num1 * num2;
                Console.WriteLine("Result: " + result);
            }
            else if (option == "4")
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    double result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
            }
            else if (option == "5")
            {
                isRunning = false;
                Console.WriteLine("Exiting the calculator. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            Console.WriteLine();
        }
    }


}
