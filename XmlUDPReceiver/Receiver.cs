using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;
using modelLibrary;

namespace XmlUDPReceiver
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


                String carXMLStr = Encoding.ASCII.GetString(data);
                StringReader sr = new StringReader(carXMLStr);
                XmlSerializer serializer = new XmlSerializer(typeof(Car));
                Car incommingCar = (Car)serializer.Deserialize(sr);

                Console.WriteLine($"receive: {incommingCar} from: {senderEP}");
            }
        }
    }
}