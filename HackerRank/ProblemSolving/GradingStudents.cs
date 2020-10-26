using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class GradingStudents
    {
        List<int> gradingStudents(List<int> grades)
        {
            List<int> gradesAfterRoundup = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38 && grades[i] % 5 > 2)
                {
                    gradesAfterRoundup.Add((grades[i] + 5) / 5 * 5);
                }
                else
                {
                    gradesAfterRoundup.Add(grades[i]);
                }
            }

            return gradesAfterRoundup;
        }
        void Run()
        {
            Console.Write("N: ");
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                Console.WriteLine("Enter {0} of {1}", i + 1, gradesCount);
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
