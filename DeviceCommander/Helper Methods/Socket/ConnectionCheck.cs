using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Socket
{
    public class ConnectionCheck
    {
        public static async Task IsConnected()
        {
            foreach (var item in HelperProperties.Properties.IncomingSockets)
            {
                if(!item.Connected)
                    HelperProperties.Properties.IncomingSockets.Remove(item); //BUG:System.InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
            }
        }
    }
}
