using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gpsWeb.API.Models
{
    public class Coordinate
    {
        public int Id { get; set; }

        public double Vehicle_Nr { get; set; }

        public float Lat { get; set; }

        public float Lng { get; set; }

        public DateTime Time { get; set; }

    }
}
