using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetworkingAPI.Data;
using NetworkingAPI.Dtos;
using NetworkingAPI.Models;

namespace NetworkingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            // validate request

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();
            if (await _authRepository.UserExists(userForRegisterDto.Username))
            {
                return BadRequest("Username already exists");
            }

            var userToCreate = new User
            {
                UserName = userForRegisterDto.Username
            };

            var createdUser = await _authRepository.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}