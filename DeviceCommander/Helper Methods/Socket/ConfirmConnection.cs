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
        public async Task AcceptConnection(TcpListener listenerSocket, CancellationToken cancellationToken)
        {
            List<TcpClient> incomingSocketsCopy = new List<TcpClient>(HelperProperties.Properties.IncomingSockets);
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                TcpClient acceptedSocket = new TcpClient();

                try
                {
                    acceptedSocket = await listenerSocket.AcceptTcpClientAsync(cancellationToken);
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
