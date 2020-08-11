using System;
using System.Runtime.InteropServices.ComTypes;

namespace AppleAndOrange
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;
            foreach(int apple in apples)
            {
                if((apple + a) >= s && (apple + a) <= t)
                    appleCount++;
            }
            foreach(int orange in oranges)
            {
                if((orange + b) >= s && (orange + b) <= t)
                    orangeCount++;
            }
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
        static void Main(string[] args)
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int m = 3;
            int n = 2;
            int[] apples = { -2, 2, 1 };
            int[] oranges = { 5, -6 };

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
