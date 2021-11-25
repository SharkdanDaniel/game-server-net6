using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.API.Data.Context;
using GameServer.API.Domain.Entities;
using GameServer.API.Domain.Interfaces;

namespace GameServer.API.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private DbSet<T> _dataset;

        public BaseRepository(MyContext context)
        {
            this._context = context;
            this._dataset = this._context.Set<T>();
        }

        public async Task<IEnumerable<T>> SelectAsync(int skip, int take)
        {
            try
            {
                return await _dataset.Skip(skip).Take(take).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public async Task<int> CountAsync()
        {
            try
            {
                return await _dataset.CountAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                item.CreatedAt = DateTime.UtcNow;
                item.UpdatedAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();

                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null) return null;

                item.CreatedAt = item.CreatedAt;
                item.UpdatedAt = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();

                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null) return false;

                _dataset.Remove(result);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }
    }
}
