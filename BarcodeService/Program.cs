using Grapevine.Server;
using System;

namespace BarcodeService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (s,ev)=> {
                Console.WriteLine("[CTRL]+[C] pressed!");
                ev.Cancel = true;
            };

            var host = "+";
            var port = "1234";

            using (var server = new RestServer())
            {
                server.Port = port;
                server.Host = host;
                server.LogToConsole().Start();
                Console.ReadLine();
                server.Stop();
            }

        }
    }
}
