using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static Stopwatch stopwatch;

        static string getTime()
        {
            return stopwatch.Elapsed.ToString().Substring(0, 8);
        }


        static void ComplexFunc()
        {
            Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 999999999; i++)
            {
                //do something
            }
            Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
        }

        static void OneThread()
        {
            for (int i = 0; i < 5; i++)
            {
                ComplexFunc();
            }
        }

        static void MultiThread()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(ComplexFunc).Start();
                // t.Start();
            }
        }


        static void MultiThread_v2()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(() =>
                {
                    Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
                    for (int j = 0; j < 999999999; j++)
                    {
                //do something
            }
                    Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
                }).Start();
            }
        }
        static void MultiThread_v3()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(() =>
                {
                    Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, "thread " + i);
                    for (int j = 0; j < 999999999; j++)
                    {
                //do something
            }
                    Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, "thread " + i);
                }).Start();
            }
        }

        static void MultiThread_v4()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread((obj) =>
                {
                    Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, "thread " + obj);
                    for (int j = 0; j < 999999999; j++)
                    {
                //do something
            }
                    Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, "thread " + obj);
                }).Start(i);
            }
        }

        static void Main(string[] args)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("main thread id: " + Thread.CurrentThread.ManagedThreadId);

            //  OneThread();
            MultiThread_v4();

            Console.ReadLine();
        }
    }
}
