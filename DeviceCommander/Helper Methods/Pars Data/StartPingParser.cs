using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Pars_Data
{
    public class StartPingParser
    {
        string[] DeviceDataForDataGrid { get; set; } = new string[2];
        public async Task<string[]> Parse(string StartMessage)
        {
            if (StartMessage[0] != 'S')
                return null;

            string[] parts = StartMessage.Split(';');

            DeviceDataForDataGrid = new string[] { parts[1], parts[2] };
            return DeviceDataForDataGrid;
        }
    }
}
