using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using WTOPMDb.Data;

namespace WTOPMDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {   
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public DataContext _context { get; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //   })
        //    .ToArray();
        //}

        [HttpGet]
        public IActionResult GetWeathers()
        {
          var weathers = _context.Weathers.ToList();

            return Ok(weathers);
        }

        [HttpGet("{id}")]
        public IActionResult GetWeather(int id)
        {
            var weather = _context.Weathers.FirstOrDefault(x => x.Id == id);

            return Ok(weather); 
        }
    }
}