using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class SalesByMatch
    {
        int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i=0; i<n; i++)
            {
                int sockType = ar[i];
                if (set.Contains(sockType))
                {
                    set.Remove(sockType);
                    numberOfPairs++;
                }
                else
                    set.Add(sockType);
            }
            return numberOfPairs;
        }
        public void Run()
        {
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine(sockMerchant(n, ar).ToString());
        }
    }
}