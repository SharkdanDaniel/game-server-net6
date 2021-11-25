using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.API.Domain.Entities;

namespace GameServer.API.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> SelectAsync(int skip, int take);
        Task<int> CountAsync();
        Task<T> SelectAsync(Guid id);
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistAsync(Guid id);
    }
}
