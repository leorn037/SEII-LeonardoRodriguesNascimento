﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Multi_Con_C
{
    internal class Program
    {
        static Listener l;
        static List<Socket> sockets;
        static void Main(string[] args)
        {
            l = new Listener(8);
            l.SocketAccepted += new Listener.SocketAcceptedHandler(l_SocketAccepted);
            l.Start();
            sockets = new List<Socket>();

            Console.Read();

        }

        static void l_SocketAccepted(System.Net.Sockets.Socket e)
        {
            Console.WriteLine("New Connection: {0}\n{1}\n===========", e.RemoteEndPoint, DateTime.Now);
            sockets.Add(e);
        }
    }