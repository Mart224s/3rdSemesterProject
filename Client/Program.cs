using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert from grams to ounces or the other way around");

            var client = new Client();
            client.Start();

            Console.ReadKey();

        }
    }
}
