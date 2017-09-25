using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Infrastructure.DTO;

namespace Blog.Infrastructure.Services
{
    public interface IUserService
    {
        Task<UserDto> GetAsync(string email);
        Task<UserDto> GetAsync(Guid id);
        Task<IEnumerable<UserDto>> BrowseAsync();
        Task RegisterAsync(Guid userId, string email, string username, string password, string role);
        Task LoginAsync(string email, string password);
    }
}