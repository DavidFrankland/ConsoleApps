using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StaticProcessorTest
{
    public class Processor
    {
        private static int counter = 0;
        public void Process()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(counter++);
                Console.WriteLine(i);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
