using Business.Contracts;
using Entities.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserBusiness : BusinessBase<User>, IUserBusiness
    {        
        public UserBusiness(IRepositoryBase<User> repository) : base(repository)
        {
        }

        public Task<IEnumerable<User>> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
