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
        string filePath = "C:\\Users\\Administrator\\Desktop\\net7.0-windows\\Data.txt";

        public async Task InFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (DeviceCommandModel data in HelperProperties.Properties.Writer)
                {
                    await writer.WriteLineAsync($"{data.Imei}\t{data.Command}\t{data.Status}");
                }
            }
        }
    }
}
