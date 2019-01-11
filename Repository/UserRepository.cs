using Entities;
using Entities.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
