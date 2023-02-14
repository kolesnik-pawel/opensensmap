﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpensenseMap.Models
{
    internal class Sensor
    {
        public string title { get; set; }
        public string unit { get; set; }
        public string sensorType { get; set; }
        public string icon { get; set; }
        public string _id { get; set; }
        public string lastMeasurement { get; set; }
    }
}
