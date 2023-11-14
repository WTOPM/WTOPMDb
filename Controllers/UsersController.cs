using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;

using System.Text;

using WTOPMDb.Data;
using WTOPMDb.Dtos;
using WTOPMDb.Models;

namespace WTOPMDb.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
               var users = await _context.Users.ToListAsync();

            return Ok(users);
        }
        }
    }
