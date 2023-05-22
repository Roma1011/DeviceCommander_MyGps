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
                bool connected =await SocketConnected(item);
                if (!connected)
                {
                    connectedSockets.Add(item);
                }
            }

            HelperProperties.Properties.IncomingSockets = connectedSockets;

            foreach (var item in incomingDataCopy)
            {
                bool connected =await SocketConnected(item.Item1);
                if (connected)
                {
                    incomingDataConnected.Add((item.Item1, item.Item2));
                }
                else
                {
                    rowsToRemove.Clear(); // Clear the list before using it again
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        bool match = true;
                        for (int i = 0; i < 1; i++)
                        {
                            if (row.Cells[i].Value == null || row.Cells[i].Value.ToString() != item.Item2.ToString())
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
        public static async Task<bool> SocketConnected(System.Net.Sockets.Socket s)
        {
            try
            {
                bool part1 = s.Poll(1000, SelectMode.SelectRead);
                bool part2 = (s.Available == 0);
                if (part1 && part2)
                    return false;
                else
                    return true;
            }
            catch(Exception ex)
            {
                s.Dispose();
                return false;
            }
        }
    }
}
