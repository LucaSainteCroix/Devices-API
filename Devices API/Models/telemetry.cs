using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devices_API.Models
{
    public class Telemetry
{
        public string metricDate { get; set; }
        public DeviceType deviceType { get; set; }
        public string metricValue { get; set; }
    }
}
