using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using modelLibrary;
using Newtonsoft.Json;

namespace JsonUDPReceiver
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


                String carJsonStr = Encoding.ASCII.GetString(data);
                Car incommingCar = JsonConvert.DeserializeObject<Car>(carJsonStr);
                

                Console.WriteLine($"receive: {incommingCar} from: {senderEP}");
            }
        }
    }
}