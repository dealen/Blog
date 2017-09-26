using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Domain;
using Blog.Core.Repositories;

namespace Blog.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>(){
            new User(Guid.NewGuid(), "test1@email.com", "dealen", "admin", "secret", Guid.NewGuid().ToString("N")),
            new User(Guid.NewGuid(), "test2@email.com", "kuba", "user", "secret", Guid.NewGuid().ToString("N"))
        };
        

        public async Task<User> GetAsync(Guid id)
            => await Task.FromResult(_users.SingleOrDefault(x => x.Id == id));
            // => await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
        

        public async Task<User> GetAsync(string email)
            => await Task.FromResult(_users.SingleOrDefault(x => x.Email == email));

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Task.FromResult(_users);
        }

        public async Task AddAsync(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
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