using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class StopWatch
    {
        public void StopwatchElapseTime()
        {
            Console.WriteLine("Start The Stop watch");

            DateTime start = DateTime.Now;

            for (int i = 0; i < 10; i++)
            {
                continue;
            }

            Console.WriteLine("Stop watch end");

            DateTime end = DateTime.Now;

            Console.WriteLine("Time Elapsed is=" + (end - start));
        }
    }
}
