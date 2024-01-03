// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace UzdNr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            SekosSkaiciavimas sekosSkaiciavimas = new SekosSkaiciavimas(n);
        }
    }

    public class Example
    { // Nr. 2 klase is duotos svetaines
        public static void Datetime()
        {
            DateTime start = DateTime.Now;
            System.Threading.Thread.Sleep(5000);
            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);
            Console.WriteLine("Elapsed Time is {0} ms", ts.TotalMilliseconds);
        }
    }
}