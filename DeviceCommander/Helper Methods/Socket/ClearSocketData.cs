﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Socket
{
    public static class ClearSocketData
    {
        public static void CloseConnection()
        {
            foreach (var item in HelperProperties.Properties.IncomingData)
            {
                item.Item1.Close();
            }
            foreach (var item in HelperProperties.Properties.IncomingSockets)
            {
                item.Close();
            }
            HelperProperties.Properties.IncomingData=new List<(TcpClient, string)>();
            HelperProperties.Properties.IncomingSockets= new List<TcpClient>();
        }
    }
}
