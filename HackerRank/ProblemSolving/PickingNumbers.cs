using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class PickingNumbers
    {
        int pickingNumbers(List<int> a)
        {
            int count = 0;
            int max = 0;
            for (int i=0; i<a.Count; i++)
            {
                for (int j=i; j<a.Count; j++)
                {
                    if (a[j] - a[i] <= 1)
                        count++;
                }
                if (count > max)
                    max = count;
                count = 0;
            }
            return max;
        }
        public void Run()
        {
            List<int> list = new List<int> { 1, 4, 1, 2, 2 };
            Console.WriteLine(pickingNumbers(list));
        }
    }
}
