using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class DrawingBook
    {
        int pageCount(int n, int p)
        {
            int totalPageTurnsFromFront = n / 2;
            int targetPageTurnsFromFront = p / 2;
            int targetPageTurnsFromBack = totalPageTurnsFromFront - targetPageTurnsFromFront;
            if (targetPageTurnsFromFront < targetPageTurnsFromBack)
                return targetPageTurnsFromFront;
            else
                return targetPageTurnsFromBack;
        }
        public void Run()
        {
            int n = 5;
            int p = 4;
            Console.WriteLine(pageCount(n, p));
        }
    }
}