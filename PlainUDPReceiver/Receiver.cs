using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PlainUDPReceiver
{
    internal class Receiver
    {
        private int PORT;

        public Receiver(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            using (UdpClient socket = new UdpClient(PORT))
            {
                IPEndPoint senderEP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] data = socket.Receive(ref senderEP);


                String carStr = Encoding.ASCII.GetString(data);
                Console.WriteLine($"receive: {carStr} from: {senderEP}");
            }
        }
    }
}