using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class DivisibleSumPairs
    {
        int divisibleSumPairs(int n, int k, int[] ar)
        {
            int res = 0;
            for (int i=0; i<n; i++)
            {
                for (int j=i+1; j<n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        res++;
                }
            }
            return res;
        }
        public void Run()
        {
            int n = 6;
            int k = 3;
            int[] array = { 1, 3, 2, 6, 1, 2 };
            int result = divisibleSumPairs(n, k, array);
            Console.WriteLine(result);
        }
    }
}
