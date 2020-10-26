using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class TimeConversion
    {
        string timeConversion(string s)
        {
            DateTime dt = DateTime.Parse(s);
            string returnTime = dt.ToString("HH:mm:ss");
            return returnTime;
        }
        void Run()
        {
            string s = "07:05:45PM";
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
