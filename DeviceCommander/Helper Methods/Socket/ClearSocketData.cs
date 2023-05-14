using System;
using System.Collections.Generic;
using System.Linq;
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
            HelperProperties.Properties.IncomingData=new List<(System.Net.Sockets.Socket, string)>();
            HelperProperties.Properties.IncomingSockets= new List<System.Net.Sockets.Socket>();
        }
    }
}
