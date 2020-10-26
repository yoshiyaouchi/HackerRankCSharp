using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class Mini_MaxSum
    {
        void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long minSum = 0;
            long maxSum = 0;
            for (int i = 0; i < 4; i++)
            {
                minSum += arr[i];
            }
            Array.Reverse(arr);
            for (int i = 0; i < 4; i++)
            {
                maxSum += arr[i];
            }
            Console.WriteLine(minSum + " " + maxSum);
        }
        void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            miniMaxSum(arr);
        }
    }
}
