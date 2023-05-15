using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using DeviceCommander.HelperProperties;

namespace DeviceCommander.Helper_Methods.Socket;
public class ConfirmConnection
{
    List<System.Net.Sockets.Socket> incomingSocketsCopy = new List<System.Net.Sockets.Socket>(HelperProperties.Properties.IncomingSockets);
    public async Task AcceptConnection(CancellationToken cancellationToken)
    {
        while (true)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                break;
            }


            TcpClient acceptedSocket = new TcpClient();

            try
            {
                HelperProperties.Properties._listenerSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
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
        }

        await Task.Delay(1000, cancellationToken);
    }

    private void AcceptCallback(IAsyncResult ar)
    {
        try
        {
            incomingSocketsCopy.Add(HelperProperties.Properties._listenerSocket.EndAccept(ar));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        HelperProperties.Properties.IncomingSockets = incomingSocketsCopy;
    }
}

