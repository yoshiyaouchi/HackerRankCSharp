using System;
using System.Runtime.Intrinsics;

namespace Kangaroo
{
    class Kangaroo
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
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
                    //Console.WriteLine("x1 = " + x1 + ", x2 = " + x2 + ", jump = " + jump);
                } while (x1 < x2);
                if (xOne + v1 * jump == xTwo + v2 * jump)
                    return "YES";
                else
                    return "NO";
            }
            else
                return "NO";
        }
        static void Main(string[] args)
        {
            int x1 = 0;
            int v1 = 3;
            int x2 = 4;
            int v2 = 2;

            Console.WriteLine(kangaroo(x1, v1, x2, v2));

            int x3 = 0;
            int v3 = 2;
            int x4 = 5;
            int v4 = 3;

            Console.WriteLine(kangaroo(x3, v3, x4, v4));
        }
    }
}