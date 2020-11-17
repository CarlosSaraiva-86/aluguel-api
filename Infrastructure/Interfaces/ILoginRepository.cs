using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces
{
    public interface ILoginRepository
    {
        Login Get(string user, string password);
        void Set(string user, string password);
    }
}
