using System;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class Program
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar) {
            int maxCount = 0;
            int maxValue = ar.Max();
            for(int i=0; i<ar.Length; i++) {
                if(ar[i] == maxValue) {
                    maxCount++;
                }
            }
            return maxCount;
        }
        static void Main(string[] args)
        {
            int[] array1 = {6, 1, 4, 4, 6, 2};
            int[] array2 = {4, 0, 8, 11, 5, 11, 9, 11};
            int[] array3 = {5, 3, 7, 5, 9, 2, 5};

            Console.WriteLine(birthdayCakeCandles(array3));
        }
    }
}
