using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class Staircase
    {
        void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i - 1; j > 0; j--)
                {
                    Console.Write("_");
                }
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        void Run()
        {
            int n = 5;
            staircase(n);
        }
    }
}
