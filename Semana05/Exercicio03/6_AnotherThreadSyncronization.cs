using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BGandFGThreads
{
    class Program
    {
        static object baton new object ();
        static Random rand = new Random();
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(UseRestroomstaII).Start();
            }
        }
        static void UseRestroomstaII()
        {
            Console.WriteLine(Thread.currentThread.nanagedThread1d
                + " trying to obtain the bathroom stall...");
            lock (baton)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId
                    + " obtained the lock. Doing my business. ");
                Thread.Sleep(rand.Next(2000));
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId
                    + " leaving the stall...")
            }
        }
    }
}