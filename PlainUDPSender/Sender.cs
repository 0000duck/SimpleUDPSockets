using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using modelLibrary;

namespace PlainUDPSender
{
    internal class Sender
    {
        private int PORT;

        public Sender(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            Car car = new Car("Tesla", "red", "PLAIN-23400");

            using (UdpClient socket = new UdpClient())
            {
                String carStr = car.ToString();
                Byte[] data = Encoding.ASCII.GetBytes(carStr);

                IPEndPoint receiverEP = new IPEndPoint(IPAddress.Loopback, PORT);
                socket.Send(data, data.Length, receiverEP);

                Console.WriteLine($"sent: {carStr} to: {receiverEP}" );
            }
        }
    }
}