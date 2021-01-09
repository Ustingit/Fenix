using System;
using System.Text;

namespace Fenix
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(new ServerConfigurator(), new ServerCreator(),new ServerEvents());
            server.Start();
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
