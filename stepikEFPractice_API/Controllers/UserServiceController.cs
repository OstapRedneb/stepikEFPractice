using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using stepikEFPractice.Services;
using stepikEFPractice.Models;

namespace stepikEFPractice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserServiceController : ControllerBase
    {
        private readonly UserService _service;
        public UserServiceController()
        {
            _service = new UserService();
        }
        [HttpGet]
        public IActionResult GetUser(string fullName)
        {
            User? user = _service.Get(fullName);

            return user is null ? NotFound("не нашёл ёклмн") : Ok(user);
        }
    }
}
