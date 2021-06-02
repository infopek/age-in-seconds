using System;

namespace AgeSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(2001, 12, 18, 23, 15, 45);
            DateTime now = DateTime.Now;

            Console.WriteLine(CalcSec(birth, now));

            Console.ReadLine();
        }

        static int CalcSec(DateTime then, DateTime now)
        {
            int thenSecs = then.Year * 31536000 + then.Month * 2628000 + then.Day * 86400 + then.Hour * 3600 + then.Minute * 60 + then.Second;

            int nowSecs = now.Year * 31536000 + now.Month * 2628000 + now.Day * 86400 + now.Hour * 3600 + now.Minute * 60 + now.Second;

            // Accounting for extra days
            int extraDays = (int)Math.Ceiling((double)((now.Year - then.Year) / 4));

            int elapsedSecs = nowSecs - thenSecs + extraDays * 86400;

            // Get time difference between then and now, in seconds
            return elapsedSecs;
        }
    }
}
