using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndoorEnvironmentAPI.Models
{
    /// <summary>
    /// Represents one specific room
    /// </summary>
    public class Room
    {
        private int roomNumber;
        private string hallIndicator;
        private int id;
        /// <summary>
        /// Number of room.
        /// </summary>
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        /// <summary>
        /// What hall the room in locationed on.
        /// </summary>
        public string HallIndicator
        {
            get { return hallIndicator; }
            set { hallIndicator = value; }
        }
        /// <summary>
        /// Indentifier
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}