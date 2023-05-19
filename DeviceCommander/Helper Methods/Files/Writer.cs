using DeviceCommander.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Files
{
    public class Writer
    {
        string filePath = "C:\\Dot.net\\DeviceCommander\\DeviceCommander\\Data\\Files\\Data.txt";

        public async Task InFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath, true)) // Pass 'true' for append parameter
            {
                foreach (DeviceCommandModel data in HelperProperties.Properties.dataList)
                {
                    await writer.WriteLineAsync($"{data.Imei}\t{data.Command}\t{data.Status}");
                }
            }
        }
    }
}
