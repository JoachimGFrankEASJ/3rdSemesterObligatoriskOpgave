using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace TCPServer
{
    class TCPServer
    {
        private readonly int PORT;

        public TCPServer(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, PORT);
            serverListener.Start();
            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();

                //// print out src + dst end points ---------------
                //IPEndPoint localAddr = (IPEndPoint)socket.Client.LocalEndPoint;
                //IPEndPoint remoteAddr = (IPEndPoint)socket.Client.RemoteEndPoint;
                //Console.WriteLine($"Incomming IP={remoteAddr.Address} PORT={remoteAddr.Port}");
                //Console.WriteLine($"My own    IP={localAddr.Address} PORT={localAddr.Port}");
                ////-------


                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        private static void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                // Ændre disse 4 linijer
                String incommingStr = sr.ReadLine();
                string outstring = "";
                string[] strings = incommingStr.Split(" ");

                if (strings[0] == "toGram")
                {
                    double rg = double.Parse(strings[1]);
                    Converter C = new Converter();
                    Ounces O = new Ounces(rg);
                    double convertToGram = C.ConvertToGram(O);
                    outstring = convertToGram.ToString();
                }
                if (strings[0] == "toOunces")
                {
                    double rg = double.Parse(strings[1]);
                    Converter C = new Converter();
                    Gram G = new Gram(rg);
                    double convertToOunces = C.ConvertToOunces(G);
                    outstring = convertToOunces.ToString();
                }
                
                Console.WriteLine($"String in = {outstring}");

                sw.WriteLine(outstring);
                sw.Flush();
                // her til 
            }
            socket?.Close();
        }
    }
}
