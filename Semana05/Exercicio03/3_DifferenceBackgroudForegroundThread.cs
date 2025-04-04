﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BGandFGThreads
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        for (int i = 0; i < Environment.ProcessorCount; i++)
        {
            var thread = new Thread(DifferentMethod);
            thread.IsBackground = true;
            thread.Start(i);
        }
        Console.WriteLine("Leaving Main");
    }
    static void DifferentMethod(object threadID)
    {
        while(true)
            Console.WriteLine("Hello from DifferentMethod (" + Thread.CurrentThread.ManagedThreadId + ")");
    }
}
}