using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IUserBusiness : IBusinessBase<User>
    {
        Task<IEnumerable<User>> FindByName(string name);
    }
}
