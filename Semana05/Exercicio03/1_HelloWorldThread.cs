using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldThread
{
class Program
{
    static void Main(string[] args)
    {
        var thread = new Thread(DifferentMethod);
        thread.Start();
    }
    static void DifferentMethod()
    {
        Console.WriteLine("Hello World!");
    }
}
}