using System.Threading.Tasks;
using Blog.Infrastructure.Commands;
using Blog.Infrastructure.Commands.Users;
using Blog.Infrastructure.DTO;
using Blog.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    public class UsersController : ApiControllerBase
    {
        private readonly IUserService _userservice;

        public UsersController(IUserService userService, ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
            _userservice = userService;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> Get(string email)
        {
            var result = await _userservice.GetAsync(email);
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _userservice.BrowseAsync();
            return Json(result);
        }        

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await _commandDispatcher.DispatchAsync(command);

            return Created($"users/{command.Email}", new object());
        }
    }
}