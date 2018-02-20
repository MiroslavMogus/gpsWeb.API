using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gpsWeb.API.Models;
using Microsoft.EntityFrameworkCore;

namespace gpsWeb.API.Data
{
    public class GpsRepository : IGpsRepository
    {

        private readonly DataContext _context;

        public GpsRepository (DataContext context)
        {
            _context = context;
        }

        public Task<Coordinate> GetCoordinate(int id)
        {
            var coordinate = _context.Coordinates.Include(p => p.Vehicle_Nr).FirstOrDefaultAsync(u => u.Id == id);

            return coordinate;
        }

        public async Task<IEnumerable<Coordinate>> GetCoordinates(double vehicle_nr)
        {
            var coordinates = await _context.Coordinates.Where(x => x.Vehicle_Nr == vehicle_nr).ToListAsync();

            return coordinates;
        }
    }
}
