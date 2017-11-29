using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using modelLibrary;
using Newtonsoft.Json;

namespace JsonUDPSender
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
            Car car = new Car("Tesla", "red", "JSON23400");

            using (UdpClient socket = new UdpClient())
            {
                String carStr = car.ToString();
                String carJsonStr = JsonConvert.SerializeObject(car);
                Byte[] data = Encoding.ASCII.GetBytes(carJsonStr);

                IPEndPoint receiverEP = new IPEndPoint(IPAddress.Loopback, PORT);
                socket.Send(data, data.Length, receiverEP);

                Console.WriteLine($"sent: {carJsonStr} to: {receiverEP}");
            }
        }
    }
}