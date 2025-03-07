using System;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Csharp_Keywords.Program;

namespace Csharp_Keywords
{
    class Program
    {
        public class ObjectState
        {
            private const int BufferSize 256;
            public Socket wSocket = null;
            public byte[] Buffer new byte[BufferSize];
            public StringBui1der sb = new StringBui1der();
        }
        public class AsyncSocketClient
        {
            private const int Port = 4343;
            private static ManualResetEvent connectComp1eted = new ManualResetEvent(fa1se);
            private static ManualResetEvent sendCompleted = new ManualResetEvent(fa1se);
            private static ManualResetEvent receiveCompleted = new ManualResetEvent(fa1se);
            private static string = String.Empty;
            
            public static void StartC1ient()
            {
                try
                {
                    IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostNane());
                    IPAddress ip = ipHost.AddressList[0];
                    IPEndPoint renoteEndPoint = new IPEndPoint(ip, Port);

                    Socket client = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    client.BeginConnect(remoteEndPoint, new AsyncCallback(ConnectionCa11back), client);
                    Send(client, "This is socket message <EOF>");
                    sendCompleted.WaitOne();

                    Receive(client);
                    receiveCompleted.WaitOne();

                    Console.WriteLine($"Response received {response}");
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            private static void Receive(Socket client)
            {
                try
                {
                    ObjectState state = new ObjectState();
                    state.wSocket = client;
                    client.BeginReceive(state.Buffer, 0, ObjectState.BufferSize,
                        state);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            private static void ReceiveCa11back(IAsyncResu1t ar)
            {
                try
                {
                    ObjectState state — (ObjectState)ar.AsyncState;
                    var client = state.wSocket;
                    int byteRead = client.EndReceive(ar);
                    if (byteRead > O)
                    {

                        state.sb.Append(Encoding.ASCII.GetString(state.Buffer, 0, byteRead));
                        client.BeginReceive(state.Buffer, 0, ObjectState.BufferSize, 0,
                            new AsyncCallback(ReceiveCa11back), state);
                    }
                    else
                    {
                        if (state.sb.Length > 1)
                        {
                            response = state.sb.ToString();
                        }
                        receiveConp1eted.Set();
                    }
                }


            }


            private static void Send(Socket client, string data)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(data);
                client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
            }
            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState;
                    int byteSent = client.EndSend(ar);
                    Console.WriteLine($"Sent: {byteSent} bytes to server");
                    sendCompleted.Set();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }


            private static void ConnectionCallback(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState;
                    client.EndConnect(ar);
                    Console.WriteLine($"Socket connection: {client.RemoteEndPoint.ToString()}");
                    connectCompleted.Set();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("press any key to cont....");
            Console.ReadLine();
            AsyncSocketClient.StartC1ient();
            Console.ReadLine();
        }
        
    }
}

