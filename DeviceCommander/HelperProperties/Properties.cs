using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.HelperProperties
{
    public class Properties
    {
        private static List<TcpClient> incomingSockets = new List<TcpClient>();

        public static List<TcpClient> IncomingSockets
        {
            get { return incomingSockets; }
            set { incomingSockets = value; }
        }

        public static List<(TcpClient,string)> IncomingData { get; set; }=new List<(TcpClient,string)> { };
        public static List<TcpClient> incomingSocketsCopy { get; set; }
    }
}
