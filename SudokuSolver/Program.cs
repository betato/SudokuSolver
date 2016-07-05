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
            int[][] puzzle = puzzleIO.ReadPuzzle();
            solver.SolvePuzzle(puzzle);
            puzzleIO.WritePuzzle(puzzle);
            Console.ReadLine();
        }
    }
}
