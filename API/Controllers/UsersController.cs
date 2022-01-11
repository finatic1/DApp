using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly DataContext _context; //access to database
    public UsersController(DataContext context)
    {
      _context = context;
    }

    [HttpGet] //getting data
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //gets all users and id 
    {
      return await _context.Users.ToListAsync(); //sends back list of users when request goes to database this code pauses


    }
    // api/users/3
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id) // gets specific user
    {
      return await _context.Users.FindAsync(id);
    }
  }
}