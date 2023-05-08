using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using DeviceCommander.HelperProperties;

namespace DeviceCommander.Helper_Methods.Socket
{
    public class ConfirmConnection
    {
        public async Task AcceptConnection(System.Net.Sockets.Socket listenerSocket)
        {
            while (true)
            {
                System.Net.Sockets.Socket acceptedSocket = await listenerSocket.AcceptAsync();
                HelperProperties.Properties.IncomingSockets.Add(acceptedSocket);
                Thread.Sleep(1000);
            }
        }

    }
}
