using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using WeightConvertLibrary;

namespace TCPServer
{
    class TCPServer
    {
        private readonly int port;
        

        public TCPServer(int pORT)
        {
            this.port = port;
        }

        public void Start()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, port);
            tcpListener.Start();

            while (true)
            {
                var client = tcpListener.AcceptTcpClient();
                Task.Run(() => DoClient(client));
            }
        }

        private void DoClient(TcpClient client)
        {
            while (client.Connected)
            {
                var getStream = client.GetStream();
                var streamReader = new StreamReader(getStream);
                var streamWriter = new StreamWriter(getStream);
                streamWriter.Flush();

                string[] incommingStrings;
                incommingStrings = streamReader.ReadLine().Split(' ');
                var options = incommingStrings[0].ToUpper();

                if (options == "TOGRAM")
                {
                    double unitWeight = double.Parse(incommingStrings[1]);
                    double convertResult = WeightConverter.OzToGrams(unitWeight);

                    streamWriter.WriteLine(convertResult);
                }

                if (options == "TOOZ")
                {
                    double unitWeight = double.Parse(incommingStrings[1]);
                    double convertResult = WeightConverter.GramsToOz(unitWeight);

                    streamWriter.WriteLine(convertResult);
                }
            }
            
                      
        } 
    }
}
