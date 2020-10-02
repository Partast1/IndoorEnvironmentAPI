using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLibrary;
using TempClassLibrary;
using System.Web.Http.Cors;

namespace IndoorEnvironmentAPI.Controllers
{
    public class DeviceController : ApiController
    {
        DatabaseCrud dbc = new DatabaseCrud();
        List<Device> devices = new List<Device>();
        // GET: api/Device
        public List<Device> Get()
        {
           devices = dbc.ReadDevice();
            return devices;
        }

        // GET: api/Device/5
        public Device Get(int id)
        {
            devices = dbc.ReadDevice();
            Device device = devices.ElementAt(id);
            return device;
        }

        // POST: api/Device
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Device/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Device/5
        public void Delete(int id)
        {
        }
    }
}
