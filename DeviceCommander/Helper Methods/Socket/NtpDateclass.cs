using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ListeningIMEI;
public class NtpDateclass
{
	public static DateTime GetNetworkTime()
	{

		try
		{
            const string ntpServer = "pool.ntp.org";

			var ntpData = new byte[48];
            ntpData[0] = 0x1B;

			var addresses = Dns.GetHostEntry(ntpServer).AddressList;

			var ipEndPoint = new IPEndPoint(addresses[0], 123);

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
			{
				socket.Connect(ipEndPoint);
                socket.ReceiveTimeout = 3000;

				socket.Send(ntpData);
				socket.Receive(ntpData);
				socket.Close();
			}

			const byte serverReplyTime = 40;

			ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

			ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);
            intPart = SwapEndianness(intPart);
			fractPart = SwapEndianness(fractPart);

			var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

			//**UTC** time
			var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

			return networkDateTime.ToLocalTime();
		}
		catch (Exception ex)
		{
			var Dt = DateTime.Now.ToLocalTime();
			return Dt;
		}

	}
    static uint SwapEndianness(ulong x)
	{
		return (uint)(((x & 0x000000ff) << 24) +
					   ((x & 0x0000ff00) << 8) +
					   ((x & 0x00ff0000) >> 8) +
					   ((x & 0xff000000) >> 24));
	}
}
