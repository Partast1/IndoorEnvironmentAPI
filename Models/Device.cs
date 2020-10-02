using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndoorEnvironmentAPI.Models
{
    /// <summary>
    /// Represents one specific device
    /// </summary>
    public class Device
    {
        

        private double temp;
        private int humidity;
        /// <summary>
        /// Temperature from the device
        /// </summary>
        public double Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        /// <summary>
        /// Humidity from the device
        /// </summary>
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
    }
}