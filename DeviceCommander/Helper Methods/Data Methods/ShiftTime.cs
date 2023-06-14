using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Helper_Methods.Data_Methods
{
    public class ShiftTime
    {
        public static string GetFormattedShiftTime(string input, string date)
        {
            if (input.Length == 3)
            {
                return input;
            }
            else
            {
                return input.Substring(0, 1) + date + input.Substring(1);
            }
        }
    }
}
