using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.API.Domain.Dtos.ListModel;
using GameServer.API.Domain.Dtos.User;

namespace GameServer.API.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserDto> Get(Guid id);
        Task<ListModel<UserDto>> GetAll(int skip, int take);
        Task<UserDto> Post(UserDtoCreate owner);
        Task<UserDto> Put(UserDtoUpdate owner);
        Task<bool> Delete(Guid id);
    }
}
