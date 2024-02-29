using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<String> Get()
        {
            return Enumerable.Range(1, 5).Select(index => index.ToString())
            .ToArray();
        }
    }
}
