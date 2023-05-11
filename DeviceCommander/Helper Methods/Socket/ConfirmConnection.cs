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
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                System.Net.Sockets.Socket acceptedSocket = null;

                try
                {
                    acceptedSocket = await listenerSocket.AcceptAsync();
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

                HelperProperties.Properties.IncomingSockets.Add(acceptedSocket);
                await Task.Delay(1000, cancellationToken);
            }
        }


    }
}
