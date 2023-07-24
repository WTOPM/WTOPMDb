using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WTOPMDb.Data;

namespace WTOPMDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {   
    

        private readonly ILogger<WeatherForecastController> _logger;

        public DataContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeathers()
        {
          //var weathers = await _context.Weathers.ToListAsync();

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWeather(int id)
        {
           // var weather = await _context.Weathers.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(); 
        }
    }
}