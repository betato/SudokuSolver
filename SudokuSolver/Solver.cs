using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Solver
    {
        public bool SolvePuzzle(int[][] puzzle)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Don't calculate non-empty squares
                    if (puzzle[i][j] != 0)
                    {
                        continue;
                    }

                    // Try all possible numbers
                    for (int num = 1; num <= 9; num++)
                    {
                        // Check if number is valid for the given position
                        if (ValidNumber(num, i, j, puzzle))
                        {
                            puzzle[i][j] = num;
                            if (SolvePuzzle(puzzle))
                            {
                                // Number fits
                                return true;
                            }
                            else
                            {
                                // The number doesn't work here
                                puzzle[i][j] = 0;
                            }
                        }
                    }
                    return false;
                }
            }
            return true;
        }

        private bool ValidNumber(int number, int row, int column, int[][] puzzle)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check if row or column already has number
                if (puzzle[row][i] == number || puzzle[i][column] == number)
                {
                    return false;
                }
            }
            // Check if 3x3 grid already has number
            int xBox = (int)(column / 3) * 3;
            int yBox = (int)(row / 3) * 3;
            for (int i = xBox; i < xBox + 3; i++)
            {
                for (int j = yBox; j < yBox + 3; j++)
                {
                    if (puzzle[j][i] == number)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
