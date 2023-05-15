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
            List<(System.Net.Sockets.Socket, string)> incomingDataConnected = new List<(System.Net.Sockets.Socket, string)>();
            List<System.Net.Sockets.Socket> incomingSocketsCopy = new List<System.Net.Sockets.Socket>(HelperProperties.Properties.IncomingSockets);
            List<(System.Net.Sockets.Socket, string)> incomingDataCopy = new List<(System.Net.Sockets.Socket, string)>(HelperProperties.Properties.IncomingData);
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (var item in incomingSocketsCopy)
            {
                bool connected = item.Connected && !((item.Poll(1000, SelectMode.SelectRead) && (item.Available == 0)));
                if (connected)
                {
                    connectedSockets.Add(item);
                }
            }

            HelperProperties.Properties.IncomingSockets = connectedSockets;


            // Loop through incoming data and check if the socket is still connected
            foreach (var item in incomingDataCopy)
            {
                bool connected = item.Item1.Connected && !((item.Item1.Poll(1000, SelectMode.SelectRead) && (item.Item1.Available == 0)));
                if (connected)
                {
                    incomingDataConnected.Add((item.Item1, item.Item2));
                }
                else
                {
                    // If the socket is not connected, remove the corresponding row from the DataGridView
                    string[] reciveImei = await StartPingParser.Parse(item.Item2);
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
                            rowsToRemove.Add(row);
                        }
                    }
                    foreach (var rowToRemove in rowsToRemove)
                    {
                        dataGridView.Invoke(new Action(() =>
                        {
                            if (dataGridView.Rows.Contains(rowToRemove))
                            {
                                dataGridView.Rows.Remove(rowToRemove);
                                dataGridView.Refresh();
                            }
                        }));
                    }
                }
            }
            HelperProperties.Properties.IncomingData = incomingDataConnected;
        }


    }
}
