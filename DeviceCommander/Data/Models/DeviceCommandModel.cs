using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Data.Models
{
    public class DeviceCommandModel
    {
        public string Imei { get; set; }
        public string Command { get; set; }
        public string Status { get; set; }
    }
}
