using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonUDPSender
{
    class Program
    {
        private const int PORT = 11003;
        static void Main(string[] args)
        {
            Sender sender = new Sender(PORT);
            sender.Start();

            Console.ReadLine();
        }
    }
}
