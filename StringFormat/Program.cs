using System;

namespace StringFormat
{
    public static class Program
    {
        private static void Main()
        {
            int? i = null;
            int? j = null;

            var message = $"i: {i} " +
                          $"j: {j} ";

            Console.WriteLine(message);
        }
    }
}
