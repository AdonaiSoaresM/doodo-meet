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
        private readonly IListUserService _listUserService;

        public UserController(IAddUserService addUserService, IListUserService listUserService = null)
        {
            _addUserService = addUserService;
            _listUserService = listUserService;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            await _addUserService.Handle();
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _listUserService.Handle();
            return Ok(users);
        }
    }
}
