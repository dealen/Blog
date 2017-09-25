using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Core.Domain;
using Blog.Core.Repositories;
using Blog.Infrastructure.DTO;

namespace Blog.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDto>> BrowseAsync()
        {
            var users = _userRepository.GetAllAsync();

            //return _mapper.Map<UserDto>(users);
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetAsync(Guid id)
        {
            var user = await _userRepository.GetAsync(id);

            return _mapper.Map<UserDto>(user);
        }

        public async Task LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(Guid userId, string email, string username, string password, string role)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
                throw new Exception($"User with prowided email: {email} already exist.");
            
            var salt = Guid.NewGuid().ToString("N");
            //user = new User(userId, email, username, password, salt);
        }
    }
}