using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftToRight = 0;
        int rightToLeft = 0;
        for(int i=0; i<arr.Count; i++) {
            leftToRight += arr[i][i];
            rightToLeft += arr[i][arr.Count-i-1];
        }

        return Math.Abs(leftToRight-rightToLeft);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> mainlist = new List<List<int>>();
        mainlist.Add(new List<int>() { 11, 2, 4 });
        mainlist.Add(new List<int>() { 4, 5, 6 });
        mainlist.Add(new List<int>() { 10, 8, -12 });

        int result = Result.diagonalDifference(mainlist);
        Console.WriteLine(Convert.ToString(result));
    }
}