using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SehirRehberi.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private DataContext _context;

        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }
                         
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var cities =await _context.Cities.ToListAsync();
            return Ok(cities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id == id);
            return Ok(city);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
    }
}
