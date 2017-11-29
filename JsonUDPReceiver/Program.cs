﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonUDPReceiver
{
    class Program
    {
        private const int PORT = 11003;
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(PORT);
            receiver.Start();

            Console.ReadLine();
        }
    }
}
