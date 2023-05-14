using DeviceCommander.Helper_Methods.Pars_Data;
using DeviceCommander.HelperProperties;
using DeviceCommander.Services.DataGridServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DeviceCommander.Helper_Methods.Socket
{
    public class ReceiveIncomingSocket
    {
        public async Task ReceiveData(DataGridView dataGridView, CancellationToken cts)
        {
            while (!cts.IsCancellationRequested)
            {
                foreach (var socketItem in HelperProperties.Properties.IncomingSockets)
                {
                    if (!cts.IsCancellationRequested)
                    {
                        var buffer = new byte[1024];
                        try
                        {
                            var numberOfReceivedBytes = await socketItem.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None, cts);

                            if (numberOfReceivedBytes > 0)
                            {
                                var receivedString = Encoding.ASCII.GetString(buffer, 0, numberOfReceivedBytes);
                                string[] receiveImei = await StartPingParser.Parse(receivedString);

                                if (receiveImei != null)
                                {
                                    await ReflectionGridData.AddData(dataGridView, receiveImei);

                                    var existingSocket = HelperProperties.Properties.IncomingData.FirstOrDefault(x =>
                                        x.Item1 == socketItem);

                                    if (existingSocket.Item1 == null)
                                    {
                                        HelperProperties.Properties.IncomingData.Add((socketItem, receivedString));
                                    }
                                    else
                                    {
                                        HelperProperties.Properties.IncomingData[HelperProperties.Properties.IncomingData.IndexOf(existingSocket)] =
                                            (socketItem, receivedString);
                                    }
                                }
                            }
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
