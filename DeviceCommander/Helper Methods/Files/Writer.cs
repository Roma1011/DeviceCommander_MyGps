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
        string filePath = "Data.txt";
        string filePath2 = "Data.txt";

        public async Task InFile(List<DeviceCommandModel> commands)
        {
            DateTime myDateTime = DateTime.Now;
            if (!File.Exists(filePath2))
            {
                string directoryPath = Path.GetDirectoryName(filePath2);
                Directory.CreateDirectory(directoryPath);
                File.Create(filePath2).Close();
            }

            using (StreamWriter writer = new StreamWriter(filePath2, true))
            {
                foreach (DeviceCommandModel data in commands)
                {
                    await writer.WriteLineAsync($"{data.Imei}\t{data.Command}\t{data.Status}\t{myDateTime.ToString()}");
                }
            }
        }
    }
}
