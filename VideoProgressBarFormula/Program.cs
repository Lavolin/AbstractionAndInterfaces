using System;
using System.Threading;

namespace VideoProgressBarFormula
{
     class Program
    {
        static void Main(string[] args)
        {
            double minutes = 210;
            while (true)
            {
                var passedMinutes = DateTime.Now - new DateTime(2022, 6, 8, 12, 56, 0);
                Console.Clear();
                Console.WriteLine((int)(passedMinutes.TotalMinutes/minutes*100)+ "%");
                Thread.Sleep(100);
            }
        }
    }
}
