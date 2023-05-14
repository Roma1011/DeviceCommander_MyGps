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
        public async Task AcceptConnection(System.Net.Sockets.Socket listenerSocket, CancellationToken cancellationToken)
        {
            List<System.Net.Sockets.Socket> incomingSocketsCopy = new List<System.Net.Sockets.Socket>(HelperProperties.Properties.IncomingSockets);
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                System.Net.Sockets.Socket acceptedSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    acceptedSocket = await listenerSocket.AcceptAsync(cancellationToken);
                }
                catch (ObjectDisposedException)
                {
                    break;
                }
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode != SocketError.OperationAborted)
                    {
                        throw;
                    }
                }

                if (acceptedSocket != null)
                {
                    incomingSocketsCopy.Add(acceptedSocket);
                    HelperProperties.Properties.IncomingSockets = incomingSocketsCopy;
                }
                
            }

            await Task.Delay(1000, cancellationToken);
        }

    }
}
