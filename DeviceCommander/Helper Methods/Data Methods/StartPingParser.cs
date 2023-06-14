using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Pars_Data
{
    public class StartPingParser
    {
        static string[] DeviceDataForDataGrid { get; set; } = new string[2];
        public static string[]? Parse(string StartMessage)
        {
            try
            {
                //if (StartMessage[0] == 'A')
                //{
                //    MessageBox.Show(StartMessage);
                //}
                //if (StartMessage[0] == 'P')
                //    MessageBox.Show(StartMessage);
                if (StartMessage[0] != 'S')
                    return default;
                string[] parts = StartMessage.Split(';');
                DeviceDataForDataGrid = new string[] { parts[1], parts[2] };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } 
            return DeviceDataForDataGrid;
        }
    }
}
