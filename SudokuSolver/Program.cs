using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static Solver solver = new Solver();
        static TextIO puzzleIO = new TextIO();

        static void Main(string[] args)
        {
            while (true)
            {
                // Get input
                Console.WriteLine(TextIO.IntroMessage + "\n");
                int[][] puzzle = puzzleIO.ReadPuzzle();
                // Solve puzzle
                solver.SolvePuzzle(puzzle);
                Console.WriteLine("");
                // Display puzzle
                puzzleIO.WritePuzzle(puzzle);
                Console.WriteLine("");
                // Do it again (maybe)
                if (puzzleIO.GetOption("Quit?", "Y", "N"))
                {
                    return;
                }
                Console.WriteLine("");
            }
        }
    }
}
