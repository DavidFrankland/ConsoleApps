using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest
{
    public static class Program
    {
        private static void Main()
        {
            DoThings();
        }

        private static async Task DoThings()
        {
            for (int i = 0; i < 5; i++)
            {
                DoStuff();
            }
        }

        private static async Task DoStuff()
        {
            Console.WriteLine("DoStuff start");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("DoStuff stop");
        }
    }
}
