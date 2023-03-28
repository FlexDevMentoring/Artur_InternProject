using Microsoft.AspNetCore.Mvc;

namespace InternProjectV3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var list1 = new List<string>();

            return new string[] { "value1", "value2" };
        }
    }
}
