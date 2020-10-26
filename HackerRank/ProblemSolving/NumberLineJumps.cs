using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class NumberLineJumps
    {
        string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {
                int xOne = x1;
                int xTwo = x2;
                int jump = 0;
                do
                {
                    x1 += v1;
                    x2 += v2;
                    jump++;
                } while (x1 < x2);
                if (xOne + v1 * jump == xTwo + v2 * jump)
                    return "YES";
                else
                    return "NO";
            }
            else
                return "NO";
        }
    }
}
