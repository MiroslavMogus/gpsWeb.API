using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gpsWeb.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace gpsWeb.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetCoordinates()
        {
            var coordinates = _context.Coordinates.ToList();

            return Ok(coordinates);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetCoordinate(int id)
        {
            var coordinate = _context.Coordinates.FirstOrDefault(x => x.Id == id);

            return Ok(coordinate);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
