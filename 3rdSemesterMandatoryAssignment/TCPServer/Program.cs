using System;

namespace TCPServer
{
    class Program
    {
        private const int port = 7;
     

        static void Main(string[] args)
        {
            TCPServer Server = new TCPServer(port);
            Server.Start();

            Console.ReadLine();
        }
    }
    
}
