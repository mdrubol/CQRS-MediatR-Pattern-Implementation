using Barbar.Core.Repositories.Base;
using Barbar.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbar.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly BarbarContext _BarbarContext;

        public Repository(BarbarContext BarbarContext)
        {
            _BarbarContext = BarbarContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _BarbarContext.Set<T>().AddAsync(entity);
            await _BarbarContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _BarbarContext.Set<T>().Remove(entity);
            await _BarbarContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _BarbarContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _BarbarContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
