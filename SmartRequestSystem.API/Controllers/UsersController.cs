using Microsoft.AspNetCore.Mvc;
using SmartRequestSystem.Infrastructure.Persistence;
using SmartRequestSystem.Domain.Domain.Entities;

namespace SmartRequestSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users
                .Select(u => new
                {
                    u.Id,
                    u.FullName,
                    u.Email
                })
                .ToList();

            return Ok(users);
        }
    }
}
