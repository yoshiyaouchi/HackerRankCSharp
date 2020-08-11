using System;

namespace Mini_Max_Sum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr) {
            Array.Sort(arr);
            long minSum = 0;
            long maxSum = 0;
            for(int i=0; i<4; i++) {
                minSum += arr[i];
            }
            Array.Reverse(arr);
            for(int i=0; i<4; i++) {
                maxSum += arr[i];
            }
            Console.WriteLine(minSum + " " + maxSum);
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5};

            miniMaxSum(arr);
        }
    }
}
