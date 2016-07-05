using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class TextIO
    {
        public const string IntroMessage = "Enter nine numbers per line from 0-9. Zero represents a blank square";

        public bool GetOption(string question, string optionTrue, string optionFalse)
        {
            while (true)
            {
                Console.WriteLine(String.Format("{0}, ({1}/{2})", question, optionTrue, optionFalse));
                string input = Console.ReadLine().Trim().ToUpperInvariant();
                if (input == optionTrue.ToUpperInvariant())
                {
                    return true;
                }
                if (input == optionFalse.ToUpperInvariant())
                {
                    return false;
                }
                // Not an option
            }
        }

        public void WritePuzzle(int[][] puzzle)
        {
            foreach (int[] row in puzzle)
            {
                foreach (int num in row)
                {
                    Console.Write(num);
                }
                Console.WriteLine("");
            }
        }

        public int[][] ReadPuzzle()
        {
            int[][] puzzle = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                puzzle[i] = new int[9];
                // Loop until input is valid
                bool inputGood;
                do
                {
                    // Get input
                    inputGood = true;
                    Console.Write(String.Format("Row {0}: ", i + 1));
                    char[] inputValues = Console.ReadLine().ToCharArray();

                    // Check for proper length
                    if (inputValues.Length == 9)
                    {
                        // Parse input
                        for (int j = 0; j < 9; j++)
                        {
                            // Get integer value
                            int num = inputValues[j] & 0x0f;
                            if (num >= 0 && num <= 9)
                            {
                                puzzle[i][j] = num;
                            }
                            else
                            {
                                inputGood = false;
                            }
                        }
                    }
                    else
                    {
                        inputGood = false;
                    }

                    if (!inputGood)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine(IntroMessage);
                    }
                }
                while (!inputGood);
            }
            return puzzle;
        }
    }
}
