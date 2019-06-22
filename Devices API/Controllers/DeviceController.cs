using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Devices_API.Models;
using Newtonsoft.Json;
using System.Web.Script;
using System.Web.Script.Serialization;


namespace Devices_API.Controllers
{
    [Route("api/device")]
[ApiController]
public class DeviceController : ControllerBase
{
    // GET: api/<controller>
    [HttpGet]
    public void Get()
    {
        /*return new Device[]
            {
            new Device
            {
                metricDate = DateTime.UtcNow.ToString(),
                deviceType = "Humidity Sensor",
                metricValue = "20.31"
            }  
        };*/
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public int Get(int id)
    {
        return id;
    }

    // POST api/device
    [HttpPost]
    public IActionResult Post([FromBody]Object content)
    {
            try
            {
                var jsonstring = JsonConvert.SerializeObject(content);
                Device device = JsonConvert.DeserializeObject<Device>(jsonstring);
                return Ok();
                //return Created(device);
            }
            catch
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status405MethodNotAllowed);
            }
    }
    [HttpPost("{deviceId}/telemetry")]
    public IActionResult Post([FromBody]Object content, string deviceId)
    {
            try
            {
                var jsonstring = JsonConvert.SerializeObject(content);
                Telemetry telemetry = JsonConvert.DeserializeObject<Telemetry>(jsonstring);
                var sender = new Send { };
                sender.publish(jsonstring);


                return Ok();
            }
            catch
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status405MethodNotAllowed);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
