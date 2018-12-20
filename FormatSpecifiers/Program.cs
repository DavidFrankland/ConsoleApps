using System;

namespace FormatSpecifiers
{
    public static class Program
    {
        private static void Main()
        {
            var s = "Test";

            Console.Write($"{s,-10}");
            Console.WriteLine(".");

            var i = 7;

            Console.Write($"{i:D5}");
            Console.WriteLine(".");

        }
    }
}
