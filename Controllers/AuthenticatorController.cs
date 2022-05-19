using authentication_jwt.Dto;
using authentication_jwt.Repository;
using authentication_jwt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authentication_jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticatorController : ControllerBase
    {
        [HttpPost]
        [Route("login")]        
        public IActionResult Login([FromBody] LoginDto dto)
        {
            try
            {
                var user = UserRepository.VerifyUserAndPassword(dto.UserName, dto.Password);

                if (user == null)
                    return NotFound();

                var token = TokenService.GenerateToken(user);
                return Ok(token);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
