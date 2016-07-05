using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static Solver solver = new Solver();

        static void Main(string[] args)
        {
            int[][] puzzle = new int[][]{
            new int[] {0,0,3,0,2,0,6,0,0},
            new int[] {9,0,0,3,0,5,0,0,1},
            new int[] {0,0,1,8,0,6,4,0,0},
            new int[] {0,0,8,1,0,2,9,0,0},
            new int[] {7,0,0,0,0,0,0,0,8},
            new int[] {0,0,6,7,0,8,2,0,0},
            new int[] {0,0,2,6,0,9,5,0,0},
            new int[] {8,0,0,2,0,3,0,0,9},
            new int[] {0,0,5,0,1,0,3,0,0}};

            solver.SolvePuzzle(puzzle);
            WritePuzzle(puzzle);
            Console.ReadLine();
        }

        public static void WritePuzzle(int[][] puzzle)
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
    }
}
