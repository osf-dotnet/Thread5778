using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
private static void run(object obj)
{
    while (true)
    {
        string str = Thread.CurrentThread.ManagedThreadId + " print " + obj;
        Console.WriteLine(str);
        Thread.Sleep(100);
    }
}

        static void Main(string[] args)
        {

            Thread t1 = new Thread(run);
            t1.Start("A");

            Thread t2 = new Thread(run);
            t2.Start("B");
        }
    }
}
