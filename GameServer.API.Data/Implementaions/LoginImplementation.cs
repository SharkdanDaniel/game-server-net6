using GameServer.API.Data.Context;
using GameServer.API.Data.Repository;
using GameServer.API.Domain.Entities;
using GameServer.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Data.Implementaions
{
    public class LoginImplementation : BaseRepository<User>, ILoginRepository
    {
        private DbSet<User> _dataset;

        public LoginImplementation(MyContext context) : base(context)
        {
            this._dataset = context.Set<User>();
        }
        public async Task<User> FindByLogin(string email, string password)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }
    }
}
