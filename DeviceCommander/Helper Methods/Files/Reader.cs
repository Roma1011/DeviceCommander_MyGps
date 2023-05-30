using DeviceCommander.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceCommander.Helper_Methods.Files
{
    public class Reader
    {
        string filePath = "G:\\Users\\Administrator\\Desktop\\DeviceCommander\\Data.txt";
        public async Task ReaderInFile(DataGridView DataGridView)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');

                        DeviceCommandModel data = new DeviceCommandModel
                        {
                            Imei = parts[0],
                            Command = parts[1],
                            Status = parts[2]
                        };

                        bool exists = HelperProperties.Properties.Reader.Any(x => x.Imei == data.Imei);

                        if (!exists)
                        {
                            HelperProperties.Properties.Reader.Add(data);
                            DataGridView.Invoke((MethodInvoker)delegate
                            {
                                DataGridView.Rows.Add(data.Imei, data.Command, data.Status);
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
