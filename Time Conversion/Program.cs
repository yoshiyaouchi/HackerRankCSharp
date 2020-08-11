using System;

namespace Time_Conversion
{
    class Program
    {
        /*
        * Complete the timeConversion function below.
        */
        static string timeConversion(string s) {
            DateTime dt = DateTime.Parse(s);
            string returnTime = dt.ToString("HH:mm:ss");
            return returnTime;
        }
        static void Main(string[] args)
        {
            string s = "07:05:45PM";
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
