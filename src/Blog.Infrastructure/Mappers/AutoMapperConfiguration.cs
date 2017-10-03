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
                //cfg.CreateMap<Driver, DriverDto>();
                //cfg.CreateMap<Driver, DriverDetailsDto>();
                //cfg.CreateMap<Node, NodeDto>();
                //cfg.CreateMap<Route, RouteDto>();
                cfg.CreateMap<User, UserDto>();
                //cfg.CreateMap<Vehicle, VehicleDto>();;
            }).CreateMapper();
    }
}