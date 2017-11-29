using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver
{
    class Program
    {
        private const int PORT = 11001;
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(PORT);
            receiver.Start();

            Console.ReadLine();
        }
    }
}
