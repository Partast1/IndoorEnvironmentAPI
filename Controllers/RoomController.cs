using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLibrary;
using TempClassLibrary;

namespace IndoorEnvironmentAPI.Controllers
{
    /// <summary>
    /// This is where i give all the documentaion for rooms
    /// </summary>
    public class RoomController : ApiController
    {
        DatabaseCrud dbc = new DatabaseCrud();
        List<Room> rooms = new List<Room>();
        /// <summary>
        /// Gets a list of rooms  
        /// </summary>
        /// <returns>List of roomnumbers</returns>
        // GET: api/Room
        public List<Room> Get()
        {
            rooms = dbc.ReadRoom();
            return rooms;
        }

        // GET: api/Room/5
        public Room Get(int id)
        {
            rooms = dbc.ReadRoom();
            Room room = rooms.ElementAt(id);
            return room;
        }

        // POST: api/Room
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Room/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Room/5
        public void Delete(int id)
        {
        }
    }
}
