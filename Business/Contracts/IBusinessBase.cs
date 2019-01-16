using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IBusinessBase<T>
    {
        Task<IEnumerable<T>> FindAllAsync();
        Task<T> FindByIdAsync(int id);
        Task DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> CreateAsync(T entity);
    }
}
