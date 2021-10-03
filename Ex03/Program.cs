using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex03
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

        private static void runB()
        {
            while (true)
            {
                Console.WriteLine("B");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(runA);
            t1.Name = "thread A";
            t1.Start();

            Thread t2 = new Thread(runB);
            t2.Start();
            t2.Name = "thread B";
            Console.ReadKey();
        }
    }
}
