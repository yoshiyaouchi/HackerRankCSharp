using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class DiagonalDifference
    {
        public int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                leftToRight += arr[i][i];
                rightToLeft += arr[i][arr.Count - i - 1];
            }

            return Math.Abs(leftToRight - rightToLeft);
        }
        public void Run()
        {
            List<List<int>> mainlist = new List<List<int>>();
            mainlist.Add(new List<int>() { 11, 2, 4 });
            mainlist.Add(new List<int>() { 4, 5, 6 });
            mainlist.Add(new List<int>() { 10, 8, -12 });

            int result = diagonalDifference(mainlist);
            Console.WriteLine(Convert.ToString(result));
        }
    }
}
