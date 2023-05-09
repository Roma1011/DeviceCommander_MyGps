using DeviceCommander.Helper_Methods.Pars_Data;
using DeviceCommander.HelperProperties;
using DeviceCommander.Services.DataGridServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Socket
{
    public class ReciveIncomingSocket
    {
        public async Task ReciveData(DataGridView dataGridView)
        {
            while (true)
            {
                Parallel.ForEach(HelperProperties.Properties.IncomingSockets, async socketItem =>
                {
                    StartPingParser s = new StartPingParser();
                    ReflectionGridData reflectionGridData = new ReflectionGridData();

                    var buffer = new byte[1024];
                    var numberOfReceivedBytes = await socketItem.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None);

                    if (numberOfReceivedBytes > 0)
                    {
                        var receivedString = Encoding.ASCII.GetString(buffer, 0, numberOfReceivedBytes);

                        string[] reciveImei=await s.Parse(receivedString);

                        if (reciveImei!=null)
                        {
                            await reflectionGridData.AddData(dataGridView, reciveImei);

                            var existingSocket = HelperProperties.Properties.IncomingData.FirstOrDefault(x => x.Item1 == socketItem);

                            if (existingSocket.Item1 == null)
                            {
                                HelperProperties.Properties.IncomingData.Add((socketItem, receivedString));
                            }
                            else
                            {
                                HelperProperties.Properties.IncomingData[HelperProperties.Properties.IncomingData.IndexOf(existingSocket)] = (socketItem, receivedString);
                            }
                        }

                    }
                });
                Thread.Sleep(1000);
            }
        }
    }
}
