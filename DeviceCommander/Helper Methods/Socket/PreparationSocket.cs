using DeviceCommander.Helper_Methods.Pars_Data;
using DeviceCommander.Services.DataGridServices;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace DeviceCommander.Helper_Methods.Socket;
public class PreparationSocket
{ 
    private static byte[] _buffer=new byte[1024];
    private static DataGridView dgr;
    public static void CreateListenerSocket(DataGridView dg)
    {
        if (HelperProperties.Properties.token.IsCancellationRequested)
        {
            return;
        }
        dgr = dg;
        HelperProperties.Properties._listenerSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        HelperProperties.Properties._listenerSocket.Bind(new IPEndPoint(IPAddress.Any, 1300));
        HelperProperties.Properties._listenerSocket.Listen(5);
        HelperProperties.Properties._listenerSocket.BeginAccept(new AsyncCallback(AcceptCallBack),null);
    }

    private static void AcceptCallBack(IAsyncResult AR)
    {
        if (HelperProperties.Properties.token.IsCancellationRequested)
        {
            return;
        }
        System.Net.Sockets.Socket socket= HelperProperties.Properties._listenerSocket.EndAccept(AR);
        HelperProperties.Properties.IncomingSockets.Add(socket);
        socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
        HelperProperties.Properties._listenerSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
    }

    private static void ReceiveCallBack(IAsyncResult AR)
    {
        if (HelperProperties.Properties.token.IsCancellationRequested)
        {
            return;
        }
        System.Net.Sockets.Socket socket = (System.Net.Sockets.Socket)AR.AsyncState;

        try
        {
            if (socket.Connected)
            {
                int received = socket.EndReceive(AR);

                byte[] dataBuf = new byte[received];

                Array.Copy(_buffer, dataBuf, received);

                string text = Encoding.ASCII.GetString(dataBuf);

                if (!string.IsNullOrEmpty(text))
                {
                    string[] result = StartPingParser.Parse(text);
                    if (!string.IsNullOrEmpty(result[0]))
                        ReflectionGridData.AddData(dgr, result);

                    HelperProperties.Properties.IncomingData.Add((socket, result[0]));
                    socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
                }

            }
            else
            {
                // Socket is no longer connected, close it
                HelperProperties.Properties.IncomingSockets.Remove(socket);
                socket.Close();
            }
        }
        catch (SocketException)
        {
            // Socket error occurred, close the socket
            HelperProperties.Properties.IncomingSockets.Remove(socket);
            socket.Close();
        }
    }
}
