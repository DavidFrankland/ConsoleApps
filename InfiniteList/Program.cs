using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteList
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            foreach (var i in GetNext())
            {
                Console.WriteLine(i);
                z++;
                if (z == 10) break;
            }

            z = 0;
            foreach (var i in GetNext())
            {
                Console.WriteLine(i);
                z++;
                if (z == 10) break;
            }
        }

        private static void DoStuff()
        {
            int z = 0;
            foreach (var i in GetNext())
            {
                Console.WriteLine(i);
                z++;
                if (z == 10) break;
            }
        }

        private static IEnumerable<int> GetNext()
        {
            var ints = new List<int> { 1, 2, 3 };

            foreach (var i in ints)
            {
                yield return i;
            }

            while(true) yield return ints.Last();
        }
    }
}
