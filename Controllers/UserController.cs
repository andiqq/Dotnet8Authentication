using DotNet8Authentication.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet8Authentication.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly DataContext db;

    public UserController(DataContext context)
    {
        db = context;
    }
    // GET: User
    [HttpGet]
    public async Task<ActionResult<IEnumerable<IdentityUser>>> GetUser()
    {
        return await db.Users.ToListAsync();
    }
    
}