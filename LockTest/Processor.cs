using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockTest
{
    public class Processor
    {
        private readonly object _runlock = new object();
        private bool _running;
        private Thread _thread;

        private bool Running
        {
            get
            {
                lock (_runlock)
                {
                    return _running;
                }
            }
            set
            {
                lock (_runlock)
                {
                    _running = value;
                }
            }
        }

        public void Start()
        {
            if (Running) return;
            Console.WriteLine("Starting");
            _thread = new Thread(DoWork);
            _thread.Start();
            Console.WriteLine("Started");
        }

        public void Stop()
        {
            if (!Running) return;
            Console.WriteLine("Stopping");
            Running = false;
            _thread.Abort();
            _thread = null;
            Console.WriteLine("Stopped");
        }

        private void DoWork()
        {
            Running = true;
            while (Running)
            {
                lock (_runlock)
                {
                    Console.Write("Processing");
                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(100);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Processed");
                }
                Console.WriteLine("Sleeping");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Not running");
        }
    }
}
