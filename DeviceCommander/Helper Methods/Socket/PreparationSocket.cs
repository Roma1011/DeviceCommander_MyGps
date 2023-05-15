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
        static int port = 1300;

        public static void CreateListenerSocket(ref TcpListener listenerSocket)
        {
            address = IPAddress.Any;
            listenerSocket = new TcpListener(address, port);
            listenerSocket.Start();
        }
    }
}
