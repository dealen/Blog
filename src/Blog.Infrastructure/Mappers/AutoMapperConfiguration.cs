using AutoMapper;
using Blog.Core.Domain;
using Blog.Infrastructure.Commands;
using Blog.Infrastructure.DTO;

namespace Blog.Infrastructure.Mappers
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Init()
            => new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDto>();
            }).CreateMapper();
    }
}