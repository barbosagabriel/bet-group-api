using Business.Contracts;
using Entities.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessBase<T> : IBusinessBase<T> where T : BaseEntity
    {
        public IRepositoryBase<T> _repository { get; set; }

        public BusinessBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public Task DeleteAsync(T entity)
        {
            return _repository.DeleteAsync(entity);
        }

        public Task<IEnumerable<T>> FindAllAsync()
        {
            return _repository.FindAllAsync();
        }

        public Task<T> FindByIdAsync(int id)
        {
            return _repository.FindByIdAsync(id);
        }

        public Task<T> UpdateAsync(T entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public Task<T> FindById(int id)
        {
            return _repository.FindByIdAsync(id);
        }

        public Task<T> CreateAsync(T entity)
        {
            return _repository.CreateAsync(entity);
        }
    }
}
