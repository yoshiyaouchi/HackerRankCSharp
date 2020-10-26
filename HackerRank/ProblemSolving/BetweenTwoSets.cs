using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            var longer = a.Select(i => (int)i).ToArray();
            var longerb = b.Select(i => (int)i).ToArray();
            var lcm = LCM(longer);
            var gcd = GCD(longerb);
            int result = 0;
            for (int i = lcm; i <= gcd; i++)
            {
                if ((gcd % i == 0) && (i % lcm == 0))
                {
                    result++;
                }
            }
            //Console.WriteLine(result);
            return result;
        }
        private static int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }
        private static int LCM(int[] numbers)
        {
            return numbers.Aggregate(Lcm);
        }
        private static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
        private static int GCD(int[] numbers)
        {
            return numbers.Aggregate(Gcd);
        }
        void Run()
        {
            List<int> setA = new List<int>() { 2, 4 };
            List<int> setB = new List<int>() { 16, 32, 96 };

            Console.WriteLine(getTotalX(setA, setB));
        }
    }
}
