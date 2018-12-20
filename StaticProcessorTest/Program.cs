using System;
using System.Threading.Tasks;

namespace StaticProcessorTest
{
    public static class Program
    {
        private static void Main()
        {
            var s = new Service();

            Task.Run(() => s.DoStuff());
            Task.Run(() => s.DoStuff());

            Console.WriteLine("Done");
            Console.ReadKey(true);
        }
    }
}
