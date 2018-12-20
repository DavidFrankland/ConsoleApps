using System;

namespace StaticConstructorTest
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Thing.StaticProperty);
            Thing t1 = new Thing();
            Console.WriteLine(t1.Property);
            Thing t2 = new Thing();
            Console.WriteLine(t2.Property);
        }
    }

    public class Thing
    {
        public static string StaticProperty { get; }

        static Thing()
        {
            StaticProperty = "init";
        }

        public string Property => StaticProperty;
    }
}
