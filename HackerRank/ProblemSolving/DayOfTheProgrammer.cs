using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class DayOfTheProgrammer
    {
        string dayOfProgrammer(int year)
        {
            if (year == 1918)
                return "26.09.1918";
            else
            {
                if (isLeapYear(year))
                    return "12.09." + year.ToString();
                else
                    return "13.09." + year.ToString();
            }
        }
        bool isLeapYear(int year)
        {
            if (year < 1918)
            {
                if (year % 4 == 0)
                    return true;
                else
                    return false;
            }
            else
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    return true;
                else
                    return false;
            }
        }
        public void Run()
        {
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
        }
    }
}
