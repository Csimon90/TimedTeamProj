using Microsoft.AspNetCore.Mvc;

namespace TimedTeam.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
    }
}
