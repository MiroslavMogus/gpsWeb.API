using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gpsWeb.API.Data;
using gpsWeb.API.Models;

namespace gpsWeb.API.Controllers
{
    // [Produces("application/json")]
    [Route("api/[controller]")]
    public class CoordinatesController : Controller
    {
        private readonly IGpsRepository _repo;

        public CoordinatesController(IGpsRepository repo)
        {
            _repo = repo;
        }

        // GET: api/coordinates/
        [HttpGet("{vehicle_nr}")]
        public async Task<IActionResult> GetCoordinates(double vehicle_nr)
        {
            var coordinates = await _repo.GetCoordinates(vehicle_nr);

            return Ok(coordinates);
        }

    }
}