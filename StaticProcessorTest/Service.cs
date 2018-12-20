using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProcessorTest
{
    public class Service
    {
        private readonly Processor _processor = new Processor();

        public void DoStuff()
        {
            _processor.Process();
        }
    }
}
