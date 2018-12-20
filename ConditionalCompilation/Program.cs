using System;

namespace ConditionalCompilation
{
    public static class Program
    {
        private static void Main()
        {
#if MY_CONSTANT
            Console.WriteLine("True");
#else
            Console.WriteLine("False");
#endif
        }
    }
}
