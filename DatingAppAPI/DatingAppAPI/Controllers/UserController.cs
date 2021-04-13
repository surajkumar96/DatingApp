using DatingAppAPI.Data;
using DatingAppAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users =await _context.User.ToListAsync();
            
            
            return users;
        }

        // api/user/3
        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);


            return user;    
        }

    }
}
