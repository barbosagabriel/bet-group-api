using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contracts
{
    public interface IUserBusiness
    {
        void Create(User user);
    }
}
