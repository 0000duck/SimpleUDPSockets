using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;
using modelLibrary;

namespace XmlUDPSender
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
            Car car = new Car("Tesla", "red", "XML23400");

            using (UdpClient socket = new UdpClient())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Car));
                StringWriter sw = new StringWriter();
                serializer.Serialize(sw, car);

                String carXMLStr = sw.ToString();
                Byte[] data = Encoding.ASCII.GetBytes(carXMLStr);

                IPEndPoint receiverEP = new IPEndPoint(IPAddress.Loopback, PORT);
                socket.Send(data, data.Length, receiverEP);

                Console.WriteLine($"sent: {carXMLStr} to: {receiverEP}");
            }
        }
    }
}