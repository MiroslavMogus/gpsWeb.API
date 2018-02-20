using gpsWeb.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gpsWeb.API.Data
{
    public interface IGpsRepository
    {

        Task<IEnumerable<Coordinate>> GetCoordinates(double vehicle_nr);

        Task<Coordinate> GetCoordinate(int id);
    }
}
