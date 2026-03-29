using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HST_Audit.Infrastructure.Data;
using HST_Audit.Domain.Entities;
using HST_Audit.Application.DTOs;

namespace HST_Audit.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
public async Task<IActionResult> Register(RegisterUserDto dto)
{
    var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "Admin");

    if (role == null)
        return BadRequest("Default role not found");

    var existingUser = await _context.Users
    .FirstOrDefaultAsync(u => u.Email == dto.Email);

    if (existingUser != null)
    return BadRequest("Email already exists");

    var user = new User
    {
        Id = Guid.NewGuid(),
        FullName = dto.FullName,
        Email = dto.Email,
        PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
        RoleId = role.Id
    };

    _context.Users.Add(user);
    await _context.SaveChangesAsync();

    return Ok(new
{
    user.Id,
    user.FullName,
    user.Email,
    Role = role.Name
});
}
    }
}