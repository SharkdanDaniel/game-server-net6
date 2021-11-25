using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.API.Domain.Dtos.Server;
using GameServer.API.Domain.Entities;
using GameServer.API.Domain.Interfaces;
using GameServer.API.Domain.Interfaces.Services.Server;
using Microsoft.EntityFrameworkCore;
using GameServer.API.Data.Context;
using GameServer.API.Domain.Dtos.ListModel;

namespace GameServer.API.Service.Services
{
    public class ServerService : IServerService
    {
        private IRepository<Server> _repository;
        private DbSet<Server> _dataset;
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public ServerService(IRepository<Server> repository, IMapper mapper, MyContext context)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._context = context;
            this._dataset = this._context.Set<Server>();
        }

        public async Task<ServerDto> Get(Guid id)
        {
            //var entity = await _repository.SelectAsync(id);
            var entity = await _context.Servers
                        //.Include(h => h.Parcels)
                        //.Include(h => h.ExpTable)
                        //.Include(h => h.AvailableItems)
                        //.Include(h => h.AvailableDisease)
                        .SingleOrDefaultAsync(p => p.Id.Equals(id));

            return _mapper.Map<ServerDto>(entity);
        }

        public async Task<ListModel<ServerDto>> GetAll(int skip, int take)
        {
            //var listEntity = await _repository.SelectAsync();
            var listEntity = await _context.Servers
                        //.Include(h => h.Parcels)
                        //.Include(h => h.ExpTable)
                        //.Include(h => h.AvailableItems)
                        //.Include(h => h.AvailableDisease)
                        //.Include(h => h.AvailableDisease)
                        .Skip(skip)
                        .Take(take)
                        .ToListAsync();
            var total = await _context.Servers.CountAsync();
            var items = _mapper.Map<IEnumerable<ServerDto>>(listEntity);

            return new ListModel<ServerDto> { items = items, total = total };
        }

        public async Task<ServerDto> Post(ServerDtoCreate server)
        {
            var entity = _mapper.Map<Server>(server);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ServerDto>(result);
        }

        public async Task<ServerDto> Put(ServerDtoUpdate server)
        {
            var entity = _mapper.Map<Server>(server);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ServerDto>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
