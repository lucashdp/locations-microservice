using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace locations_microservice.Controllers
{
    [Route("v1/public/[controller]")]
    [ApiController]
    public class LocationsController : Controller
    {
        // GET v1/public/locations
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "location1", "location2" };
        }

        // GET v1/public/locations/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "location";
        }

        // POST v1/public/locations
        [HttpPost]
        public void Post([FromBody] string location)
        {
        }

        // PUT v1/public/locations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string location)
        {
        }

        // DELETE v1/public/locations/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}