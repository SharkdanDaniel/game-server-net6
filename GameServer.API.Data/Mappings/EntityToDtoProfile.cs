using AutoMapper;
using GameServer.API.Domain.Dtos.Server;
using GameServer.API.Domain.Dtos.User;
using GameServer.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Data.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Server, ServerDto>().ReverseMap();
            CreateMap<Server, ServerDtoCreate>().ReverseMap();
            CreateMap<Server, ServerDtoUpdate>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDtoCreate>().ReverseMap();
            CreateMap<User, UserDtoUpdate>().ReverseMap();
        }
    }
}
