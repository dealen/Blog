using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Core.Domain;

namespace Blog.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id); 
        Task<User> GetAsync(string email);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task RemoveAsync(Guid id);
    }
}