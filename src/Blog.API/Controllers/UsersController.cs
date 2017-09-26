using System.Threading.Tasks;
using Blog.Infrastructure.DTO;
using Blog.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userservice;

        public UsersController(IUserService userService)
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
    }
}