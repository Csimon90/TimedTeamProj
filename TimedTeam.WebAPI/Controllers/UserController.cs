using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimedTeam.Data;
 using TimedTeam.Services.User;

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
