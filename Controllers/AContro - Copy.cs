//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//using WTOPMDb.Data;

//namespace WTOPMDb.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class AuthController : ControllerBase
//    {

//        private readonly DataContext _context;
//        private readonly ILogger<AuthController> _logger;
//        private readonly IAuthRepository _repo;
//        private readonly IConfiguration _config;

//        public AuthController(DataContext context, ILogger<AuthController> logger, IAuthRepository repo, IConfiguration config)
//        {
//            _context = context;
//            _logger = logger;
//            _repo = repo;
//            _config = config;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetWeathers()
//        {
//          //var weathers = await _context.Weathers.ToListAsync();

//            return Ok();
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetWeather(int id)
//        {
//           // var weather = await _context.Weathers.FirstOrDefaultAsync(x => x.Id == id);

//            return Ok(); 
//        }
//    }
//}