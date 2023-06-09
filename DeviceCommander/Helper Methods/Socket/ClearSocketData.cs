﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceCommander.Helper_Methods.Socket
{
    public static class ClearSocketData
    {
        public static void CloseConnection(ref DataGridView view)
        {
            foreach (var item in HelperProperties.Properties.IncomingData)
            {
                item.Item1.Dispose();
            }
            foreach (var item in HelperProperties.Properties.IncomingSockets)
            {
                item.Dispose();
            }
            HelperProperties.Properties.IncomingData=new List<(System.Net.Sockets.Socket, string)>();
            HelperProperties.Properties.IncomingSockets= new List<System.Net.Sockets.Socket>();
            HelperProperties.Properties._listenerSocket.Close();
            view.Rows.Clear();
        }
    }
}
