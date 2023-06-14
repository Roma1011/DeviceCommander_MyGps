using DeviceCommander.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeviceCommander.Helper_Methods.Files
{
    public class Reader
    {
        private static List<DeviceCommandModel> readerCM = new List<DeviceCommandModel>();
        private DeviceCommandModel data; 
        string filePath = "Data.txt";
        string filePath2 = "Data.txt";
        public async Task ReaderInFile(DataGridView DataGridView)
        {
            if (!File.Exists(filePath2))
            {
                try
                {
                    using (FileStream fs = File.Create(filePath2))
                    {
                        // File created successfully
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to create file: {ex.Message}");
                    return;
                }
            }
            using (StreamReader reader = new StreamReader(filePath2))
            {
                try
                {
                    string imei = "";
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        imei = parts[0];

                        data = new DeviceCommandModel
                        {
                            Imei = parts[0],
                            Command = parts[1],
                            Status = parts[2],
                            DataTime = parts[3]
                        };

                        int index = readerCM.FindIndex(s => s.Imei == imei);

                        if (index != -1)
                        {
                            DeviceCommandModel dataToUpdate = readerCM[index];
                            dataToUpdate.Imei = parts[0];
                            dataToUpdate.Command = parts[1];
                            dataToUpdate.Status = parts[2];
                            dataToUpdate.DataTime = parts[3];
                        }
                        else
                        {
                            readerCM.Add(data);
                        }
                    }

                    DataGridView.Invoke((MethodInvoker)delegate
                    {
                        DataGridView.Rows.Clear(); // Clear existing rows before adding new ones

                        foreach (DeviceCommandModel rowData in readerCM)
                        {
                            DataGridView.Rows.Add(rowData.Imei, rowData.Command, rowData.Status, rowData.DataTime);
                        }
                    });
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                }
            }

        }
    }
}
