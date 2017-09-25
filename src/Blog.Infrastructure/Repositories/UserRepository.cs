using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Core.Domain;
using Blog.Core.Repositories;

namespace Blog.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}