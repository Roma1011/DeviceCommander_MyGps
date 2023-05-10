using DeviceCommander.Helper_Methods.Pars_Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Socket
{
    public class ConnectionCheck
    {
        public static async Task IsConnected(DataGridView dataGridView)
        {
            List<System.Net.Sockets.Socket> connectedSockets = new List<System.Net.Sockets.Socket>();

            List<(System.Net.Sockets.Socket, string)> IncomingDataConnected = new List<(System.Net.Sockets.Socket, string)>();
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();
            StartPingParser startParser = new StartPingParser();

            foreach (var item in HelperProperties.Properties.IncomingSockets)
            {
                // Assume you have a Socket object named "socket"

                bool connected = item.Connected && !((item.Poll(1000, SelectMode.SelectRead) && (item.Available == 0)));
                if (connected)
                {
                    connectedSockets.Add(item);
                }
            }
            HelperProperties.Properties.IncomingSockets = connectedSockets;

            foreach (var item in HelperProperties.Properties.IncomingData)
            {
                bool found = false;
                bool connected = item.Item1.Connected && !((item.Item1.Poll(1000, SelectMode.SelectRead) && (item.Item1.Available == 0)));
                if (connected)
                {
                    IncomingDataConnected.Add((item.Item1, item.Item2));
                }
                else
                {
                    string[] reciveImei = await startParser.Parse(item.Item2);
                    rowsToRemove.Clear(); // Clear the list before using it again
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        bool match = true;
                        for (int i = 0; i < reciveImei.Length; i++)
                        {
                            if (row.Cells[i].Value == null || row.Cells[i].Value.ToString() != reciveImei[i])
                            {
                                match = false;
                                break;
                            }
                        }
                        if (match)
                        {
                            dataGridView.Invoke(new Action(() =>
                            {
                                if (dataGridView.Rows.Contains(row))
                                {
                                    dataGridView.Rows.Remove(row);
                                    dataGridView.Refresh();
                                }
                            }));
                            break;
                        }
                    }
                }
            }

            HelperProperties.Properties.IncomingData = IncomingDataConnected;
        }

    }
}
