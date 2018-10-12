using System;

namespace TCPServer
{
    class Program
    {
        private const int PORT = 7;
        static void Main(string[] args)
        {
            var Server = new TCPServer(PORT);
            Server.Start();

            Console.ReadLine();
        }
    }
}
