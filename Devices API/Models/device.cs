using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devices_API.Models
{


    public class Device
    {
        public string id { get; set; }
        public string name { get; set; }
        public DeviceType deviceType { get; set; }
    }
}
