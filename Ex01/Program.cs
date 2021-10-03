using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {

        private static void runA()
        {
            while (true)
            {
                Console.WriteLine("A");
            } 
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(runA);
            thread.Start();          
        }
    }
}
