using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class BreakingTheRecords
    {
        int[] breakingRecords(int[] scores)
        {
            int highest = scores[0];
            int lowest = scores[0];
            int highestCount = 0;
            int lowestCount = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (highest < scores[i])
                {
                    highest = scores[i];
                    highestCount++;
                }
                if (lowest > scores[i])
                {
                    lowest = scores[i];
                    lowestCount++;
                }
            }

            int[] breaks = { highestCount, lowestCount };
            return breaks;
        }
        void Run()
        {
            int[] scores1 = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int[] scores2 = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            int[] result = breakingRecords(scores2);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
