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
        public static List<Socket> IncomingSockets { get; set; }= new List<Socket>();
        public static List<(Socket,string)> IncomingData { get; set; }=new List<(Socket,string)> { };
    }
}
