using System;
using System.Text;

namespace Staircase
{
    class Program
    {
        static void staircase(int n) {
            for(int i=0; i<n; i++) {
                for(int j=n-i-1; j>0; j--) {
                    Console.Write("_");
                }
                for(int j=1; j<=i+1; j++) {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            staircase(n);
        }
    }
}
