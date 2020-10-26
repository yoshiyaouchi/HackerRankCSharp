using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class CompareTheTriplets
    {
        List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            var result = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                    alice++;
                if (a[i] < b[i])
                    bob++;
            }
            result.Add(alice);
            result.Add(bob);
            return result;
        }
    }
}
