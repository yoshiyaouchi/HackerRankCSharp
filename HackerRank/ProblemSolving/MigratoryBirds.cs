using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HackerRank.ProblemSolving
{
    class MigratoryBirds
    {
        int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdCount = new Dictionary<int, int>();
            foreach (int bird in arr)
            {
                if (birdCount.ContainsKey(bird))
                    birdCount[bird]++;
                else
                    birdCount.Add(bird, 1);
            }
            return birdCount.Where(x => x.Value == birdCount.Values.Max()).Select(x => x.Key).Min();
        }
        public void Run()
        {
            List<int> arr = new List<int>()
            {
                5,2,5,2,5,5,5,2,2,2,5,2
            };
            int result = migratoryBirds(arr);
            Console.WriteLine("Most common bird is {0}", result);
        }
    }
}
