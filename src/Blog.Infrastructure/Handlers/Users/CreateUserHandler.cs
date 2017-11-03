using System;
using System.Threading.Tasks;
using Blog.Infrastructure.Commands;
using Blog.Infrastructure.Commands.Users;
using Blog.Infrastructure.Services;

namespace Blog.Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _userService;

        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task HandleAsync(CreateUser command)
        {
            await _userService.RegisterAsync(command.Email, command.Password, command.Role, command.Username);
        }
    }
}