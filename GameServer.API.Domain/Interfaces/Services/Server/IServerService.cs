using GameServer.API.Domain.Dtos.ListModel;
using GameServer.API.Domain.Dtos.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Interfaces.Services.Server
{
    public interface IServerService
    {
        Task<ServerDto> Get(Guid id);
        Task<ListModel<ServerDto>> GetAll(int skip, int take);
        Task<ServerDto> Post(ServerDtoCreate server);
        Task<ServerDto> Put(ServerDtoUpdate server);
        Task<bool> Delete(Guid id);
    }
}
