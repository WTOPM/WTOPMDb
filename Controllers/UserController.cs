using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WTOPMDb.Data;

namespace WTOPMDb.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWtopmDbRepository _repo;

        public UserController(IWtopmDbRepository repo)
        {
            _repo = repo;
        }
        //
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = _repo.GetUsers();
            return Ok(users);
        }
        //
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id) 
        {
            var user = _repo.GetUser(id);
            return Ok(user);
        }
    }
}
