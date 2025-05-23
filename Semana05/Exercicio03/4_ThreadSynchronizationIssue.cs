﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BGandFGThreads
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        { 
            var thread1 = new Thread(IncrementCount);
            var thread2 = new Thread(IncrementCount);
            thread1.Start();
            Thread.Sleep(500);
            thread2.Start();
        }
        static void IncrementCount()
        {
            while (true)
            {
                int temp = count;
                Thread.Sleep(1000);
                count = temp +1;
                Console.WriteLine(
                    "Thread ID " + Thread.CurrentThread.ManagedThreadId + 
                    " incremented count to " + count + ".");
                Thread.Sleep(1000);

            }
        }
    }
}