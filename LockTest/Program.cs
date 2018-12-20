using System;
using System.Threading;

namespace LockTest
{
    public static class Program
    {
        private static void Main()
        {
            Processor p = new Processor();

            p.Start();
            Thread.Sleep(500);
            p.Stop();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
