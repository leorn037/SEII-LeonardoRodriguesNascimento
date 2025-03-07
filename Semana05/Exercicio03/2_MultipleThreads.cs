using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreads
{
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 8; i++)
        {
            var thread = new Thread(DifferentMethod);
            thread.Start(i);
        }
    }
    static void DifferentMethod(object threadID)
    {
        while(true)
            Console.WriteLine("Hello from DifferentMethod (" + threadID + ")");
    }
}
}