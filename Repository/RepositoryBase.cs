using Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.RepositoryContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await this.RepositoryContext.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<T> CreateAsync(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
            await this.RepositoryContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            //TODO To validate the status implementation
            this.RepositoryContext.Entry(entity).State = EntityState.Modified;
            this.RepositoryContext.Set<T>().Update(entity);
            await this.RepositoryContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
            await this.RepositoryContext.SaveChangesAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await this.RepositoryContext.Set<T>().FindAsync(id);
        }
    }
}
