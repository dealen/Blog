using Blog.Infrastructure.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("[controller]")]
    public abstract class ApiControllerBase : Controller
    {
        protected readonly ICommandDispatcher _commandDispatcher;

        protected ApiControllerBase(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }
    }
}