using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class Sub_arrayDivision
    {
        int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            if (s.Count > m)
            {
                for (int i = 0; i < s.Count - (m - 1); i++)
                {
                    if (s.GetRange(i, m).Sum() == d)
                        count++;
                }
            }
            else if (s.Count == m)
            {
                if (s.Sum() == d)
                    count++;
            }
            return count;
        }
        static List<int> setChocolateBar(int n)
        {
            List<int> chocolateBar = new List<int>();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                chocolateBar.Add(random.Next(1, 5));
            }

            return chocolateBar;
        }
        void Run()
        {
            Random random = new Random();
            int n = random.Next(10, 100);
            int d = random.Next(1, 31);
            int m = random.Next(1, 12);
            List<int> chocolateBar = setChocolateBar(n);
            for (int i = 0; i < chocolateBar.Count; i++)
            {
                Console.Write(chocolateBar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("n=" + n + ", d=" + d + ", m=" + m);
            int result = birthday(chocolateBar, d, m);
            Console.WriteLine("Result = " + result);
        }
    }
}
