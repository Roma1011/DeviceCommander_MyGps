using DeviceCommander.Helper_Methods.Pars_Data;
using DeviceCommander.HelperProperties;
using DeviceCommander.Services.DataGridServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DeviceCommander.Helper_Methods.Socket;
public class ReceiveIncomingSocket
{
    private byte[] buffer;
    private DataGridView dataGrid;
    public async Task ReceiveData(DataGridView dataGridView, CancellationToken cts)
    {
        dataGrid = dataGridView;
        while (!cts.IsCancellationRequested)
        {
            foreach (var socketItem in HelperProperties.Properties.IncomingSockets)
            {
                if (!cts.IsCancellationRequested)
                {
                    
                    try
                    {
                        byte[] buffer = new Byte[socketItem.ReceiveBufferSize];
                        socketItem.BeginReceive(buffer, 0, buffer.Length,SocketFlags.None,new AsyncCallback(ReceiveCallback), null);
                    }
                    catch (SocketException )
                    {
                        return;
                    }
                    catch (OperationCanceledException)
                    {
                        // Task was cancelled, exit gracefully
                        return;
                    }
                }
            }
        }
    }

    private void ReceiveCallback(IAsyncResult ar)
    {
        try
        {
            System.Net.Sockets.Socket socket = (System.Net.Sockets.Socket)ar.AsyncState;
            int bytesRead = socket.EndReceive(ar);

            if (bytesRead > 0)
            {
                string text = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                string[] receiveImei = StartPingParser.Parse(text);

                if (receiveImei != null)
                {
                    ReflectionGridData.AddData(dataGrid, receiveImei);
                }
            }

            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}

//async Task Body(System.Net.Sockets.Socket socketItem)
//{
//    StartPingParser startParser = new StartPingParser();
//    ReflectionGridData reflectionGridData = new ReflectionGridData();

//    var buffer = new byte[1024];

//    var numberOfReceivedBytes = await socketItem.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
//    if (numberOfReceivedBytes > 0)
//    {
//        var receivedString = Encoding.ASCII.GetString(buffer, 0, numberOfReceivedBytes);

//        string[] reciveImei = await startParser.Parse(receivedString);

//        if (reciveImei != null)
//        {
//            await reflectionGridData.AddData(dataGridView, reciveImei);

//            var existingSocket = HelperProperties.Properties.IncomingData.FirstOrDefault(x => x.Item1 == socketItem);

//            if (existingSocket.Item1 == null)
//            {
//                HelperProperties.Properties.IncomingData.Add((socketItem, receivedString));
//            }
//            else
//            {
//                HelperProperties.Properties.IncomingData[HelperProperties.Properties.IncomingData.IndexOf(existingSocket)] = (socketItem, receivedString);
//            }
//        }

//    }

//await Task.WhenAll(HelperProperties.Properties.IncomingSockets.Select(Body));
