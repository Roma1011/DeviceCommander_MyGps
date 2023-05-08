using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace DeviceCommander.Helper_Methods.Socket
{
    public class PreparationSocket
    {
        private static IPAddress? address;
        private static IPEndPoint? ipEndPoint;
        static int port = 1300;

        public static void CreateListenerSocket(ref System.Net.Sockets.Socket listenerSocket)
        {
            listenerSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            address = IPAddress.Any;
            ipEndPoint = new IPEndPoint(address, port);
            listenerSocket.Bind(ipEndPoint);
            listenerSocket.Listen(1000);
        }

    }
}
