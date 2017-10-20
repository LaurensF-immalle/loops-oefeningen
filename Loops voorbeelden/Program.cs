using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_voorbeelden
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown();
            CountUp();
            RepeatCount();
            Thread.Sleep(110000000);

        }

        private static void RepeatCount()
        {
            uint som = 0;
            for (uint i = 0; i <= 100000000; i++)
            {
                som += i;
                Console.WriteLine(som);
            }
        }

        private static void CountUp()
        {
            uint som = 0;
            for (uint i = 0; i <= 10000000; i++)
            {
                som += i;
                Console.WriteLine(som);
            }
        }

        private static void CountDown()
        {
            int x = 10;

            while (x > 3)
            {
                x--;
                Console.WriteLine(x);
            }

           
        }
    }
}
