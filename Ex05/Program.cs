using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        private static void run(object obj)
        {
            
                while (true)
                {
                    Console.WriteLine(obj);
                    Thread.Sleep(1000);
                    
                }
           
        }

        static void Main(string[] args)
        {
           
                Thread t1 = new Thread(run);
                t1.Start("A");

                Thread t2 = new Thread(run);
                t2.Start("B");

              //  t2.Abort();
           // ThreadAbortException
        }
    }
}
