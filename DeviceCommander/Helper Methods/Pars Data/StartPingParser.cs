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
            //MessageBox.Show("Complite step 6");

            try
            {
                if (StartMessage[0] != 'S')
                    return default;
                //MessageBox.Show("Complite step 6.1");
                string[] parts = StartMessage.Split(';');
                //MessageBox.Show("Complite step 6.2");
                DeviceDataForDataGrid = new string[] { parts[1], parts[2] };
                //MessageBox.Show("Complite step 6.3");
                //MessageBox.Show(parts[1] + parts[2]);
                //MessageBox.Show("Complite step 6.4");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //MessageBox.Show(DeviceDataForDataGrid[0] +"Complite step 7");

            return DeviceDataForDataGrid;
        }
    }
}
