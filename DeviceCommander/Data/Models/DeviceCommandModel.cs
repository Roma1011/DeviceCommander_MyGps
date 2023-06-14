using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DeviceCommander.Data.Models
{
    public class DeviceCommandModel
    {
        public string Imei { get; set; }
        public string Command { get; set; }
        public string Status { get; set; }
        public string DataTime { get; set; }
    }
}
