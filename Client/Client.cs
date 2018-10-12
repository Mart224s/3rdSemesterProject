using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Client
{
   public class Client
   {
       private const int pORT = 7;

       public void Start()
       {
           var client = new TcpClient("localhost", pORT);

           while (true)
           {
               var getStream = client.GetStream();
               var streamWriter = new StreamWriter(getStream);
               var streamReader = new StreamReader(getStream);
               streamWriter.Flush();

               streamWriter.WriteLine(Console.ReadLine());
               Console.WriteLine(streamReader.ReadLine());
           }
           
       }
   }
}
