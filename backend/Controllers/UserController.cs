using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAddUserService _addUserService;

        public UserController(IAddUserService addUserService) {
            _addUserService = addUserService;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var a = HttpContext.User;
            await _addUserService.Handle();
            return NoContent();
        }
    }
}
