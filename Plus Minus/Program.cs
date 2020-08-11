﻿using System;

namespace Plus_Minus
{
    class Program
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr) {
            int zeroCount = 0, plusCount = 0, minusCount = 0;
            for(int i=0; i<arr.Length; i++) {
                if(arr[i] == 0)
                    zeroCount++;
                else if (arr[i] > 0)
                    plusCount++;
                else if (arr[i] < 0)
                    minusCount++;
            }
            decimal zeroRatio = (decimal)zeroCount/arr.Length;
            decimal plusRatio = (decimal)plusCount/arr.Length;
            decimal minusRatio = (decimal)minusCount/arr.Length;
            Console.WriteLine(Math.Round(zeroRatio, 6).ToString("N6"));
            Console.WriteLine(Math.Round(plusRatio, 6).ToString("N6"));
            Console.WriteLine(Math.Round(minusRatio, 6).ToString("N6"));
        }
        static void Main(string[] args)
        {
            int[] arr = {-4, 3, -9, 0, 4, 1};
            plusMinus(arr);
        }
    }
}
