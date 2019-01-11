using Business.Contracts;
using Entities.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class UserBusiness : IUserBusiness
    {
        public IUserRepository _repository { get; set; }

        public UserBusiness(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Create(User user)
        {
            _repository.Create(user);
        }
    }
}
