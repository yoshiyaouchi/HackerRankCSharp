using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class BillDivision
    {
        void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            if (bill.Sum()/2 == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b-(bill.Sum()/2));
        }
        public void Run()
        {
            int k = 1;
            List<int> bill = new List<int>()
            {
                3, 10, 2, 9
            };
            int b = 7;
            bonAppetit(bill, k, b);
        }
    }
}