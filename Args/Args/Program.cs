using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Args
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                if (args[0] == "-ip" && args[1] != null)
                {
                    PingTest(args[1]);
                    Console.WriteLine(args[1]);
                }
            }
        }
        public static void PingTest(string ip)
        {
            Ping ping = new Ping();
            int timeout = 10;
            if (ping.Send(ip, timeout).Status == IPStatus.Success)
            {
                Console.WriteLine("Existoso");
            }
            else
            {
                Console.WriteLine("Fallido");
            }
        }
    }
}
