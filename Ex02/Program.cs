using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        private static void runA()
        {
            while (true)
            {
                Console.WriteLine("A");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(runA);
            thread.Start();
        }
    }
}
